/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Employee Admin Form*/
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
    public partial class EmployeeAdmin : Form
    {
        // declare variables
        private char dollarSign = '$';
        private ArrayList empList;
        private Employee aEmployee;
        private string submissionReport = "";
        public EmployeeAdmin()
        {
            InitializeComponent();
        }
        //close btn click event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // create employee btn click
        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                Validation.validateStringAlpha(txtEmpFirst.Text, "Employee First Name");
                Validation.validateStringAlpha(txtEmpLast.Text, "Employee Last Name");
                Validation.validateStringAlphaNumericPeriod(txtEmpAddress1.Text, "Employee Address 1");
                Validation.validateStringAddress2(txtEmpAddress2.Text, "Employee Address 2");
                Validation.validateStringAlphaPeriod(txtEmpCity.Text, "City");
                Validation.validateStringAlpha(txtEmpState.Text, "State");
                Validation.validateNotBlank(txtEmpZip.Text, "Zip");
                Validation.validateNotBlank(txtEmpAreaCode.Text, "Area Code");
                Validation.validateNotBlank(txtEmpPhone.Text, "Phone Number");
                Validation.validateNotBlank(txtEmpPay.Text.Trim(dollarSign), "Employee Rate Pay");
                CreateEmployee();
                BuildEmployee();
                submissionReport = "";
                submissionReport = Employee.CreateEmployee(aEmployee);
                MessageReport(submissionReport);
                LoadFormData();
                ClearTextBoxes();
                 
            }
            catch (FormatException er)
            {
                MessageBox.Show(er.Message);
            }


        }
        // display message method
        private void MessageReport(string submissionReport)
        {
            MessageBox.Show(submissionReport);
        }
        //load form data method
        private void LoadFormData()
        {
            empList = new ArrayList();
            empList = Employee.AllEmployees();
            dgEmployeeList.DataSource = empList;
        }
        // form load event
        private void EmployeeAdmin_Load(object sender, EventArgs e)
        {
            LoadFormData();
        }
        // populate text boxes method
        private void PopTextBoxes()
        {
            txtEmpNum.Text = Convert.ToString(aEmployee.EmployeeID);
            txtEmpFirst.Text = aEmployee.EmployeeFirstName;
            txtEmpLast.Text = aEmployee.EmployeeLastName;
            txtEmpAddress1.Text = aEmployee.EmployeeAddress1;
            txtEmpAddress2.Text = aEmployee.EmployeeAddress2;
            txtEmpCity.Text = aEmployee.EmployeeCity;
            txtEmpState.Text = aEmployee.EmployeeState;
            txtEmpZip.Text = Convert.ToString(aEmployee.EmployeeZip);
            txtEmpAreaCode.Text = aEmployee.EmployeeAreaCode;
            txtEmpPhone.Text = aEmployee.EmployeePhone;
            txtEmpPay.Mask = null;
            txtEmpPay.Text = String.Format("{0:C}", aEmployee.EmployeePayRate);

        }
        // create employee object
        private void CreateEmployee()
        {
            aEmployee = new Employee();
        }
        // set emoployee number method
        private void SetEmployeeNumber()
        {
            try
            {
                aEmployee.EmployeeID = Convert.ToInt32(txtEmpNum.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Select An Employee to Update");
            }
        }
        // build employee object
        private void BuildEmployee()
        {
                aEmployee.EmployeeFirstName = txtEmpFirst.Text;
                aEmployee.EmployeeLastName = txtEmpLast.Text;
                aEmployee.EmployeeAddress1 = txtEmpAddress1.Text;
                aEmployee.EmployeeAddress2 = txtEmpAddress2.Text;
                aEmployee.EmployeeCity = txtEmpCity.Text;
                aEmployee.EmployeeState = txtEmpState.Text;
                aEmployee.EmployeeZip = Convert.ToInt32(txtEmpZip.Text);
                aEmployee.EmployeeAreaCode = txtEmpAreaCode.Text;
                aEmployee.EmployeePhone = txtEmpPhone.Text;
                aEmployee.EmployeePayRate = Convert.ToDouble(txtEmpPay.Text.Trim(dollarSign));
        }
        // data grid slection changed method
        private void dgEmployeeList_SelectionChanged(object sender, EventArgs e)
        {
            aEmployee = new Employee();
            aEmployee = (Employee)empList[dgEmployeeList.CurrentRow.Index];
            PopTextBoxes();

        }
        // delete btn click event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int empNum = Convert.ToInt32(txtEmpNum.Text);
                submissionReport = Employee.DeleteEmployee(empNum);
                MessageReport(submissionReport);
                LoadFormData();
                ClearTextBoxes();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Select an Employee to Delete");
            }
        }
        //update employee btn click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Validation.validateStringAlpha(txtEmpFirst.Text, "Employee First Name");
                Validation.validateStringAlpha(txtEmpLast.Text, "Employee Last Name");
                Validation.validateStringAlphaNumericPeriod(txtEmpAddress1.Text, "Employee Address 1");
                Validation.validateStringAddress2(txtEmpAddress2.Text, "Employee Address 2");
                Validation.validateStringAlphaPeriod(txtEmpCity.Text, "City");
                Validation.validateStringAlpha(txtEmpState.Text, "State");
                Validation.validateNotBlank(txtEmpZip.Text, "Zip");
                Validation.validateNotBlank(txtEmpAreaCode.Text, "Area Code");
                Validation.validateNotBlank(txtEmpPhone.Text, "Phone Number");
                Validation.validateNotBlank(txtEmpPay.Text.Trim(dollarSign), "Employee Rate Pay");
                CreateEmployee();
                SetEmployeeNumber();
                BuildEmployee();
                submissionReport = "";
                submissionReport = Employee.UpdateEmployee(aEmployee);
                MessageReport(submissionReport);
                LoadFormData();
                ClearTextBoxes();
            }
            catch (FormatException er)
            {
                MessageBox.Show(er.Message);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please Select Employee To Update");
            }
            catch (Exception)
            {

            }
        }
        // change employee password btn click
        private void btnUpEmpPass_Click(object sender, EventArgs e)
        {
            try
            {
                UpEmpPasscs passForm = new UpEmpPasscs(Convert.ToInt32(txtEmpNum.Text));
                passForm.ShowDialog();
            }
            catch(FormatException )
            {
                MessageBox.Show("Please Select an Employee");
            }
        }
        // clear text boxes mthd
        private void ClearTextBoxes()
        {
            txtEmpNum.Clear();
            txtEmpFirst.Clear();
            txtEmpLast.Clear();
            txtEmpAddress1.Clear();
            txtEmpAddress2.Clear();
            txtEmpCity.Clear();
            txtEmpState.Clear();
            txtEmpZip.Clear();
            txtEmpAreaCode.Clear();
            txtEmpPhone.Clear();
            txtEmpPay.Clear();
            txtEmpPay.Mask = "$##.##";
        }
        // clear form btn click
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
