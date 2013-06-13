//Glenn Larson
//CIS591 Senior Project
//Service Ticket Form Code

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
    public partial class BikeService : Form
    {
        //declarations
        private Customer aCustomer;
        private Employee aEmployee;
        private CBike cBike;
        private Service aService;
        private double cost;
        ArrayList serviceList = new ArrayList();
        private TicketService ticket = new TicketService();
        //constructor
        public BikeService(Customer aCustomer, Employee aEmployee)
        {
            this.aEmployee = aEmployee;
            this.aCustomer = aCustomer;
            InitializeComponent();
        }
        //add btn click event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBike == null)
                {
                    MessageBox.Show("Please select a bike");
                }
                else
                {
                    AddServiceWindow addService = new AddServiceWindow();
                    addService.ShowDialog();
                    aService = new Service();
                    aService = addService.GetService();
                    if (aService == null)
                    {

                    }
                    else
                    {
                        serviceList.Add(aService);
                        addService.Dispose();
                        DisplayServiceList();
                        AddTotal();
                    }
                }
            }
            catch (NullReferenceException er)
            {

            }
        }
        //add total method
        private void DisplayServiceList()
        {
            dgService.DataSource = "";
            dgService.DataSource = serviceList;
        }
        private void AddTotal()
        {
            cost = 0;
            foreach (Service service in serviceList)
            {
                cost = service.ServiceCost + cost;

            }
            txtCost.Text = String.Format("{0:C}",cost);
        }
        // btn cancel click event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // btn select bike click event
        private void btnSelectBike_Click(object sender, EventArgs e)
        {
            try
            {
                SelectBike selectBike = new SelectBike(aCustomer.CustomerID);
                selectBike.ShowDialog();
                cBike = new CBike();
                cBike = selectBike.RetrieveBike();
                if (cBike == null)
                {

                }
                else
                {
                    selectBike.Dispose();
                    PopBikeData();
                }
            }
            catch (NullReferenceException er)
            {

            }
            catch (Exception er)
            {
                MessageBox.Show("" + er);
            }
        }
        // populate bike text boxes
        private void PopBikeData()
        {
            txtCBikeSerialNumber.Text = cBike.CBikeSerial;
            txtCBikeBrand.Text = cBike.CBikeBrand;
            txtCBikeModel.Text = cBike.CBikeModel;
        }
        // load bike service event
        private void BikeService_Load(object sender, EventArgs e)
        {
            popCustBoxes();
            txtEnteredBy.Text = aEmployee.EmployeeFirstName + " " + aEmployee.EmployeeLastName;

        }
        //populate customer boxes
        private void popCustBoxes()
        {
            txtCustFirstName.Text = aCustomer.CustomerFirstName;
            txtCustLastName.Text = aCustomer.CustomerLastName;
            txtCustAddress1.Text = aCustomer.CustomerAddress1;
            txtCustAddress2.Text = aCustomer.CustomerAddress2;
            txtCustCity.Text = aCustomer.CustomerCity;
            txtCustState.Text = aCustomer.CustomerState;
            txtCustZip.Text = Convert.ToString(aCustomer.CustomerZip);
            txtCustAreaCode.Text = Convert.ToString(aCustomer.CustomerAreaCode);
            txtCustPhone.Text = Convert.ToString(aCustomer.CustomerPhone);


        }
        //save btn click event
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cBike == null)
            {
                MessageBox.Show("No Bike Selected Please Select a Bike");
            }
            else if (serviceList.Count == 0)
            {
                MessageBox.Show("No Services Selected Please Select a Service");
            }
            else
            {
                ticket.EnteredByEmployee = aEmployee;
                ticket.CustBike = cBike;
                ticket.ACust = aCustomer;
                ticket.Cost = cost;
                ticket.ServiceTicketDescrip = txtServiceDescrip.Text;
                ticket.SList = serviceList;
                string submissionReport = TicketService.CreateTicket(ticket);
                MessageBox.Show(submissionReport);
                this.Close();
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            serviceList.RemoveAt(dgService.CurrentRow.Index);
            DisplayServiceList();
        }

    }
}
