////Glenn Larson
//CIS591 Senior Project
//New Customer Bike Form Code

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Senior_Project
{
    public partial class NewCustomerBike : Form
    {
        //declarations
        private CBike cBike = new CBike();
        //constructor
        public NewCustomerBike(int custID)
        {
            InitializeComponent();
            cBike.CBikeCustID = custID;
        }
        //cancel btn click event
        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        //create btn click event
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Validation.validateStringAlphaNumeric(txtCBikeBrand.Text, "Bike Brand");
                Validation.validateStringAlphaNumeric(txtCBikeModel.Text, "Bike Model");
                Validation.validateNumeric(txtCBikeSerial.Text, "Bike Seriel");
                cBike.CBikeSerial = txtCBikeSerial.Text;
                cBike.CBikeBrand = txtCBikeBrand.Text;
                cBike.CBikeModel = txtCBikeModel.Text;
                MessageBox.Show(CBike.createCustomerBike(cBike));
                this.Close();
            }
            catch (FormatException er)
            {
                MessageBox.Show(er.Message);
            }
            
        }
    }
}
