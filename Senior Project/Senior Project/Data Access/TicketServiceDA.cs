//Glenn Larson
//CIS591 Senior Project
//Service Ticket DA Form Code

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
    class TicketServiceDA
    {
        //declare variables
        private static DataSet ds;
        private static OleDbDataAdapter dbAdapter;
        private static Service aService;
        private static OleDbCommand command;
        private static string submissionReport;
        private static TicketService aTicket;
        // create service ticket
        public static string CreateTicket(TicketService aTicket)
        {
            int serviceTicketID;
            string submissionReport = "";
            try
            {
                // insert statemet
                string sql = "INSERT INTO ServiceTicket (CustID, BikeID, Descrip, Cost, Status )" +
                  "VALUES ('" + aTicket.ACust.CustomerID + "','" + aTicket.CustBike.CBikeID + "','" +
                  aTicket.ServiceTicketDescrip + "','" + aTicket.Cost + "','queue');";

                command = new OleDbCommand();
                // create insert command
                command = Connection.InsertCommand(sql);
                // execute insert command
                command.ExecuteNonQuery();
                
                serviceTicketID = GetServiceTicketNumber();

                foreach (Service aService in aTicket.SList)
                {
                    sql = "Insert INTO ServiceTicketLine(TicketID, ServiceID)" +
                        "VALUES ('" + serviceTicketID + "','" + aService.ServiceID + "');";
                    command = new OleDbCommand();
                    command = Connection.InsertCommand(sql);
                    command.ExecuteNonQuery();
                }
                string employeeAction = "EnteredBy";
                sql = "INSERT INTO ServiceTicketEmployees (TicketID, EmpId, EmployeeAction)" +
                "VALUES ('" + serviceTicketID + "','" + aTicket.EnteredByEmployee.EmployeeID +
                "', '" + employeeAction + "');";
                command = new OleDbCommand();
                // create insert command
                command = Connection.InsertCommand(sql);
                // execute insert command
                command.ExecuteNonQuery();
                //GetServiceNumber();
                // return submission report
                submissionReport = "Service Ticket Created Successfully. \nTicket ID:" + serviceTicketID;
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
                submissionReport = "Create New Service Ticket Failed";
            }
            return submissionReport;
        }
        // get the number of the last entered service
        private static int GetServiceTicketNumber()
        {
            int serviceTicketID = 0;
            try
            {
                // create sql statement to select max id number in table
                String sql = "SELECT MAX(TicketID) as TicketID FROM ServiceTicket;";
                // create new employee object
                // call setup connection method from connection class
                dbAdapter = Connection.SetupConnection(sql);
                // create new dataset
                ds = new DataSet();
                // fill data set using db adapter
                dbAdapter.Fill(ds, "ServiceTicket");
                // get number out of row
                foreach (DataRow dr in ds.Tables["ServiceTicket"].Rows)
                {
                    serviceTicketID = Convert.ToInt32(dr["TicketID"].ToString());
                }
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Database Error " + e);
            }
            catch (System.Exception e)
            {
                MessageBox.Show("error\n\n" + e);
            }
            return serviceTicketID;
        }
        // return the service ticket queue
        public static ArrayList QueueTickets(string status)
        {
            Customer aCustomer;
            CBike aBike;
            ArrayList queueTicketList = new ArrayList();
            ArrayList sList = new ArrayList();
            try
            {
                // select all employees
                String sql = "Select * from ServiceTicket Where Status ='" + status + "';";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "ServiceTicket");
                // create new employee

                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["ServiceTicket"].Rows)
                {
                    aTicket = new TicketService();
                    aCustomer = new Customer();
                    aBike = new CBike();
                    aTicket.ServiceTicketID = Convert.ToInt16(dr["TicketID"].ToString());
                    aCustomer.CustomerID = Convert.ToInt32(dr["CustID"].ToString());
                    aTicket.ACust = aCustomer;
                    aBike.CBikeID = Convert.ToInt32(dr["BikeID"].ToString());
                    aBike.CBikeCustID = Convert.ToInt32(dr["CustID"].ToString());
                    aTicket.CustBike = aBike;
                    aTicket.ServiceTicketDescrip = dr["Descrip"].ToString();
                    aTicket.Cost = Convert.ToDouble(dr["Cost"].ToString());

                    queueTicketList.Add(aTicket);
                }
                ArrayList queueList = new ArrayList();
                foreach (TicketService aTicket in queueTicketList)
                {

                    aCustomer = new Customer();
                    aBike = new CBike();
                    aCustomer = aTicket.ACust;
                    aBike = aTicket.CustBike;
                    aCustomer = Customer.SelectACust(aCustomer.CustomerID);
                    aBike = CBike.CustBike(aBike.CBikeCustID, aBike.CBikeID);
                    int employeeID;
                    string employeeAction;
                    aTicket.ACust = aCustomer;
                    aTicket.CustBike = aBike;

                    // select all employees
                    sql = "Select * from ServiceTicketLine Where TicketID ='" + aTicket.ServiceTicketID + "';";
                    // create connection
                    dbAdapter = Connection.SetupConnection(sql);
                    //create dataset
                    ds = new DataSet();
                    // fill dataset
                    dbAdapter.Fill(ds, "ServiceTicketLine");
                    // create new arraylist
                    sList = new ArrayList();
                    // fill cusotmer object
                    foreach (DataRow dr in ds.Tables["ServiceTicketLine"].Rows)
                    {
                        aService = new Service();
                        aService.ServiceID = Convert.ToInt32(dr["ServiceID"].ToString());

                        sList.Add(aService);
                    }
                    aTicket.SList = Service.GetServices(sList);

                    // select all employees
                    sql = "Select * from ServiceTicketEmployees Where TicketID =" + aTicket.ServiceTicketID + ";";
                    // create connection
                    dbAdapter = Connection.SetupConnection(sql);
                    //create dataset
                    ds = new DataSet();
                    // fill dataset
                    dbAdapter.Fill(ds, "ServiceTicketEmployees");
                    // fill cusotmer object
                    foreach (DataRow dr in ds.Tables["ServiceTicketEmployees"].Rows)
                    {
                        employeeID = Convert.ToInt32(dr["EmpID"].ToString());
                        employeeAction = dr["EmployeeAction"].ToString();
                        if(employeeAction =="EnteredBy")
                        {
                            aTicket.EnteredByEmployee = EmployeeDA.FindEmployee(employeeID);
                        }
                        else if (employeeAction == "ServicedBy")
                        {
                            aTicket.ServicedByEmp = EmployeeDA.FindEmployee(employeeID);
                        }
                    }
                    
                    queueList.Add(aTicket);
                }


            }
            catch (OleDbException e)
            {
                Console.WriteLine("DatabaseError " + e);
                MessageBox.Show("There was a database error");
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Error");
            }
            // return employee object
            return queueTicketList;
        }
        // update status of a service
        public static string UpdateStatus(TicketService aTicket, string status)
        {
            submissionReport= "";
            string updateSQL;
            string sql;
            try
            {
                command = new OleDbCommand();
                if (status == "Servicing")
                {
                    updateSQL = "UPDATE ServiceTicket SET Status = '" + status +
                    "' WHERE ticketID = " + aTicket.ServiceTicketID + ";";
                    command = Connection.UpdateCommand(updateSQL);
                    command.ExecuteNonQuery();
                    sql = "INSERT INTO ServiceTicketEmployees (TicketID, EmpId, EmployeeAction)" +
                      "VALUES (" + aTicket.ServiceTicketID + "," + aTicket.ServicedByEmp.EmployeeID +
                      ",'ServicedBy');";
                    command = Connection.UpdateCommand(sql);
                    command.ExecuteNonQuery();
                    submissionReport = "Service Ticket Status Changed.";
                }
                else
                {
                    updateSQL = "UPDATE ServiceTicket SET Status = '" + status +
                    "' WHERE ticketID = " + aTicket.ServiceTicketID + ";";
                    command = Connection.UpdateCommand(updateSQL);
                    command.ExecuteNonQuery();
                    submissionReport = "Service Ticket Status Changed.";
                }
                
                
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
                submissionReport = "Service Ticket Status Change";
            }
            return submissionReport;

        }
        // set status of service to paid
        public static void ServiceTicketPaid(PurchaseItemLine aItem)
        {
            submissionReport = "";
            string updateSQL;
            try
            {
                command = new OleDbCommand();

                updateSQL = "UPDATE ServiceTicket SET Status = 'Paid' WHERE ticketID = " + aItem.ItemID + ";";

                command = Connection.UpdateCommand(updateSQL);
                command.ExecuteNonQuery();
                submissionReport = "Employee updated.";
            }
            catch (OleDbException e)
            {
                //Console.WriteLine("Database Error");
                Console.WriteLine("error /n/n" + e);
                MessageBox.Show("There was a database error");
            }
            catch (Exception e)
            {
                Console.WriteLine("error");
            }
        }
    }
}

