/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Manage Products Form*/
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
    public partial class Manage_Products : Form
    {
        //declarations
        ArrayList prodList;
        Product aProduct;
        // constructor
        public Manage_Products()
        {
            InitializeComponent();
        }
        //load page method
        private void LoadPage()
        {
            prodList = Product.ProductList();
            dgProducts.DataSource = prodList;
        }
        //close btn click event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // create btn click event
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                char dollarSign = '$';
                aProduct = new Product();
                Validation.validateStringAlphaNumeric(txtProdSku.Text, "Product Sku");
                Validation.validateStringAlphaNumericPeriod(txtProdName.Text, "Product Name");
                Validation.validateStringAlpha(txtProdType.Text, "Product Type");
                Validation.validateCost(txtProdCost.Text.Trim(dollarSign), "Product Cost");
                
                aProduct.ProdSKU = txtProdSku.Text;
                aProduct.ProdName = txtProdName.Text;
                aProduct.ProdType = txtProdType.Text;
                aProduct.ProdCost = Convert.ToDouble(txtProdCost.Text.Trim(dollarSign));
                aProduct.QtyOH = Convert.ToDouble(txtQOH.Text);
                aProduct.ReOrderPoint = Convert.ToDouble(txtReOrder.Text);
                Product.CreateProduct(aProduct);
                btnClear_Click(null, null);
            }
            catch (FormatException er)
            {
                MessageBox.Show(er.Message);
            }
            LoadPage();
        }
        // form load event
        private void Manage_Products_Load(object sender, EventArgs e)
        {
            LoadPage();
        }
        //populate text boxes
        private void PopTextBoxes()
        {
            try
            {
                txtProdSku.Text = aProduct.ProdSKU;
                txtProdName.Text = aProduct.ProdName;
                txtProdType.Text = aProduct.ProdType;
                txtProdCost.Text = Convert.ToString(aProduct.ProdCost);
                txtQOH.Text = Convert.ToString(aProduct.QtyOH);
                txtReOrder.Text = Convert.ToString(aProduct.ReOrderPoint);
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
        //update btn click
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                char dollarSign = '$';
                aProduct = new Product();
                Validation.validateStringAlphaNumeric(txtProdSku.Text, "Product Sku");
                Validation.validateStringAlphaNumericPeriod(txtProdName.Text, "Product Name");
                Validation.validateStringAlpha(txtProdType.Text, "Product Type");
                Validation.validateCost(txtProdCost.Text.Trim(dollarSign), "Product Cost");
                aProduct.ProdSKU = txtProdSku.Text;
                aProduct.ProdName = txtProdName.Text;
                aProduct.ProdType = txtProdType.Text;
                aProduct.ProdCost = Convert.ToDouble(txtProdCost.Text.Trim(dollarSign));
                aProduct.QtyOH = Convert.ToDouble(txtQOH.Text);
                aProduct.ReOrderPoint = Convert.ToDouble(txtReOrder.Text);
                string submissionReport = Product.UpdateProduct(aProduct);
                MessageBox.Show(submissionReport);
                LoadPage();
                btnClear_Click(null, null);
            }
            catch (FormatException er)
            {
                MessageBox.Show(er.Message);
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
                MessageBox.Show("error");
            }
        }
        // data grid btn click
        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aProduct = (Product)prodList[dgProducts.CurrentRow.Index];
            btnCreate.Enabled = false;
            PopTextBoxes();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProdSku.Text = "";
            btnCreate.Enabled = true;
            txtProdName.Text = "";
            txtProdType.Text = "";
            txtProdCost.Text = String.Format("{0:C}", 0);
            txtQOH.Text = "0";
            txtReOrder.Text = "0";
        }
    }
}


