/*Glenn Larson
 * Cis591
 * Cycle Manager
 * New Bike Data Access*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Senior_Project
{
    class NewBikeDA
    {
        //declarations
        private static NewBike nBike;
        private static DataSet ds;
        private static OleDbDataAdapter dbAdapter;
        private static OleDbCommand command;
        private static ArrayList newBikeList;
        private static string submissionReport;
        //add new bike method
        public static string AddNBike(NewBike nBike)
        {
            submissionReport = "";
            try
            {
                // insert statemet
                string sql = "INSERT INTO nBIke (nBikeBrand, nBikeModel, nBikeType, nBikeCost, qtyOH, reOrder)" +
                  "VALUES ('" + nBike.NBikeBrand + "','" + nBike.NBikeModel +
                      "','" + nBike.NBikeType + "','" + nBike.NBikeCost + "','" + nBike.QtyOH +
                      "','" + nBike.ReOrderPoint + "');";

                command = new OleDbCommand();
                // create insert command
                command = Connection.InsertCommand(sql);
                // execute insert command
                command.ExecuteNonQuery();
                //GetServiceNumber();
                // return submission report
                submissionReport = "Bike Created Successfully!";
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
                submissionReport = "Create New Bike Failed";
            }
            return submissionReport;
        }
        //retrieves all bikes from database and creates an arraylist of bike objects
        public static ArrayList nBikeList()
        {
            newBikeList = new ArrayList();
            try
            {
                // select all employees
                String sql = "Select * from nBike;";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "nBike");
                // create new employee

                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["nBike"].Rows)
                {
                    nBike = new NewBike();
                    nBike.NBikeID = Convert.ToInt32(dr["nBikeID"].ToString());
                    nBike.NBikeBrand = dr["nBikeBrand"].ToString();
                    nBike.NBikeModel = dr["nBikeModel"].ToString();
                    nBike.NBikeType = dr["nBikeType"].ToString();
                    nBike.NBikeCost = Convert.ToDouble(dr["nBikeCost"].ToString());
                    nBike.QtyOH = Convert.ToDouble(dr["qtyOH"].ToString());
                    nBike.ReOrderPoint = Convert.ToDouble(dr["reOrder"].ToString());

                    newBikeList.Add(nBike);
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Error");
            }
            // return employee object
            return newBikeList;
        }
        //update bike method updates bike entry in database
        public static string UpdateBike(NewBike nBike)
        {
            submissionReport = "";
            try
            {
                command = new OleDbCommand();
                string updateSQL = "UPDATE nBike SET nBikeBrand = '" + nBike.NBikeBrand +
                    "', nBikeModel = '" + nBike.NBikeModel + "', nBikeType = '" + nBike.NBikeType +
                    "', nBikeCost = '" + nBike.NBikeCost + "', qtyOH = '" + nBike.QtyOH + "', reOrder = '" + nBike.ReOrderPoint +
                    "' WHERE nBIkeID = " + nBike.NBikeID + ";";
                command = Connection.UpdateCommand(updateSQL);
                command.ExecuteNonQuery();
                submissionReport = "Bike updated.";
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
                submissionReport = "Update Bike Failed";
            }
            return submissionReport;

        }
        //update qty when purchase is entered
        public static void UpdateQty(PurchaseItemLine aItem)
        {
            try
            {

                String sql = "Select * from nBike WHERE nBikeID = " + aItem.ItemID + ";";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "nBike");
                // create new employee
                double qty = 0;
                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["nBike"].Rows)
                {
                    qty = Convert.ToDouble(dr["qtyOH"].ToString());
                    
                }
                qty = qty - aItem.Qty;
                command = new OleDbCommand();
                string updateSQL = "UPDATE nBike SET qtyOH = '" + qty + 
                    "' WHERE nBIkeID = " + nBike.NBikeID + ";";
                command = Connection.UpdateCommand(updateSQL);
                command.ExecuteNonQuery();
                
            }
            catch (OleDbException e)
            {
                Console.WriteLine("error " + e);
                MessageBox.Show("There was a Database Error");
                
            }
            catch (Exception)
            {
                Console.WriteLine("error");
                
            }

        }
        //selects all bikes that have a qoh that is less than or equal to the reorder amount
        public static ArrayList nBikeReOrderList()
        {
            newBikeList = new ArrayList();
            try
            {
                // select all employees
                String sql = "Select * from nBike WHERE QtyOH <= ReOrder;";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "nBike");
                // create new employee

                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["nBike"].Rows)
                {
                    nBike = new NewBike();
                    nBike.NBikeID = Convert.ToInt32(dr["nBikeID"].ToString());
                    nBike.NBikeBrand = dr["nBikeBrand"].ToString();
                    nBike.NBikeModel = dr["nBikeModel"].ToString();
                    nBike.NBikeType = dr["nBikeType"].ToString();
                    nBike.NBikeCost = Convert.ToDouble(dr["nBikeCost"].ToString());
                    nBike.QtyOH = Convert.ToDouble(dr["qtyOH"].ToString());
                    nBike.ReOrderPoint = Convert.ToDouble(dr["reOrder"].ToString());

                    newBikeList.Add(nBike);
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Error");
            }
            // return employee object
            return newBikeList;
        }
        public static ArrayList AddnBikeList()
        {
            newBikeList = new ArrayList();
            try
            {
                // select all employees
                String sql = "Select * from nBike Where qtyOH > 0;";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "nBike");
                // create new employee

                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["nBike"].Rows)
                {
                    nBike = new NewBike();
                    nBike.NBikeID = Convert.ToInt32(dr["nBikeID"].ToString());
                    nBike.NBikeBrand = dr["nBikeBrand"].ToString();
                    nBike.NBikeModel = dr["nBikeModel"].ToString();
                    nBike.NBikeType = dr["nBikeType"].ToString();
                    nBike.NBikeCost = Convert.ToDouble(dr["nBikeCost"].ToString());
                    nBike.QtyOH = Convert.ToDouble(dr["qtyOH"].ToString());
                    nBike.ReOrderPoint = Convert.ToDouble(dr["reOrder"].ToString());

                    newBikeList.Add(nBike);
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Error");
            }
            // return employee object
            return newBikeList;
        }


    }
}
