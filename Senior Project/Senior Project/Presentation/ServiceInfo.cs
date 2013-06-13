/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Service Info Form*/
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
    public partial class ServiceInfo : Form
    {
        //declaration
        TicketService aTicket;
        //constructor
        public ServiceInfo(TicketService aTicket)
        {
            this.aTicket = aTicket;   
            InitializeComponent();
        }
        // close btn click event
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //form load event
        private void ServiceInfo_Load(object sender, EventArgs e)
        {
            txtCustFirstName.Text = aTicket.ACust.CustomerFirstName;
            txtCustLastName.Text = aTicket.ACust.CustomerLastName;
            txtCustAddress1.Text = aTicket.ACust.CustomerAddress1;
            txtCustAddress2.Text = aTicket.ACust.CustomerAddress2;
            txtCustCity.Text = aTicket.ACust.CustomerCity;
            txtCustState.Text = aTicket.ACust.CustomerState;
            txtCustZip.Text = Convert.ToString(aTicket.ACust.CustomerZip);
            txtCustAreaCode.Text = Convert.ToString(aTicket.ACust.CustomerAreaCode);
            txtCustPhone.Text = Convert.ToString(aTicket.ACust.CustomerPhone);
            txtBikeSerial.Text = aTicket.CustBike.CBikeSerial;
            txtBikeBrand.Text = aTicket.CustBike.CBikeBrand;
            txtBikeModel.Text = aTicket.CustBike.CBikeModel;
            txtTicketNumber.Text = Convert.ToString(aTicket.ServiceTicketID);
            txtDescrip.Text = aTicket.ServiceTicketDescrip;
            if (aTicket.EnteredByEmployee != null)
            {
                txtEnteredBy.Text = (aTicket.EnteredByEmployee.EmployeeFirstName + " " +
                    aTicket.EnteredByEmployee.EmployeeLastName);
            }

            if (aTicket.ServicedByEmp != null)
            {
                txtServiceEmployee.Text = aTicket.ServicedByEmp.EmployeeFirstName + " " +
                    aTicket.ServicedByEmp.EmployeeLastName;
            }
            dgServices.DataSource = aTicket.SList;
            try
            {
                this.dgServices.Columns["ServiceID"].Visible = false;
                this.dgServices.Columns["ServiceCost"].Visible = false;
                this.dgServices.Columns["ServiceDescrip"].Visible = false;
            }
            catch (NullReferenceException)
            {
                dgServices.DataSource = "ErrorLoading ServiceList";
            }
            
        }
    }
}
