/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Purchase Data Access*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace Senior_Project
{
    class PurchaseDA
    {
        // declarations
        public static string submissionReport;
        private static OleDbDataAdapter dbAdapter;
        private static OleDbCommand command;
        private static DataSet ds;
        private static Employee aEmployee;
        private static Payment aPayment;
        private static Purchase aPurchase;
        //submit purchase to database
        public static Purchase SubmitPurchase(Purchase aPurchase)
        {
            submissionReport = "";
            try
            {
                // insert statemet
                string sql = "INSERT INTO Purchase (CustID, EmpID, SubTotal, Tax, Total)" +
                  "VALUES ('" + aPurchase.ACustomer.CustomerID + "','" + aPurchase.AEmployee.EmployeeID + "','" + aPurchase.SubTotal +
                      "','" + aPurchase.Tax + "','" + aPurchase.Total + "');";

                command = new OleDbCommand();
                // create insert command
                command = Connection.InsertCommand(sql);
                // execute insert command
                command.ExecuteNonQuery();
                //GetServiceNumber();
                // return submission report
                submissionReport = "Purchase Created Successfully!";
            }
            catch (OleDbException e)
            {
                //Console.WriteLine("Database Error");
                Console.WriteLine("error " + e);
                MessageBox.Show("There was a Database Error");
            }
            catch (Exception)
            {
                Console.WriteLine("error");
                submissionReport = "Create New Product Failed";
            }
            aPurchase.PurchaseID = GetPurhcaseNumber();
            return aPurchase;
        }
        //get purchase number of the purchase that was just submitted
        public static int GetPurhcaseNumber()
        {
            int purchaseID = 0;
            try
            {
                // create sql statement to select max id number in table
                String sql = "SELECT MAX(PurchaseID) as PurchaseID FROM Purchase;";
                // create new customer object
                // call setup connection method from connection class
                dbAdapter = Connection.SetupConnection(sql);
                // create new dataset
                ds = new DataSet();
                // fill data set using db adapter
                dbAdapter.Fill(ds, "Purchase");
                // get number out of row
                foreach (DataRow dr in ds.Tables["Purchase"].Rows)
                {
                    purchaseID = Convert.ToInt32(dr["PurchaseID"].ToString());
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show("error\n\n" + e);
            }
            return purchaseID;
        }
        public static ArrayList GetPurchases(Customer aCustomer)
        {
            ArrayList pList = new ArrayList();
            try
            {
                // select customer info from cust table wher id mateches
                String sql = "Select * from Purchase Where CustID = '" + aCustomer.CustomerID + "';";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "Purchase");
                // create new customer
                
                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["Purchase"].Rows)
                {
                    aPurchase = new Purchase();
                    aEmployee = new Employee();
                    aPayment = new Payment();
                    aPurchase.AEmployee = aEmployee;
                    aPurchase.APayment = aPayment;
                    aPurchase.PurchaseID = Convert.ToInt32(dr["PurchaseID"].ToString());
                    aPurchase.SubTotal = Convert.ToDouble(dr["SubTotal"].ToString());
                    aPurchase.Tax= Convert.ToDouble(dr["Tax"].ToString());
                    aPurchase.Total = Convert.ToDouble(dr["Total"].ToString());
                    aPurchase.AEmployee.EmployeeID = Convert.ToInt32(dr["EmpID"].ToString());
                    pList.Add(aPurchase);
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("customer not found");
            }
            // return customer object
            return pList;
        }

    }
}
