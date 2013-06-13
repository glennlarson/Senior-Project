//Glenn Larson
//CIS591 Senior Project
//Customer Bike Class Code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Senior_Project
{
    public class CBike
    {
        //attributes of cbike class
        int cBikeID;
        public int CBikeID
        {
            get { return cBikeID; }
            set { cBikeID = value; }
        }
        string cBikeBrand;
        public string CBikeBrand
        {
            get { return cBikeBrand; }
            set { cBikeBrand = value; }
        }
        string cBikeModel;
        public string CBikeModel
        {
            get { return cBikeModel; }
            set { cBikeModel = value; }
        }
        string cBikeSerial;
        public string CBikeSerial
        {
            get { return cBikeSerial; }
            set { cBikeSerial = value; }
        }
        int cBikeCustID;
        public int CBikeCustID
        {
            get { return cBikeCustID; }
            set { cBikeCustID = value; }
        }
        //wrapper methods for data access
        //create customer bike wrapper method
        public static string createCustomerBike(CBike cBike)
        {
            return CBikeDA.addCBike(cBike);
        }
        //get all customer bikes wrapper method
        public static ArrayList CustBikes(int custID)
        {
            return CBikeDA.CustBikes(custID);
        }
        //get customer bike 
        public static CBike CustBike(int custID, int bikeID)
        {
            return CBikeDA.CustBike(custID, bikeID);
        }
    }
}
