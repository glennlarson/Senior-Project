//Glenn Larson
//CIS591 Senior Project
//Customer Bike DA 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Windows.Forms;

namespace Senior_Project
{
    class CBikeDA
    {
        //declarations
        private static CBike cBike;
        private static DataSet ds;
        private static OleDbDataAdapter dbAdapter;
        private static OleDbCommand command;
        private static ArrayList custBikeList;
        private static string submissionReport;
        //add bike method
        //this method will contact the database and submit entered data
        public static string addCBike(CBike cBike)
        {
            submissionReport = "";
            try
            {
                // insert statemet
                string sql = "INSERT INTO CustomerBike (cBikeBrand, cBikeModel, cBikeSerial, CustID)" +
                  "VALUES ('" + cBike.CBikeBrand+ "','" + cBike.CBikeModel + "','" + cBike.CBikeSerial +
                      "','" + cBike.CBikeCustID + "');";

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
        // this will get a list of customer bikes
        public static ArrayList CustBikes(int custID)
        {
            custBikeList = new ArrayList();
            try
            {
                // select all employees
                String sql = "Select * from CustomerBike where CustID= '" + custID +"';";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "CustomerBike");
                // create new employee

                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["CustomerBike"].Rows)
                {
                    cBike = new CBike();
                    cBike.CBikeID = Convert.ToInt32(dr["cBikeID"].ToString());
                    cBike.CBikeBrand = dr["cBikeBrand"].ToString();
                    cBike.CBikeModel= dr["cBikeModel"].ToString();
                    cBike.CBikeSerial = dr["cBikeSerial"].ToString();
                    cBike.CBikeCustID = Convert.ToInt32(dr["CustID"].ToString());

                    custBikeList.Add(cBike);
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Error");
            }
            // return employee object
            return custBikeList;
        }
        //this will select a specific customer bike that is part of a service ticket
        public static CBike CustBike(int custID, int bikeID)
        {
            cBike = new CBike();
            try
            {
                // select all employees
                String sql = "Select * from CustomerBike Where cBikeID=" + bikeID + ";";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "CustomerBike");
                // create new employee

                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["CustomerBike"].Rows)
                {
                    
                    cBike.CBikeID = Convert.ToInt32(dr["cBikeID"].ToString());
                    cBike.CBikeBrand = dr["cBikeBrand"].ToString();
                    cBike.CBikeModel = dr["cBikeModel"].ToString();
                    cBike.CBikeSerial = dr["cBikeSerial"].ToString();
                    cBike.CBikeCustID = Convert.ToInt32(dr["CustID"].ToString());

                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Error");
            }
            // return employee object
            return cBike;
        }


    }
}
