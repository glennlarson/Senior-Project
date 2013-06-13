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
    public partial class PurchaseDetails : Form
    {
        private Purchase aPurchase;
        public PurchaseDetails(Purchase aPurchase)
        {
            this.aPurchase = aPurchase;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadForm()
        {
            popCustBoxes();
            popList();
            popPaymentBoxes();
            txtEmp.Text = aPurchase.AEmployee.EmployeeFirstName + " " + aPurchase.AEmployee.EmployeeLastName;

        }
        private void popCustBoxes()
        {
            try
            {
                txtFirstName.Text = aPurchase.ACustomer.CustomerFirstName;
                txtLastName.Text = aPurchase.ACustomer.CustomerLastName;
                txtCustAddress1.Text = aPurchase.ACustomer.CustomerAddress1;
                txtCustAddress2.Text = aPurchase.ACustomer.CustomerAddress2;
                txtCustCity.Text = aPurchase.ACustomer.CustomerCity;
                txtCustState.Text = aPurchase.ACustomer.CustomerState;
                txtCustZip.Text = Convert.ToString(aPurchase.ACustomer.CustomerZip);
                txtCustAreaCode.Text = Convert.ToString(aPurchase.ACustomer.CustomerAreaCode);
                txtCustPhone.Text = Convert.ToString(aPurchase.ACustomer.CustomerPhone);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No Customer Entered");
            }
        }
        private void popList()
        {
            dgPurchaseList.DataSource = aPurchase.ItemList;
            txtSubTotal.Text = String.Format("{0:C}", aPurchase.SubTotal);
        }
        private void popPaymentBoxes()
        {
           
            if (aPurchase.APayment.PaymentType == "Cash")
            {
                rbCash.Select();
                txtPayAmount.Text = Convert.ToString(aPurchase.APayment.PayAmount);
                txtTax.Text = String.Format("{0:C}", aPurchase.Tax);
                txtTotal.Text = String.Format("{0:C}", aPurchase.Total);
            }
            else if (aPurchase.APayment.PaymentType == "Credit/Debit")
            {
                rbCredit.Select();
                txtcardType.Text = aPurchase.APayment.CardType;
                txtCardNum.Text = aPurchase.APayment.CardNum;
                txtPayAmount.Text = Convert.ToString(aPurchase.APayment.PayAmount);
                txtTax.Text = String.Format("{0:C}", aPurchase.Tax);
                txtTotal.Text = String.Format("{0:C}", aPurchase.Total);
            }
            else
            {
                txtcardType.Text = "No Payment Information";
                txtCardNum.Text = "No Payment Information";
            }
        }

        private void PurchaseDetails_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing Reciept");
        }
    }
}
