//Glenn Larson
//CIS591 Senior Project
//Customer Class Codeusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace Senior_Project
{
    public class Customer
    {
        //constructors
        public Customer()
        {

        }
        public Customer(int customerID, string customerFirstName, string customerLastName, string customerAddress1, string customerAddress2,
            string customerCity, string customerState, int customerZip, string customerPhone)
        {
            this.customerID = customerID;
            this.customerFirstName = customerFirstName;
            this.customerLastName = customerLastName;
            this.customerAddress1 = customerAddress1;
            this.customerAddress2 = customerAddress2;
            this.customerCity = customerCity;
            this.customerState = customerState;
            this.customerZip = customerZip;
            this.customerPhone = customerPhone;
        }
        //variable declerations and getter and setters
        int customerID;
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        string customerFirstName;
        public string CustomerFirstName
        {
            get { return customerFirstName; }
            set { customerFirstName = value; }
        }
        string customerLastName;
        public string CustomerLastName
        {
            get { return customerLastName; }
            set { customerLastName = value; }
        }
        string customerAddress1;
        public string CustomerAddress1
        {
            get { return customerAddress1; }
            set { customerAddress1 = value; }
        }
        string customerAddress2;
        public string CustomerAddress2
        {
            get { return customerAddress2; }
            set { customerAddress2 = value; }
        }
        string customerCity;
        public string CustomerCity
        {
            get { return customerCity; }
            set { customerCity = value; }
        }
        string customerState;
        public string CustomerState
        {
            get { return customerState; }
            set { customerState = value; }
        }
        int customerZip;
        public int CustomerZip
        {
            get { return customerZip; }
            set { customerZip = value; }
        }
        string customerPhone;
        public string CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }
        string customerAreaCode;
        public string CustomerAreaCode
        {
            get { return customerAreaCode; }
            set { customerAreaCode = value; }
        }
        public void SplitPhone()
        {
            try
            {
                if(customerPhone.Count() == 7)
                {

                }
                else
                {
                        customerAreaCode = customerPhone.Remove(3, 7);
                        customerPhone = customerPhone.Remove(0, 3);
                }
            }
            catch (ArgumentNullException er)
            {
                Console.WriteLine("" + er);

            }
            catch (NullReferenceException er)
            {
                Console.WriteLine(""  +er);
            }
            catch (ArgumentOutOfRangeException er)
            {
                Console.WriteLine("" + er);
            }
        }

        //wrapper methods
        //create customer wrapper method
        public static string createCustomer(Customer aCustomer)
        {

            return CustomerDA.CreateCustomer(aCustomer);
        }
        //get customernumber wrapper method
        public static int getCustomerNumber()
        {
            return CustomerDA.GetNewCustNumber();
        }
        //find customer wrapper method
        public static Customer findCustomer(string custFirstName, string custLastName)
        {
           Customer aCustomer = CustomerDA.findCustomer(custFirstName, custLastName);
           if (aCustomer != null)
           {
               aCustomer.SplitPhone();
           }
           return aCustomer;
        }
        //select a customer wrapper method
        public static Customer SelectACust(int custID)
        {
            return CustomerDA.selectACust(custID);
        }
    }
}
