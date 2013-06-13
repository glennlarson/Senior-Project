/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Manage New Bikes Form*/
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
    public partial class ManageNewBikes : Form
    {
        //declarations
        char dollarSign = '$';
        private static ArrayList newBikeList;
        private static string submissionReport;
        NewBike nBike;
        //constructor
        public ManageNewBikes()
        {
            InitializeComponent();
        }
        //close btn click event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // create bike object
        private void CreateBike()
        {
            nBike.NBikeBrand = txtBikeBrand.Text;
            nBike.NBikeModel = txtBikeModel.Text;
            nBike.NBikeType = txtType.Text;
            nBike.NBikeCost = Convert.ToDouble(txtBikeCost.Text.Trim(dollarSign));
            nBike.QtyOH = Convert.ToDouble(txtQOH.Text);
            nBike.ReOrderPoint = Convert.ToDouble(txtReOrder.Text);
        }
        //create btn click event
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Validation.validateStringAlphaNumericPeriod(txtBikeBrand.Text, "Bike Brand");
                Validation.validateStringAlphaNumericPeriod(txtBikeModel.Text, "Bike Model");
                Validation.validateStringAlpha(txtType.Text, "Product Type");
                Validation.validateCost(txtBikeCost.Text.Trim(dollarSign), "Product Cost");
                nBike = new NewBike();
                CreateBike();
                submissionReport = NewBike.AddBike(nBike);
                showMessage();
                LoadForm();
                btnClear_Click(null, null);
            }
            catch(FormatException er)
            {
                MessageBox.Show(er.Message);

            }
        }
        //loadform method
        private void LoadForm()
        {
            newBikeList = NewBike.GetBikes();
            dgBikeList.DataSource = newBikeList;
            this.dgBikeList.Columns["nBIkeID"].Visible = false;
        }
        // form load event
        private void ManageNewBikes_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        //update btn click event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                char dollarSign = '$';
                Validation.validateStringAlphaNumericPeriod(txtBikeBrand.Text, "Bike Brand");
                Validation.validateStringAlphaNumericPeriod(txtBikeModel.Text, "Bike Model");
                Validation.validateStringAlpha(txtType.Text, "Product Type");
                txtBikeCost.Text = txtBikeCost.Text.Trim(dollarSign);
                Validation.validateCost(txtBikeCost.Text, "Product Cost");
                CreateBike();
                submissionReport = NewBike.UpdateBike(nBike);
                showMessage();
                LoadForm();
                btnClear_Click(null, null);
            }
            catch (FormatException er)
            {
                MessageBox.Show(er.Message);
            }

        }
        // sho message method
        private void showMessage()
        {
            MessageBox.Show(submissionReport);
        }
        //pop text boxes method
        private void PopTextBoxes()
        {
            txtBikeBrand.Text = nBike.NBikeBrand;
            txtBikeModel.Text = nBike.NBikeModel;
            txtType.Text = nBike.NBikeType;
            txtBikeCost.Text = String.Format("{0:C}", nBike.NBikeCost);
            txtQOH.Text = Convert.ToString(nBike.QtyOH);
            txtReOrder.Text = Convert.ToString(nBike.ReOrderPoint);
        }
        // datagrid click event
        private void dgBikeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nBike = (NewBike)newBikeList[dgBikeList.CurrentRow.Index];
            btnCreate.Enabled = false;
            PopTextBoxes();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
            txtBikeBrand.Text = "";
            txtBikeModel.Text = "";
            txtType.Text = "";
            txtBikeCost.Text = String.Format("{0:C}", 0);
            txtQOH.Text = "0";
            txtReOrder.Text = "0";
        }
    }
}
