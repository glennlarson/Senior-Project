/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Service Form*/
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
    public partial class Services : Form
    {
        //declartions
        char dollarSign = '$';
        Service aService;
        ArrayList sList;
        string submissionReport;
        //constructor
        public Services()
        {
            InitializeComponent();
        }
        //build service object
        private void buildService()
        {
                aService = new Service();
                aService.ServiceName = txtServiceName.Text;
                aService.ServiceType = txtServiceType.Text;
                aService.ServiceDescrip = txtServiceDescrip.Text;
                aService.ServiceCost = Convert.ToDouble(txtServiceCost.Text.Trim(dollarSign));

        }
        //add btn click event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Validation.validateStringAlpha(txtServiceName.Text, "Name");
                Validation.validateStringAlpha(txtServiceType.Text, "Type");
                Validation.validateCost(txtServiceCost.Text.Trim(dollarSign), "Cost");
                buildService();
                submissionReport = Service.addService(aService);
                MessageBox.Show(submissionReport);
                LoadFormData();
                btnClear_Click(null, null);

            }
            catch (FormatException er)
            {
                MessageBox.Show(er.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }

        }
        // close btn click event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //load services method
        private void Services_Load(object sender, EventArgs e)
        {
            LoadFormData();
        }
        //load form data method
        private void LoadFormData()
        {
            sList = Service.allServices();
            dgServiceList.DataSource = sList;
        }
        //delete btn click event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int sNum;
            sNum = Convert.ToInt16(txtServiceID.Text);
            submissionReport = Service.DeleteService(sNum);
            MessageBox.Show(submissionReport);
            LoadFormData();
        }
        // populate text boxes method
        private void PopTextBoxes()
        {
            txtServiceID.Text = Convert.ToString(aService.ServiceID);
            txtServiceName.Text = aService.ServiceName;
            txtServiceType.Text = aService.ServiceType;
            txtServiceDescrip.Text = aService.ServiceDescrip;
            txtServiceCost.Text = String.Format("{0:C}", aService.ServiceCost);


        }
        // edit btn clieck event
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Validation.validateStringAlpha(txtServiceName.Text, "Service Name");
                Validation.validateStringAlpha(txtServiceType.Text, "Service Type");
                Validation.validateCost(txtServiceCost.Text.Trim(dollarSign), "Service Cost");
                buildService();
                aService.ServiceID = Convert.ToInt32(txtServiceID.Text);
                submissionReport = Service.UpdateService(aService);
                MessageBox.Show(submissionReport);
                LoadFormData();
                btnClear_Click(null, null);
            }
            catch (FormatException er)
            {
                MessageBox.Show(er.Message);
            }

        }
        //datagrid click event
        private void dgServiceList_Click(object sender, EventArgs e)
        {
            aService = new Service();
            aService = (Service)sList[dgServiceList.CurrentRow.Index];
            btnAdd.Enabled = false;
            PopTextBoxes();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            txtServiceID.Text = "";
            txtServiceName.Text = "";
            txtServiceType.Text = "";
            txtServiceDescrip.Text = "";
            txtServiceCost.Text = String.Format("{0:C}", 0);
        }
    }
}
