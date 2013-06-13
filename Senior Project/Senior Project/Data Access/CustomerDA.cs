//Glenn Larson
//CIS591 Senior Project
//Customer Data Access
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Senior_Project
{

    class CustomerDA
    {
        //declarations
        private static DataSet ds;
        private static OleDbDataAdapter dbAdapter;
        private static Customer aCustomer;
        private static OleDbCommand command;
        // create customer in database
        public static string CreateCustomer(Customer aCustomer)
        {
            string submissionReport = "";
            try
            {
                // insert statemet
                string sql = "INSERT INTO Customer (CustFirstName, CustLastName, CustAddress1, CustAddress2, CustCity, CustState, CustZip, CustPhone)" +
                  "VALUES ( '" + aCustomer.CustomerFirstName + "' , '" + aCustomer.CustomerLastName + "' , '" + aCustomer.CustomerAddress1 + "' , '" + aCustomer.CustomerAddress2 + "' , '" +
                   aCustomer.CustomerCity + "' , '" + aCustomer.CustomerState + "' ,'" + aCustomer.CustomerZip + "' , '" +
                   aCustomer.CustomerAreaCode + aCustomer.CustomerPhone + "')";

                command = new OleDbCommand();
                // create insert command
                command = Connection.InsertCommand(sql);
                // execute insert command
                command.ExecuteNonQuery();
                // return submission report
                submissionReport = "Customer Created Successfully";
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
                submissionReport = "Create New Customer Failed";
            }
            return submissionReport;
        }
        //select number from previously entered customer
        public static int GetNewCustNumber()
        {
            int custID = 0;
            try
            {
                // create sql statement to select max id number in table
                String sql = "SELECT MAX(CustID) as CustomerID FROM Customer;";
                // create new customer object
                // call setup connection method from connection class
                dbAdapter = Connection.SetupConnection(sql);
                // create new dataset
                ds = new DataSet();
                // fill data set using db adapter
                dbAdapter.Fill(ds, "Customer");
                // get number out of row
                foreach (DataRow dr in ds.Tables["Customer"].Rows)
                {
                    custID = Convert.ToInt32(dr["CustomerID"].ToString());
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show("error\n\n" + e);
            }
            return custID;
        }
        // find customer by first and last name
        public static Customer findCustomer(string custFirstName, string custLastName)
        {
            try
            {
                // select customer info from cust table wher id mateches
                String sql = "Select * from Customer Where CustFirstName = '"+ custFirstName  +"' AND CustLastName = '" + custLastName+  "';";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "Customer");
                // create new customer
                aCustomer = new Customer();
                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["Customer"].Rows)
                {
                    aCustomer.CustomerID = Convert.ToInt32(dr["CustID"].ToString());
                    aCustomer.CustomerFirstName = dr["CustFirstName"].ToString();
                    aCustomer.CustomerLastName = dr["CustLastName"].ToString();
                    aCustomer.CustomerAddress1 = dr["CustAddress1"].ToString();
                    aCustomer.CustomerAddress2 = dr["CustAddress2"].ToString();
                    aCustomer.CustomerCity = dr["CustCity"].ToString();
                    aCustomer.CustomerState = dr["CustState"].ToString();
                    aCustomer.CustomerZip = Convert.ToInt32(dr["CustZip"].ToString());
                    aCustomer.CustomerPhone = dr["CustPhone"].ToString();
                    aCustomer.SplitPhone();
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("customer not found");
            }
            // return customer object
            return aCustomer;
        }
        //select a customer from the customer id
        public static Customer selectACust(int custID)
        {
            try
            {
                // select customer info from cust table wher id mateches
                String sql = "Select * from Customer Where CustID = " + custID + ";";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "Customer");
                // create new customer
                aCustomer = new Customer();
                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["Customer"].Rows)
                {
                    aCustomer.CustomerID = Convert.ToInt32(dr["CustID"].ToString());
                    aCustomer.CustomerFirstName = dr["CustFirstName"].ToString();
                    aCustomer.CustomerLastName = dr["CustLastName"].ToString();
                    aCustomer.CustomerAddress1 = dr["CustAddress1"].ToString();
                    aCustomer.CustomerAddress2 = dr["CustAddress2"].ToString();
                    aCustomer.CustomerCity = dr["CustCity"].ToString();
                    aCustomer.CustomerState = dr["CustState"].ToString();
                    aCustomer.CustomerZip = Convert.ToInt32(dr["CustZip"].ToString());
                    aCustomer.CustomerPhone = dr["CustPhone"].ToString();
                    aCustomer.SplitPhone();
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("customer not found");
            }
            // return customer object
            return aCustomer;
        }
    }
}
