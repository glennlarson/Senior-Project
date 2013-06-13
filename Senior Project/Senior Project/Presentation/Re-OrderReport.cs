/*Glenn Larson
 * Cis591
 * Cycle Manager
 * ReOrderReport*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Senior_Project
{
    public partial class Re_OrderReport : Form
    {
        // declarations
        ArrayList prodList;
        ArrayList bikeList;
        //constructor
        public Re_OrderReport()
        {
            InitializeComponent();
        }
        // form load event
        private void Re_OrderReport_Load(object sender, EventArgs e)
        {
            ReOrderItem reItem;
            prodList = Product.ProductReOrderList();
            bikeList = NewBike.nBikeReOrderList();
            ArrayList output = new ArrayList();
            foreach (Product aProd in prodList)
            {
                reItem = new ReOrderItem();
                reItem.SKU_Num = aProd.ProdSKU;
                reItem.Name = aProd.ProdName;
                reItem.QtyOH = aProd.QtyOH;
                reItem.ReOrderPoint = aProd.ReOrderPoint;
                reItem.Type = "Product";
                output.Add(reItem);
            }
            foreach (NewBike nBike in bikeList)
            {
                reItem = new ReOrderItem();
                reItem.SKU_Num = Convert.ToString(nBike.NBikeID);
                reItem.Name = nBike.NBikeBrand + " " + nBike.NBikeModel;
                reItem.QtyOH = nBike.QtyOH;
                reItem.ReOrderPoint = nBike.ReOrderPoint;
                reItem.Type = "New Bike";
                output.Add(reItem);
            }
            if(output.Count == 0)
            {
                MessageBox.Show("Not items Need To Be Reordered");
                this.Close();
            }
            else
            {
            dgReOrder.DataSource = output;
            }
        }
        
        // close btn click event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
