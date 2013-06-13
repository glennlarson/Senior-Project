/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Purchase Class*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Senior_Project
{
    public class Purchase
    {
        //purchase attributes
        int purchaseID;
        public int PurchaseID
        {
            get { return purchaseID; }
            set { purchaseID = value; }
        }
        Customer aCustomer;
        public Customer ACustomer
        {
            get { return aCustomer; }
            set { aCustomer = value; }
        }
        ArrayList itemList;
        public ArrayList ItemList
        {
            get { return itemList; }
            set { itemList = value; }
        }
        Employee aEmployee;
        public Employee AEmployee
        {
            get { return aEmployee; }
            set { aEmployee = value; }
        }
        Payment aPayment;
        public Payment APayment
        {
            get { return aPayment; }
            set { aPayment = value; }
        }
        double total;
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        double subTotal;
        public double SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }
        double tax;
        public double Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        //submit purchase wrapper method
        public static void submitPurchase(Purchase aPurchase)
        {
            try
            {
                //break up purchase into the parts needed to submit
                //submit item list to purchase line table
                aPurchase = PurchaseDA.SubmitPurchase(aPurchase);
                PurchaseLineDa.SubmitItems(aPurchase.ItemList, aPurchase.PurchaseID);
                //the purcahse infromation includeing customer id and employee name
                foreach (PurchaseItemLine item in aPurchase.itemList)
                {
                    //update quantities
                    if (item.ItemType == "Product")
                    {
                        ProductDA.UpdateQuantity(item);
                    }
                    else if (item.ItemType == "Bike")
                    {
                        NewBikeDA.UpdateQty(item);
                    }
                    // move service on to paid 
                    else if (item.ItemType == "Service")
                    {
                        TicketServiceDA.ServiceTicketPaid(item);
                    }
                }
                PaymentDA.SubmitPayment(aPurchase.aPayment, aPurchase.purchaseID);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            double change = aPurchase.aPayment.PayAmount - aPurchase.Total;
            //payment information which will have purchase id attached
            MessageBox.Show(String.Format("Reciept Is printing \nChange Due is: {0:C}" ,change));

        }
        public static ArrayList selectCustomerPurchases(Customer aCustomer)
        {
            ArrayList tempList = new ArrayList();
            tempList = PurchaseDA.GetPurchases(aCustomer);
            ArrayList pList = new ArrayList();
            foreach (Purchase aPurchase in tempList)
            {
                aPurchase.AEmployee = EmployeeDA.FindEmployee(aPurchase.aEmployee.EmployeeID);
                aPurchase.APayment = PaymentDA.GetPayment(aPurchase.PurchaseID);
                aPurchase.itemList = PurchaseLineDa.GetPurchasesItems(aPurchase.PurchaseID);
                pList.Add(aPurchase);
            }
            return pList;
        }
    }
}
