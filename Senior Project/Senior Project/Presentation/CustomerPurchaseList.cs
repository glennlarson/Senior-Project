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
    public partial class CustomerPurchaseList : Form
    {
        ArrayList pList = new ArrayList();
        Customer aCustomer;
        public CustomerPurchaseList(Customer aCustomer)
        {
            this.aCustomer = aCustomer;
            InitializeComponent();
        }

        private void btnCloes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerPurchaseList_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Customer " + aCustomer.CustomerFirstName + " " + aCustomer.CustomerLastName + " Purchase History";
                pList = Purchase.selectCustomerPurchases(aCustomer);
                if (pList.Count > 0)
                {
                    dgList.DataSource = pList;
                    this.dgList.Columns["ACustomer"].Visible = false;
                    this.dgList.Columns["AEmployee"].Visible = false;
                    this.dgList.Columns["APayment"].Visible = false;
                }
                else
                {
                    MessageBox.Show("Customer has no purchase history");
                    this.Close();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Customer has no purchase history");
                this.Close();
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Purchase aPurchase = new Purchase();
            aPurchase = (Purchase)pList[dgList.CurrentRow.Index];
            aPurchase.ACustomer = aCustomer;
            PurchaseDetails detailsForm = new PurchaseDetails(aPurchase);
            detailsForm.ShowDialog();
        }
    }
}