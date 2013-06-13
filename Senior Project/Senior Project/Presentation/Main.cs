//Glenn Larson
//CIS591 Senior Project
//Main Form Code

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
    public partial class Form1 : Form
    {
        // variable declerations
        ArrayList empList = new ArrayList();
        Customer aCustomer = new Customer();
        Employee aEmployee;
        TicketService aTicket;
        ArrayList queueList;
        ArrayList servicingList;
        ArrayList completedList;
        ArrayList itemList;
        PurchaseItemLine aItem;
        Payment aPayment;
        double subTotal;
        // constructor
        public Form1()
        {

            InitializeComponent();
            Connection.CreateConnection();
        }
        // exit menu item click event
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connection.CloseConnection();
            backupToolStripMenuItem_Click(null, null);
            Application.Exit();
        }
        // employee menu item click event
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeAdmin employeeForm = new EmployeeAdmin();
            employeeForm.ShowDialog();
            employeeForm.Dispose();

        }
        // clock in menu event click
        private void clockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClockInOut inOutForm = new ClockInOut(1, empList);
            inOutForm.ShowDialog();
            empList = inOutForm.retrieveEmpList();
            inOutForm.Dispose();
            popWorkinEmps();
        }
        // clock out menu click event
        private void clockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClockInOut inOutForm = new ClockInOut(100, empList);
            inOutForm.ShowDialog();
            empList = inOutForm.retrieveEmpList();
            inOutForm.Dispose();
            popWorkinEmps();
        }
        // pupulate working employee data grid 
        private void popWorkinEmps()
        {
            try
            {
                dgWorkinEmp.DataSource = null;
                dgWorkinEmp.DataSource = empList;
                this.dgWorkinEmp.Columns["EmployeeId"].Visible = false;
                this.dgWorkinEmp.Columns["EmployeeAddress1"].Visible = false;
                this.dgWorkinEmp.Columns["EmployeeAddress2"].Visible = false;
                this.dgWorkinEmp.Columns["EmployeeCity"].Visible = false;
                this.dgWorkinEmp.Columns["EmployeeState"].Visible = false;
                this.dgWorkinEmp.Columns["EmployeeZip"].Visible = false;
                this.dgWorkinEmp.Columns["EmployeePhone"].Visible = false;
                this.dgWorkinEmp.Columns["EmployeeAreaCode"].Visible = false;
                this.dgWorkinEmp.Columns["EmployeePayRate"].Visible = false;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("error no employees clocked in");
            }
        }
        //services menu click event
        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Services formServices = new Services();
            formServices.ShowDialog();
            formServices.Dispose();
        }
        // service ticket info btn click event
        private void btnInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (aTicket.ServiceTicketID == 0)
                {
                    throw new NullReferenceException();
                }
                ServiceInfo infoForm = new ServiceInfo(aTicket);
                infoForm.ShowDialog();
            }
            catch (NullReferenceException)
                {
                    MessageBox.Show("Please Select A service From one of The service Queues");
                }
        }
        //service btn click event
        private void btnService_Click(object sender, EventArgs e)
        {
            try
            {
                if (aCustomer.CustomerID == 0)
                {
                    throw new NullReferenceException();
                }
                string enteredBy = aEmployee.EmployeeFirstName + " " + aEmployee.EmployeeLastName;
                BikeService serviceTicket = new BikeService(aCustomer, aEmployee);
                serviceTicket.ShowDialog();
                loadFormData();
                ResetForm();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please Make Sure You have a Customer and Employee Selected");
            }
        }
        // create customer btn click event
        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            CreateCustomer createCustomer = new CreateCustomer();
            createCustomer.ShowDialog();
            aCustomer = createCustomer.RetrieveCustomer();
            createCustomer.Dispose();
            popCustBoxes();
        }
        // populate customer text boxes
        private void popCustBoxes()
        {
            try
            {
                if (aCustomer.CustomerFirstName == null || aCustomer.CustomerLastName == null)
                {
                    MessageBox.Show("Customer Not Found");
                }
                else
                {
                    txtFirstName.Text = aCustomer.CustomerFirstName;
                    txtLastName.Text = aCustomer.CustomerLastName;
                    txtCustAddress1.Text = aCustomer.CustomerAddress1;
                    txtCustAddress2.Text = aCustomer.CustomerAddress2;
                    txtCustCity.Text = aCustomer.CustomerCity;
                    txtCustState.Text = aCustomer.CustomerState;
                    txtCustZip.Text = Convert.ToString(aCustomer.CustomerZip);
                    txtCustAreaCode.Text = Convert.ToString(aCustomer.CustomerAreaCode);
                    txtCustPhone.Text = Convert.ToString(aCustomer.CustomerPhone);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No Customer Entered");
            }


        }
        // clear customer txt boxes
        private void btnCustClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text ="";
            txtLastName.Text = "";
            txtCustAddress1.Text = "";
            txtCustAddress2.Text = "";
            txtCustCity.Text = "";
            txtCustState.Text = "";
            txtCustZip.Text = "";
            txtCustAreaCode.Text = "";
            txtCustPhone.Text = "";
            aCustomer = new Customer();
        }
        //find customer btn click
        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            aCustomer = new Customer();
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please Enter the Customers First Name.");
            }
            else if (txtLastName.Text =="")
            {
                MessageBox.Show("Please Enter the Customers Last Name.");
            }
            else
            {
                try
                {
                    Validation.validateStringAlpha(txtFirstName.Text, "Customer First Name");
                    Validation.validateStringAlpha(txtLastName.Text, "Customer Last Name");
                    aCustomer = Customer.findCustomer(txtFirstName.Text, txtLastName.Text);
                    popCustBoxes();
                }
                catch(FormatException er)
                {
                    MessageBox.Show(er.Message);
                }
            }

        }
        //cell click on workin employee data grid
        private void dgWorkinEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                aEmployee = new Employee();
                aEmployee = (Employee)empList[dgWorkinEmp.CurrentRow.Index];
            }
            catch (IndexOutOfRangeException er)
            {
                Console.WriteLine("" + er);
                MessageBox.Show("Please Select the employee again");
            }
            catch (NullReferenceException er)
            {
                Console.WriteLine("" + er);
                MessageBox.Show("Please Select the employee again");
                
            }
           
        }
        // load form data method
        private void loadFormData()
        {
            try
            {
                queueList = new ArrayList();
                servicingList = new ArrayList();
                completedList = new ArrayList();
                queueList = TicketService.queueTickets("queue");
                servicingList = TicketService.queueTickets("Servicing");
                completedList = TicketService.queueTickets("Completed");
                displayQueueList();
                displayServicingList();
                displayCompletedList();
                dgServicingQueue.ClearSelection();
                dgServiceQueue.ClearSelection();
                dgCompletedQueue.ClearSelection();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null Reference Exception");
            }

        }
        //display service queue list method
        private void displayQueueList()
        {
            try
            {
                dgServiceQueue.DataSource = queueList;
                this.dgServiceQueue.Columns["EnteredByEmployee"].Visible = false;
                this.dgServiceQueue.Columns["ServicedByEmp"].Visible = false;
                this.dgServiceQueue.Columns["ACust"].Visible = false;
                this.dgServiceQueue.Columns["CustBIke"].Visible = false;
                this.dgServiceQueue.Columns["Cost"].Visible = false;
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("no queue list to load");
            }
        }
        // display servicing queue list method
        private void displayServicingList()
        {
            try
            {
                dgServicingQueue.DataSource = servicingList;
                this.dgServicingQueue.Columns["EnteredByEmployee"].Visible = false;
                this.dgServicingQueue.Columns["ServicedByEmp"].Visible = false;
                this.dgServicingQueue.Columns["ACust"].Visible = false;
                this.dgServicingQueue.Columns["CustBIke"].Visible = false;
                this.dgServicingQueue.Columns["Cost"].Visible = false;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("no queue list to load");
            }
        }
        // display competed queue list method
        private void displayCompletedList()
        {
            try
            {
                dgCompletedQueue.DataSource = completedList;
                this.dgCompletedQueue.Columns["EnteredByEmployee"].Visible = false;
                this.dgCompletedQueue.Columns["ServicedByEmp"].Visible = false;
                this.dgCompletedQueue.Columns["ACust"].Visible = false;
                this.dgCompletedQueue.Columns["CustBIke"].Visible = false;
                this.dgCompletedQueue.Columns["Cost"].Visible = false;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("no queue list to load");
            }
        }
        // form1 loading event 
        private void Form1_Load(object sender, EventArgs e)
        {
            if (empList.Count == 0)
            {
                clockInToolStripMenuItem_Click(null, null);
            
            }
            loadFormData();
        }
        // start service btn click event
        private void btnStartService_Click(object sender, EventArgs e)
        {
            aTicket = new TicketService();

            DialogResult result;
            try
            {
               result = MessageBox.Show("Are you " + aEmployee.EmployeeFirstName +" "+ aEmployee.EmployeeLastName + "?", "Verify Employee", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Please Select Correct Employee");
                }
                if (result == DialogResult.Yes)
                {
                    aTicket = (TicketService)queueList[dgServiceQueue.CurrentRow.Index];
                    aTicket.ServicedByEmp = aEmployee;
                    TicketService.UpdateStatus(aTicket, "Servicing");
                    
                }
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please Select an Employee");
            }
            loadFormData();
        }
        //click event for service queue data grid
        private void dgServiceQueue_Click(object sender, EventArgs e)
        {
            dgCompletedQueue.ClearSelection();
            dgServicingQueue.ClearSelection();
        }
        //click event for servicimg queue data grid
        private void dgServicingQueue_Click(object sender, EventArgs e)
        {
            dgServiceQueue.ClearSelection();
            dgCompletedQueue.ClearSelection();
            dgCompletedQueue.Update();
        }
        //click event for completed queue data grid
        private void dgCompletedQueue_Click(object sender, EventArgs e)
        {
            dgServiceQueue.ClearSelection();
            dgServicingQueue.ClearSelection();
        }
        //click event for service queue data grid
        private void dgServiceQueue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                aTicket = new TicketService();
                aTicket = (TicketService)queueList[dgServiceQueue.CurrentRow.Index];
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }
           
        }
        //click event for servicing queue data grid
        private void dgServicingQueue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                aTicket = new TicketService();
                aTicket = (TicketService)servicingList[dgServicingQueue.CurrentRow.Index];
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }
        }
        //click event for completed queue data grid
        private void dgCompletedQueue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                aTicket = new TicketService();
                aTicket = (TicketService)completedList[dgCompletedQueue.CurrentRow.Index];
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }
        }
        // complete btn click event
        private void btnComplete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            try
            {
                aTicket = (TicketService)servicingList[dgServicingQueue.CurrentRow.Index];
                result = MessageBox.Show("Is Service ticket: " + aTicket.ServiceTicketID + " done being serviced?", "Continue", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    TicketService.UpdateStatus(aTicket, "Completed");
                    loadFormData();
                }
                else
                {
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error");
            }
            
        }
        //manage products menu item click
        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Products prodForm = new Manage_Products();
            prodForm.ShowDialog();

        }
        // manage bikes menu item click
        private void manageNewBikesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageNewBikes newBikes = new ManageNewBikes();
            newBikes.ShowDialog();
        }
        //add btn click event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddToPurch addForm = new AddToPurch();
            addForm.ShowDialog();
            aItem = addForm.GetItem();
            if (aItem == null)
            {
                addForm.Dispose();
            }
            else
            {
                itemList.Add(aItem);
                addForm.Dispose();
                displayProdList();
            }
            
        }
        // display prod list method
        private void displayProdList()
        {
            dgPurchaseList.DataSource = null;
            dgPurchaseList.DataSource = itemList;
            subTotal = 0;
            foreach (PurchaseItemLine item in itemList)
            {
                subTotal = subTotal + item.TotalCost;
            }
            txtSubTotal.Text = String.Format("{0:C}",subTotal);
            double tax = (subTotal * .0725);
            txtTax.Text = String.Format("{0:C}", tax);
            txtTotal.Text = String.Format("{0:C}", subTotal + tax);
        }
        // purchase btn click
        private void btnPurchase_Click(object sender, EventArgs e)
        {

            try
            {
                if (aCustomer.CustomerID == 0)
                {
                    throw new NullReferenceException();
                }
                string enteredBy = aEmployee.EmployeeFirstName + " " + aEmployee.EmployeeLastName;
                gbPurchase.Enabled = true;
                gbPayment.Enabled = true;
                itemList = new ArrayList();
                subTotal = 0;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please Make Sure You have a Customer and Employee Selected");
            }


        }
        // add to cart btn click
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            DialogResult result;
            aItem = new PurchaseItemLine();
            aTicket = new TicketService();
            aTicket = (TicketService)completedList[dgCompletedQueue.CurrentRow.Index];
            result = MessageBox.Show("Add service ticket: " + aTicket.ServiceTicketID + " to purchase?", "Continue", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                aItem.ItemID = Convert.ToString(aTicket.ServiceTicketID);
                aItem.ItemName = "Service";
                aItem.ItemType = "Service";
                aItem.ItemCost = aTicket.Cost;
                aItem.Qty = 1;
                aItem.TotalCost = aTicket.Cost;
                itemList.Add(aItem);
                displayProdList();
            }
            else
            {
            }
        }
        //rb credit checked change event
        private void rbCredit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtCardNum.Enabled = true;
                cbCardType.Enabled = true;



            }
            catch (Exception)
            {
            }
        }
        // rb cash checked change event
        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtCardNum.Enabled = false;
                cbCardType.Enabled = false;
            }
            catch (Exception)
            {

            }
        }
        // complete purchase btn click
        private void Complete_Click(object sender, EventArgs e)
        {
            char dollarSign = '$';
            try
            {
                if (Convert.ToDouble(txtPayAmount.Text.Trim(dollarSign)) >= Convert.ToDouble(txtSubTotal.Text.Trim(dollarSign)) && Convert.ToDouble(txtTotal.Text.Trim(dollarSign)) != 0 && Convert.ToDouble(txtPayAmount.Text.Trim(dollarSign))!= 0)
                {
                    aPayment = new Payment();
                    if (rbCredit.Checked == true)
                    {
                        Validation.validateNotSelected(cbCardType.Text, "Card Type");
                        Validation.validateNumeric(txtCardNum.Text, "Card Number");
                        Validation.validateCost(txtPayAmount.Text, "Payment Amount");
                        aPayment.PaymentType = "Credit/Debit";
                        aPayment.CardNum = txtCardNum.Text;
                        aPayment.CardType = cbCardType.Text;
                        aPayment.PayAmount = Convert.ToDouble(txtPayAmount.Text);
                        PurchaseCreate();

                    }
                    else if (rbCash.Checked == true)
                    {
                        Validation.validateCost(txtPayAmount.Text, "Payment Amount");
                        aPayment.PaymentType = "Cash";
                        aPayment.PayAmount = double.Parse(txtPayAmount.Text);
                        PurchaseCreate();
                    }
                    else
                    {
                        MessageBox.Show("Please Select payment Type");
                    }
                }
                else
                {
                    MessageBox.Show("Payment amount needs to be greater than or equal to total and total cannot Be zero");
                }
            }
            catch (FormatException er)
            {
                MessageBox.Show(er.Message);
            }
        }
        // create purchase item
        private void PurchaseCreate()
        {
            char dollarSign = '$';
            Purchase aPurchase = new Purchase();
            aPurchase.ACustomer = aCustomer;
            aPurchase.ItemList = itemList;
            aPurchase.AEmployee = aEmployee;
            aPurchase.APayment = aPayment;
            aPurchase.SubTotal = Convert.ToDouble(txtSubTotal.Text.Trim(dollarSign));
            aPurchase.Tax = Convert.ToDouble(txtTax.Text.Trim(dollarSign));
            aPurchase.Total = Convert.ToDouble(txtTotal.Text.Trim(dollarSign));
            Purchase.submitPurchase(aPurchase);
            loadFormData();
            ResetForm();
        }
        // reset form method
        private void ResetForm()
        {
            dgPurchaseList.DataSource = null;
            txtCardNum.Text = "";
            txtSubTotal.Text = "0";
            txtTax.Text = "0";
            txtTotal.Text = "0";
            txtPayAmount.Text = "0";
            cbCardType.Enabled = false;
            txtCardNum.Enabled = false;
            gbPayment.Enabled = false;
            gbPurchase.Enabled = false;
            btnCustClear_Click(null, null);
        }
        // remove item from cart button click
        private void btnRemove_Click(object sender, EventArgs e)
        {
            itemList.RemoveAt(dgPurchaseList.CurrentRow.Index);
            displayProdList();
        }
        // backup database menu item click
        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "seniorproject.accdb";
            string sourcePath = @"C:\Senior Project\";
            string targetPath = @"C:\";
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(fileName))
            {
                System.IO.File.Copy(fileName, destFile, true);
                MessageBox.Show("Backup of database successful");
            }
            else
            {
                MessageBox.Show("File Doesn't Exist");
            }
        }
        // restore database menu item click
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "seniorproject.accdb";
            string targetPath = @"C:\Senior Project";
            string sourcePath = @"C:\";
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            if (System.IO.File.Exists(sourceFile))
            {
                System.IO.File.Copy(sourceFile, fileName, true);
                MessageBox.Show("Restoration of database successful");
            }
            else
            {
                MessageBox.Show("File Doesn't Exist");
            }
        }
        // reorder report item click
        private void reOrderReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Re_OrderReport reOrder = new Re_OrderReport();
            reOrder.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadFormData();
        }

        private void purchaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(aCustomer.CustomerFirstName == null)
            {
                MessageBox.Show("Please lookup a customer");
            }
            else
            {
                CustomerPurchaseList purchHistory = new CustomerPurchaseList(aCustomer);
                purchHistory.ShowDialog();
                btnCustClear_Click(null, null);
            }
        }
    }
}
