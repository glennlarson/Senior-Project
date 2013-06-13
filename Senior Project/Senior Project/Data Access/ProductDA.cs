/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Product Data Access*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections;

namespace Senior_Project
{
    class ProductDA
    {
        //declarations
        private static ArrayList prodList;
        private static Product aProduct;
        private static DataSet ds;
        private static OleDbDataAdapter dbAdapter;
        private static OleDbCommand command;
        private static string submissionReport = "";
        //create product in database
        public static string CreateProduct(Product aProduct)
        {
            submissionReport = "";
            try
            {
                // insert statemet
                string sql = "INSERT INTO Prod (prodSKU, prodName, prodType, prodCost, qtyOH, reOrderPt)" +
                  "VALUES ('" + aProduct.ProdSKU + "','" + aProduct.ProdName + "','" + aProduct.ProdType +
                      "','" + aProduct.ProdCost + "','" + aProduct.QtyOH + "','" + aProduct.ReOrderPoint + "');";

                command = new OleDbCommand();
                // create insert command
                command = Connection.InsertCommand(sql);
                // execute insert command
                command.ExecuteNonQuery();
                //GetServiceNumber();
                // return submission report
                submissionReport = "Product Create Successfully!";
            }
            catch (OleDbException e)
            {
                //Console.WriteLine("Database Error");
                Console.WriteLine("error " + e);
                submissionReport = "There was a Database Error";
            }
            catch (Exception)
            {
                Console.WriteLine("error");
                submissionReport = "Create New Product Failed";
            }
            return submissionReport;
        }
        //select all products from database and put in arraylist of product objects
        public static ArrayList ProductList()
        {
            prodList = new ArrayList();
            try
            {
                // select all employees
                String sql = "Select * from Prod;";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "Prod");
                // create new employee

                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["Prod"].Rows)
                {
                    aProduct = new Product();
                    aProduct.ProdSKU = dr["prodSKU"].ToString();
                    aProduct.ProdName = dr["prodName"].ToString();
                    aProduct.ProdType= dr["prodType"].ToString();
                    aProduct.ProdCost = Convert.ToDouble(dr["ProdCost"].ToString());
                    aProduct.QtyOH = Convert.ToDouble(dr["qtyOH"].ToString());
                    aProduct.ReOrderPoint = Convert.ToDouble(dr["reOrderPt"].ToString());

                    prodList.Add(aProduct);
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Error");
            }
            // return employee object
            return prodList;
        }
        //update product in database
        public static ArrayList AddProductList()
        {
            prodList = new ArrayList();
            try
            {
                // select all employees
                String sql = "Select * from Prod Where qtyOH > 0;";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "Prod");
                // create new employee

                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["Prod"].Rows)
                {
                    aProduct = new Product();
                    aProduct.ProdSKU = dr["prodSKU"].ToString();
                    aProduct.ProdName = dr["prodName"].ToString();
                    aProduct.ProdType = dr["prodType"].ToString();
                    aProduct.ProdCost = Convert.ToDouble(dr["ProdCost"].ToString());
                    aProduct.QtyOH = Convert.ToDouble(dr["qtyOH"].ToString());
                    aProduct.ReOrderPoint = Convert.ToDouble(dr["reOrderPt"].ToString());

                    prodList.Add(aProduct);
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Error");
            }
            // return employee object
            return prodList;
        }
        //update product in database
        public static string UpdateProduct(Product aProduct)
        {
            submissionReport = "";
            try
            {
                command = new OleDbCommand();
                string updateSQL = "UPDATE Prod SET prodName = '" + aProduct.ProdName +
                    "', prodType = '" + aProduct.ProdType + "', ProdCost = " + aProduct.ProdCost +
                    ", qtyOH = " + aProduct.QtyOH + ", reOrderPt = " + aProduct.ReOrderPoint +
                    " WHERE prodSKU = '" + aProduct.ProdSKU + "';";
                command = Connection.UpdateCommand(updateSQL);
                command.ExecuteNonQuery();
                submissionReport = "Product updated.";
            }
            catch (OleDbException e)
            {
                //Console.WriteLine("Database Error");
                Console.WriteLine("error " + e);
                submissionReport = "There was a Database Error";
            }
            catch (Exception )
            {
                Console.WriteLine("error");
                submissionReport = "Update Product Failed";
            }
            return submissionReport;

        }
        //update quantity on hand when  purchase is submitted
        public static void UpdateQuantity(PurchaseItemLine aItem)
        {

            try
            {
                // select all employees
                String sql = "Select * from Prod WHERE prodSKU = '" + aItem.ItemID + "';";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "Prod");
                // create new employee
                double qty = 0;
                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["Prod"].Rows)
                {
                     qty = Convert.ToDouble(dr["qtyOH"].ToString());
                }
                qty = qty - aItem.Qty;
                command = new OleDbCommand();
                string updateSQL = "UPDATE Prod SET  qtyOH = " + qty + " WHERE prodSKU = '" + aItem.ItemID + "';";
                command = Connection.UpdateCommand(updateSQL);
                command.ExecuteNonQuery();
            }
            catch (OleDbException e)
            {
                //Console.WriteLine("Database Error");
                MessageBox.Show("error /n/n" + e);
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }

        }
        //select all products that have a qoh less than or equal to the reorder amount
        public static ArrayList ProductReOrderList()
        {
            prodList = new ArrayList();
            try
            {
                // select all employees
                String sql = "Select * from Prod WHERE QtyOH <= ReOrderPt;";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "Prod");
                // create new employee

                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["Prod"].Rows)
                {
                    aProduct = new Product();
                    aProduct.ProdSKU = dr["prodSKU"].ToString();
                    aProduct.ProdName = dr["prodName"].ToString();
                    aProduct.ProdType = dr["prodType"].ToString();
                    aProduct.ProdCost = Convert.ToDouble(dr["ProdCost"].ToString());
                    aProduct.QtyOH = Convert.ToDouble(dr["qtyOH"].ToString());
                    aProduct.ReOrderPoint = Convert.ToDouble(dr["reOrderPt"].ToString());

                    prodList.Add(aProduct);
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Error");
            }
            // return employee object
            return prodList;
        }

    }
}
