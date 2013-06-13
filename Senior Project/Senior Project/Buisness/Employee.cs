/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Employee Class*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Senior_Project
{
    public class Employee
    {
        //employee class
        //Instantiate a employee object
        private static Employee aEmployee;
        // employee constructors
        public Employee()
        {
        }
        public Employee(int employeeID, string employeeFirstName, string employeeLastName, string employeeAddress1, string employeeAddress2,
            string employeeCity, string employeeState, int employeeZip, string employeePhone, double employeePayRate)
        {
            this.employeeID = employeeID;
            this.employeeFirstName = employeeFirstName;
            this.employeeLastName = employeeLastName;
            this.employeeAddress1 = employeeAddress1;
            this.employeeAddress2 = employeeAddress2;
            this.employeeCity = employeeCity;
            this.employeeState = employeeState;
            this.employeeZip = employeeZip;
            this.employeePhone = employeePhone;
            this.employeePayRate = employeePayRate;
        }
        //variable declerations and getter and setters
        int employeeID;
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        string employeeFirstName;
        public string EmployeeFirstName
        {
            get { return employeeFirstName; }
            set { employeeFirstName = value; }
        }
        string employeeLastName;
        public string EmployeeLastName
        {
            get { return employeeLastName; }
            set { employeeLastName = value; }
        }
        string employeeAddress1;
        public string EmployeeAddress1
        {
            get { return employeeAddress1; }
            set { employeeAddress1 = value; }
        }
        string employeeAddress2;
        public string EmployeeAddress2
        {
            get { return employeeAddress2; }
            set { employeeAddress2 = value; }
        }
        string employeeCity;
        public string EmployeeCity
        {
            get { return employeeCity; }
            set { employeeCity = value; }
        }
        string employeeState;
        public string EmployeeState
        {
            get { return employeeState; }
            set { employeeState = value; }
        }
        int employeeZip;
        public int EmployeeZip
        {
            get { return employeeZip; }
            set { employeeZip = value; }
        }
        string employeePhone;
        public string EmployeePhone
        {
            get { return employeePhone; }
            set { employeePhone = value; }
        }  
        string employeeAreaCode;
        public string EmployeeAreaCode
        {
            get { return employeeAreaCode; }
            set { employeeAreaCode = value; }
        }
        double employeePayRate;
        public double EmployeePayRate
        {
            get { return employeePayRate; }
            set { employeePayRate = value; }
        }
  
        // split phone number into area code and number method
        public void SplitPhone()
        {
            try
            {

                employeeAreaCode = employeePhone.Remove(3, 7);
                employeePhone = employeePhone.Remove(0, 3);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("employee not found");
            }
            
        }
        //wrapper method for find employee
        public static Employee FindEmployee(int employeeID)
        {
            try
            {

                aEmployee = EmployeeDA.FindEmployee(employeeID);
                aEmployee.SplitPhone();
                
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("employee not found");
            }
            return aEmployee;
        }
        // wrapper method for get new employee number
        public static int GetNewEmpNumber()
        {
            return GetNewEmpNumber();
        }
        // wrapper method for create new employee
        public static String CreateEmployee(Employee aEmployee)
        {
            return EmployeeDA.CreateEmployee(aEmployee);
        }
        //select all employees wrapper method
        public static ArrayList AllEmployees()
        {
            return EmployeeDA.AllEmployees();
        }
        //update employee wrapper method
        public static String UpdateEmployee(Employee aEmployee)
        {

            return EmployeeDA.UpdateEmployee(aEmployee);
        }
        //delete employee wrapper methid
        public static String DeleteEmployee(int empNum)
        {
            return EmployeeDA.DeleteEmployee(empNum);
        }
    }
}
