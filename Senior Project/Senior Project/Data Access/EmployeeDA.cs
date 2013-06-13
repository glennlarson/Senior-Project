/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Employee Data Access*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace Senior_Project
{
    class EmployeeDA
    {
        // create vaiables
        private static DataSet ds;
        private static OleDbDataAdapter dbAdapter;
        private static Employee aEmployee;
        private static OleDbCommand command;
        private static int empId;
        private static string submissionReport;
        // get new employee number
        public static int GetNewEmpNumber()
        {
            try
            {
                // create sql statement to select max id number in table
                String sql = "SELECT MAX(EmpID) as EmployeeID FROM Employee;";
                // create new employee object
                // call setup connection method from connection class
                dbAdapter = Connection.SetupConnection(sql);
                // create new dataset
                ds = new DataSet();
                // fill data set using db adapter
                dbAdapter.Fill(ds, "Employee");
                // get number out of row
                foreach (DataRow dr in ds.Tables["Employee"].Rows)
                {
                    empId = Convert.ToInt32(dr["EmployeeID"].ToString());
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show("error\n\n" + e);
            }
            return empId;
        }
        public static Employee FindEmployee(int employeeId)
        {
            try
            {
                // select employee info from cust table wher id mateches
                String sql = "Select * from Employee Where EmpID = " + employeeId + ";";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "Employee");
                // create new employee
                aEmployee = new Employee();
                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["Employee"].Rows)
                {
                    aEmployee.EmployeeID = Convert.ToInt32(dr["EmpID"].ToString());
                    aEmployee.EmployeeFirstName = dr["EmpFirstName"].ToString();
                    aEmployee.EmployeeLastName = dr["EmpLastName"].ToString();
                    aEmployee.EmployeeAddress1 = dr["EmpAddress1"].ToString();
                    aEmployee.EmployeeAddress2 = dr["EmpAddress2"].ToString();
                    aEmployee.EmployeeCity = dr["EmpCity"].ToString();
                    aEmployee.EmployeeState = dr["EmpState"].ToString();
                    aEmployee.EmployeeZip = Convert.ToInt32(dr["EmpZip"].ToString());
                    aEmployee.EmployeePhone = dr["EmpPhone"].ToString();
                    aEmployee.EmployeePayRate = Convert.ToDouble(dr["EmpPayRate"].ToString());
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("employee not found");
            }
            // return employee object
            return aEmployee;
        }
        // creat eemployee method
        public static string CreateEmployee(Employee aEmployee)
        {
            string submissionReport = "";
            try
            {
                // insert statemet
                string sql = "INSERT INTO Employee (EmpFirstName, EmpLastName, EmpAddress1, EmpAddress2, EmpCity, EmpState, EmpZip, EmpPhone, EmpPayRate)" +
                  "VALUES ( '" + aEmployee.EmployeeFirstName + "' , '" + aEmployee.EmployeeLastName + "' , '" + aEmployee.EmployeeAddress1 + "' , '" + aEmployee.EmployeeAddress2 + "' , '" +
                   aEmployee.EmployeeCity + "' , '" + aEmployee.EmployeeState + "' ,'" + aEmployee.EmployeeZip + "' , '" +
                   aEmployee.EmployeeAreaCode + aEmployee.EmployeePhone + "' , '" + aEmployee.EmployeePayRate + "')";

                command = new OleDbCommand();
                // create insert command
                command = Connection.InsertCommand(sql);
                // execute insert command
                command.ExecuteNonQuery();
                GetNewEmpNumber();
                sql = "INSERT INTO LoginCredintials(EmpID, LoginKey)" + "VALUES('" + empId + "','pass')";
                command = new OleDbCommand();
                command = Connection.InsertCommand(sql);
                command.ExecuteNonQuery();
                // return submission report
                submissionReport = "Employee Created Successfully and " + aEmployee.EmployeeFirstName + " " +
                    aEmployee.EmployeeLastName + " Employee number is " + Convert.ToString(empId);
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
                submissionReport = "Create New Employee Failed";
            }
            return submissionReport;
        }
        // select all employees and return an arraylist of employee objects
        public static ArrayList AllEmployees()
        {
            aEmployee = new Employee();
            ArrayList empList = new ArrayList();
            try
            {
                // select all employees
                String sql = "Select * from Employee;";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "Employee");
                // create new employee
                
                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["Employee"].Rows)
                {
                    aEmployee = new Employee();
                    aEmployee.EmployeeID = Convert.ToInt32(dr["EmpID"].ToString());
                    aEmployee.EmployeeFirstName = dr["EmpFirstName"].ToString();
                    aEmployee.EmployeeLastName = dr["EmpLastName"].ToString();
                    aEmployee.EmployeeAddress1 = dr["EmpAddress1"].ToString();
                    aEmployee.EmployeeAddress2 = dr["EmpAddress2"].ToString();
                    aEmployee.EmployeeCity = dr["EmpCity"].ToString();
                    aEmployee.EmployeeState = dr["EmpState"].ToString();
                    aEmployee.EmployeeZip = Convert.ToInt32(dr["EmpZip"].ToString());
                    aEmployee.EmployeePhone = dr["EmpPhone"].ToString();
                    aEmployee.EmployeePayRate = Convert.ToDouble(dr["EmpPayRate"].ToString());
                    aEmployee.SplitPhone();

                    empList.Add(aEmployee);
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("employee not found");
            }
            // return employee object
            return empList;
        }
        // update employee in database
        public static string UpdateEmployee(Employee aEmployee)
        {
            submissionReport= "";
            try
            {
                command = new OleDbCommand();
                string updateSQL = "UPDATE Employee SET EmpFirstName = '" + aEmployee.EmployeeFirstName +
                    "', EmpLastName = '" + aEmployee.EmployeeLastName + "', EmpAddress1 = '" + aEmployee.EmployeeAddress1 +
                    "', EmpAddress2 = '" + aEmployee.EmployeeAddress2 + "', EmpCity = '" + aEmployee.EmployeeCity +
                    "', EmpState = '" + aEmployee.EmployeeState + "', EmpZip = '" + Convert.ToInt32(aEmployee.EmployeeZip) + 
                    "', EmpPhone = '" + Convert.ToDouble(aEmployee.EmployeeAreaCode + aEmployee.EmployeePhone) + 
                    "', EmpPayRate = '" + Convert.ToDouble(aEmployee.EmployeePayRate) + "' WHERE EmpID = " + aEmployee.EmployeeID + ";";
                command = Connection.UpdateCommand(updateSQL);
                command.ExecuteNonQuery();
                submissionReport = "Employee updated.";
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
                submissionReport = "Update Employee Failed/n/n" + e;
            }
            return submissionReport;

        }
        // delete employee from database
        public static string DeleteEmployee(int empNum)
        {
            try
            {
                command = new OleDbCommand();
                String deleteSQL = "DELETE FROM Employee WHERE EmpID = " + empNum + ";";
                command = Connection.UpdateCommand(deleteSQL);
                command.ExecuteNonQuery();
                submissionReport = "Employee Deleted";
                
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
                submissionReport = "Update Employee Failed/n/n" + e;
            }
            return submissionReport;
        }
        // employee login
        public static Credintials EmployeeLogin(Credintials aCredintial)
        {
            try
            {
                // select employee info from cust table wher id mateches
                String sql = "Select * from LoginCredintials Where EmpID = " + aCredintial.EmpID + ";";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "LoginCredintials");
                // create new employee
                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["LoginCredintials"].Rows)
                {
                    aCredintial.PassCompare = dr["LoginKey"].ToString();
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Employee not found");
            }
            // return employee object
            return aCredintial;
        }
        //update employee password
        public static string UpdatePassword(Credintials aCredintial)
        {
            try
            {
                string updateSQL = "UPDATE LoginCredintials SET LoginKey = '" + aCredintial.NewPassword + "' WHERE EmpID = " + aCredintial.EmpID + ";";
                command = Connection.UpdateCommand(updateSQL);
                command.ExecuteNonQuery();
                submissionReport = "Password updated.";
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
                submissionReport = "Unable to Update Password" + e;
            }
            return submissionReport;
        }
    }
}
