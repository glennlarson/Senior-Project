//Glenn Larson
//CIS591 Senior Project
//ServiceDA Form Code

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
    class ServiceDA
    {
        //declarations
        private static DataSet ds;
        private static OleDbDataAdapter dbAdapter;
        private static Service aService;
        private static OleDbCommand command;
        private static string submissionReport;
        private static ArrayList sList;
        private static ArrayList serviceList;
        //add service to database
        public static string addService(Service aService)
        {
            string submissionReport = "";
            try
            {
                // insert statemet
                string sql = "INSERT INTO Service (ServiceName, ServiceType, ServiceDescrip, ServiceCost )" +
                  "VALUES ('" + aService.ServiceName + "','" + aService.ServiceType + "','" + aService.ServiceDescrip +
                      "','" + aService.ServiceCost + "');";

                command = new OleDbCommand();
                // create insert command
                command = Connection.InsertCommand(sql);
                // execute insert command
                command.ExecuteNonQuery();
                //GetServiceNumber();
                // return submission report
                submissionReport = "Service Created Successfully!";
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
                submissionReport = "Create New Service Failed";
            }
            return submissionReport;
        }
        //select all services and then create an arraylist of service objects
        public static ArrayList allServices()
        {
            sList = new ArrayList();   
            try
            {
                // select all employees
                String sql = "Select * from Service;";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "Service");
                // create new employee

                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["Service"].Rows)
                {
                    aService = new Service();
                    aService.ServiceID = Convert.ToInt32(dr["ServiceID"].ToString());
                    aService.ServiceName = dr["ServiceName"].ToString();
                    aService.ServiceType = dr["Servicetype"].ToString();
                    aService.ServiceDescrip = dr["ServiceDescrip"].ToString();
                    aService.ServiceCost = Convert.ToDouble(dr["ServiceCost"].ToString());

                    sList.Add(aService);
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Error");
            }
            // return employee object
            return sList;
        }
        // update service in database
        public static string UpdateService(Service aService)
        {
            submissionReport = "";
            try
            {
                command = new OleDbCommand();
                string updateSQL = "UPDATE Service SET ServiceName = '" + aService.ServiceName +
                    "', ServiceType = '" + aService.ServiceType + "', ServiceDescrip = '" + aService.ServiceDescrip +
                    "', ServiceCost = '" + aService.ServiceCost + "' WHERE ServiceID = " + aService.ServiceID + ";";
                command = Connection.UpdateCommand(updateSQL);
                command.ExecuteNonQuery();
                submissionReport = "Service updated.";
            }
            catch (OleDbException e)
            {
                //Console.WriteLine("Database Error");
                Console.WriteLine("error " + e);
                submissionReport = "There was a Database Error";
            }
            catch (Exception e)
            {
                Console.WriteLine("error");
                submissionReport = "Update Service Failed/n/n" + e;
            }
            return submissionReport;

        }
        // get services that are part of a service ticket and put them in an arraylist
        public static ArrayList GetServices(ArrayList sList)
        {
            serviceList = new ArrayList();   
            try
            {
                foreach(Service aService in sList)
                {
                    // select all employees
                    String sql = "Select * from Service where ServiceID = "+aService.ServiceID +";";
                    // create connection
                    dbAdapter = Connection.SetupConnection(sql);
                    //create dataset
                    ds = new DataSet();
                    // fill dataset
                    dbAdapter.Fill(ds, "Service");
                    // create new employee

                    // fill cusotmer object
                    foreach (DataRow dr in ds.Tables["Service"].Rows)
                    {
                    aService.ServiceName = dr["ServiceName"].ToString();
                    aService.ServiceType = dr["Servicetype"].ToString();
                    aService.ServiceDescrip = dr["ServiceDescrip"].ToString();
                    aService.ServiceCost = Convert.ToDouble(dr["ServiceCost"].ToString());

                    serviceList.Add(aService);
                    }

                }
                
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Error");
            }
            // return employee object
            return serviceList;
        }
        //delete service from database
        public static string DeleteService(int sNum)
        {
            try
            {
                command = new OleDbCommand();
                String deleteSQL = "DELETE FROM Service WHERE ServiceID = " + sNum + ";";
                command = Connection.UpdateCommand(deleteSQL);
                command.ExecuteNonQuery();
                submissionReport = "Service Deleted";

            }
            catch (OleDbException e)
            {
                //Console.WriteLine("Database Error");
                Console.WriteLine("error " + e);
                submissionReport = "There was a Database Error";
            }
            catch (Exception e)
            {
                Console.WriteLine("error");
                submissionReport = "Delete Service Failed" + e;
            }
            return submissionReport;
        }

    }
}
