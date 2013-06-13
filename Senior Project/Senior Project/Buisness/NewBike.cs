/*Glenn Larson
 * Cis591
 * Cycle Manager
 * New Bike Class*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Senior_Project
{
    class NewBike
    {
       // attributes
        string nBikeBrand;
        public string NBikeBrand
        {
            get { return nBikeBrand; }
            set { nBikeBrand = value; }
        }
        string nBikeModel;
        public string NBikeModel
        {
            get { return nBikeModel; }
            set { nBikeModel = value; }
        }
        string nBikeType;
        public string NBikeType
        {
            get { return nBikeType; }
            set { nBikeType = value; }
        }
        double nBikeCost;
        public double NBikeCost
        {
            get { return nBikeCost; }
            set { nBikeCost = value; }
        }
        double qtyOH;
        public double QtyOH
        {
            get { return qtyOH; }
            set { qtyOH = value; }
        }
        double reOrderPoint;
        public double ReOrderPoint
        {
            get { return reOrderPoint; }
            set { reOrderPoint = value; }
        }
        int nBikeID;
        public int NBikeID
        {
            get { return nBikeID; }
            set { nBikeID = value; }
        }
        //wrapper methods
        //get bikes wrapper method
        public static ArrayList GetBikes()
        {
            return NewBikeDA.nBikeList();
        }
        // update bike wrapper method
        public static string UpdateBike(NewBike nBike)
        {
            return NewBikeDA.UpdateBike(nBike);
        }
        //add bike wrapper method
        public static string AddBike(NewBike nBike)
        {
            return NewBikeDA.AddNBike(nBike);
        }
        //wapper method for getting list of bikes that need to be reordered
        public static ArrayList nBikeReOrderList()
        {
            return NewBikeDA.nBikeReOrderList();
        }
        public static ArrayList AddGetBikes()
        {
            return NewBikeDA.AddnBikeList();
        }

    }
}
