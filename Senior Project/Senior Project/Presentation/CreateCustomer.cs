/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Create Customer Form*/
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
    public partial class CreateCustomer : Form
    {
        //declaration
        private static Customer aCustomer;
        // constructor
        public CreateCustomer()
        {
            InitializeComponent();
        }
        //btn cancel click event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //btn create btn click
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Validation.validateStringAlpha(txtCustFirstName.Text, "Customer First Name");
                Validation.validateStringAlpha(txtCustLastName.Text, "Customer Last Name");
                Validation.validateStringAlphaNumericPeriod(txtCustAddress1.Text, "Customer Address 1");
                Validation.validateStringAddress2(txtCustAddress2.Text, "Customer Address 2");
                Validation.validateStringAlphaPeriod(txtCustCity.Text, "City");
                Validation.validateStringAlpha(txtCustState.Text, "State");
                Validation.validateNotBlank(txtCustZip.Text, "Zip");
                Validation.validateNotBlank(txtCustAreaCode.Text, "Area Code");
                Validation.validateNotBlank(txtCustZip.Text, "Phone Number");
                aCustomer = new Customer();
                aCustomer.CustomerFirstName = txtCustFirstName.Text;
                aCustomer.CustomerLastName = txtCustLastName.Text;
                aCustomer.CustomerAddress1 = txtCustAddress1.Text;
                aCustomer.CustomerAddress2 = txtCustAddress2.Text;
                aCustomer.CustomerCity = txtCustCity.Text;
                aCustomer.CustomerState = txtCustState.Text;
                aCustomer.CustomerZip = Convert.ToInt32(txtCustZip.Text);
                aCustomer.CustomerPhone = txtCustPhone.Text;
                aCustomer.CustomerAreaCode = txtCustAreaCode.Text;
                string submissionReport = Customer.createCustomer(aCustomer);
                MessageBox.Show(submissionReport);
                aCustomer.CustomerID = Customer.getCustomerNumber();
                this.Hide();
            }
            catch (FormatException er)
            {
                MessageBox.Show(er.Message);
            }
        }
        // allows main form to retrieve customer
        public Customer RetrieveCustomer()
        {
            return aCustomer;
        }
    }
}
