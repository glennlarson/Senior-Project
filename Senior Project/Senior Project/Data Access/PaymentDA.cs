/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Payment Data Access*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Senior_Project
{
    class PaymentDA
    {

        // declarations
        public static string submissionReport;
        private static OleDbDataAdapter dbAdapter;
        private static OleDbCommand command;
        private static DataSet ds;
        //submit purchase to database
        public static void SubmitPayment(Payment aPayment, Int32 purchaseID)
        {
            submissionReport = "";
            try
            {
                // insert statemet
                if (aPayment.PaymentType == "Credit/Debit")
                {
                    string sql = "INSERT INTO Payment(PurchaseID, PaymentType, Amount, CardType, CardNumber)" +
                      "VALUES (" + purchaseID + ",'" + aPayment.PaymentType + "'," + aPayment.PayAmount +
                          ",'" + aPayment.CardType + "','" + aPayment.CardNum + "');";
                    command = new OleDbCommand();
                    // create insert command
                    command = Connection.InsertCommand(sql);
                    // execute insert command
                    command.ExecuteNonQuery();
                    //GetServiceNumber();
                    // return submission report
                }
                else if(aPayment.PaymentType == "Cash")
                {
                    string sql = "INSERT INTO Payment(PurchaseID, PaymentType, Amount, CardType, CardNumber)" +
                      "VALUES (" + purchaseID + ",'" + aPayment.PaymentType + "'," + aPayment.PayAmount +
                          ",'" + null + "','" + null + "');";
                    command = new OleDbCommand();
                    // create insert command
                    command = Connection.InsertCommand(sql);
                    // execute insert command
                    command.ExecuteNonQuery();
                    //GetServiceNumber();
                    // return submission report
                }
            
            }
            
            catch (OleDbException e)
            {
                //Console.WriteLine("Database Error");
                Console.WriteLine("error " + e);
                submissionReport = "Payment Failed";
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }
        }
        //Get Payment
        public static Payment GetPayment(int purchaseID)
        {
            Payment aPayment = new Payment();
            try
            {
                // select customer info from cust table wher id mateches
                String sql = "Select * from Payment Where PurchaseID = " + purchaseID + ";";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "Payment");
                // create new customer
                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["Payment"].Rows)
                {
                    aPayment.PaymentType = dr["PaymentType"].ToString();
                    aPayment.PayAmount = Convert.ToDouble(dr["Amount"].ToString());
                    aPayment.CardType= dr["CardType"].ToString();
                    aPayment.CardNum = dr["CardNumber"].ToString();
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Payment not found");
            }
            // return customer object
            return aPayment;
        }

    }
}
