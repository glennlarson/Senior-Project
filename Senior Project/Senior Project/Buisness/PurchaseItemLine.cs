/*Glenn Larson
 * Cis591
 * Cycle Manager
 *Purchase Line Class*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senior_Project
{
    public class PurchaseItemLine
    {
        //purchase item line attributes
        string itemID;
        public string ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }
        string itemName;
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        double itemCost;
        public double ItemCost
        {
            get { return itemCost; }
            set { itemCost = value; }
        }
        double qty;
        public double Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        double totalCost;
        public double TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }
        string itemType;
        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }
    }
}
