/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Product Class*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Senior_Project
{
    class Product
    {
        //product attributes
        string prodSKU;
        public string ProdSKU
        {
            get { return prodSKU; }
            set { prodSKU = value; }
        }
        string prodName;
        public string ProdName
        {
             get { return prodName; }
            set { prodName = value; }
        }
        string prodType;
        public string ProdType
        {
            get { return prodType; }
            set { prodType = value; }
        }
        double prodCost;
        public double ProdCost
        {
            get { return prodCost; }
            set { prodCost = value; }
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
        //wrapper methods
        //wrapper method to get all products
        public static ArrayList ProductList()
        {
            return ProductDA.ProductList();
        }
        //create product wrapper method
        public static string CreateProduct(Product aProduct)
        {
            return ProductDA.CreateProduct(aProduct);
        }
        //update product wrapper method
        public static string UpdateProduct(Product aProduct)
        {
            return ProductDA.UpdateProduct(aProduct);
        }
        //wapper method to get products that need to be reordered
        public static ArrayList ProductReOrderList()
        {
            return ProductDA.ProductReOrderList();
        }
        public static ArrayList AddProductList()
        {
            return ProductDA.AddProductList();
        }
    }
}
