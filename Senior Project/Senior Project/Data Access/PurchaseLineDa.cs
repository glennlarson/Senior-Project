/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Purchse line Data Access*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace Senior_Project
{
    class PurchaseLineDa
    {
        //declarations
        private static OleDbDataAdapter dbAdapter;
        private static OleDbCommand command;
        private static DataSet ds;
        //submit purchase line items
        public static void SubmitItems(ArrayList itemList, int purchaseID)
        {
            
            try
            {
                // insert statemet
                foreach (PurchaseItemLine item in itemList)
                {
                    string sql = "INSERT INTO PurchaseLineItem (ItemID, PurchaseID, ItemName, ItemCost, ItemQty, TotalCost, ItemType)" +
                      "VALUES ('" + item.ItemID + "','" + purchaseID + "','" + item.ItemName +
                          "','" + item.ItemCost + "','" + item.Qty + "','" + item.TotalCost + "','" + item.ItemType + "');";

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
                Console.WriteLine("error " + e);
                MessageBox.Show("There was a Database Error");
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }
            
        }
        public static ArrayList GetPurchasesItems(int purchaseID)
        {
            ArrayList itemList = new ArrayList();
            try
            {
                // select customer info from cust table wher id mateches
                String sql = "Select * from PurchaseLineItem Where PurchaseID = '" + purchaseID + "';";
                // create connection
                dbAdapter = Connection.SetupConnection(sql);
                //create dataset
                ds = new DataSet();
                // fill dataset
                dbAdapter.Fill(ds, "PurchaseLineItem");
                // create new customer
                
                // fill cusotmer object
                foreach (DataRow dr in ds.Tables["PurchaseLineITem"].Rows)
                {
                    PurchaseItemLine anItem = new PurchaseItemLine();
                    anItem.ItemID = dr["ItemID"].ToString();
                    anItem.ItemName = dr["ItemName"].ToString();
                    anItem.ItemCost = Convert.ToDouble(dr["ItemCost"].ToString());
                    anItem.Qty = Convert.ToDouble(dr["ItemQty"].ToString());
                    anItem.TotalCost = Convert.ToDouble(dr["TotalCost"].ToString());
                    anItem.ItemType = dr["ItemType"].ToString();
                    itemList.Add(anItem);
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("customer not found");
            }
            // return customer object
            return itemList;
        }

    }
}
