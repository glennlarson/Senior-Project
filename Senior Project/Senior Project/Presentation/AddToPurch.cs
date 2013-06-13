/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Add To Purchase*/
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
    public partial class AddToPurch : Form
    {
        //declarations
        ArrayList prodList;
        ArrayList bikeList;
        PurchaseItemLine aItem;
        // constructor
        public AddToPurch()
        {
            InitializeComponent();
        }
        //close btn click event
        private void btnClose_Click(object sender, EventArgs e)
        {
            aItem = null;
            this.Close();
        }
        // add to purchase form load
        private void AddToPurch_Load(object sender, EventArgs e)
        {
            prodList = Product.AddProductList();
            bikeList = NewBike.AddGetBikes();
            this.cbProdBike.SelectedIndex = 0;
            cbProdBike_SelectedIndexChanged(null, null);
            
        }
        // load bike list method
        private void LoadBikeList()
        {
            

            dgList.DataSource = bikeList;
            this.dgList.Columns["NBikeID"].Visible = false;
            this.dgList.Columns["ReOrderPoint"].Visible = false;
        }
        // load products list method
        private void LoadProductsList()
        {
            
            dgList.DataSource = prodList;
            this.dgList.Columns["ReOrderPoint"].Visible = false;
        }
        //datagrid selection changed event
        private void dgList_SelectionChanged(object sender, EventArgs e)
        {
            if (cbProdBike.SelectedItem.ToString() == "Bikes")
            {
                aItem = new PurchaseItemLine();
                NewBike aBike;
                aBike = (NewBike)bikeList[dgList.CurrentRow.Index];
                aItem.ItemID = Convert.ToString(aBike.NBikeID);
                aItem.ItemName = aBike.NBikeBrand + aBike.NBikeModel;
                aItem.ItemCost = aBike.NBikeCost;
                aItem.ItemType = "Bike";
                numbUpDown.Value = 1;
                numbUpDown.Maximum = Convert.ToDecimal(aBike.QtyOH);
                
            }
            else if (cbProdBike.SelectedItem.ToString() == "Products")
            {
                try
                {
                    aItem = new PurchaseItemLine();
                    Product aProduct;
                    aProduct = (Product)prodList[dgList.CurrentRow.Index];
                    aItem.ItemID = Convert.ToString(aProduct.ProdSKU);
                    aItem.ItemName = aProduct.ProdName;
                    aItem.ItemCost = aProduct.ProdCost;
                    aItem.ItemType = "Product";
                    numbUpDown.Value = 1;
                    numbUpDown.Maximum = Convert.ToDecimal(aProduct.QtyOH);
                }
                catch (ArgumentOutOfRangeException)
                {

                }

            }
        }
        // combo box selection change method
        private void cbProdBike_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProdBike.SelectedItem.ToString() == "Bikes")
            {
                dgList.DataSource = null;
                LoadBikeList();
            }
            else if (cbProdBike.SelectedItem.ToString() == "Products")
            {
                dgList.DataSource = null;
                LoadProductsList();
            }
        }
        // add btn click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            aItem.Qty = Convert.ToDouble(numbUpDown.Value);
            aItem.TotalCost = aItem.ItemCost * aItem.Qty;
            this.Hide();
        }
        // get item method
        public PurchaseItemLine GetItem()
        {
            return aItem;
        }
    }
}
