/*Glenn Larson 
 * Cis591 senior Project
 * Cycle Manager 
 * Update Employee Password Form*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Senior_Project
{
    public partial class UpEmpPasscs : Form
    {
        //decleration
        int empId;
        //constructor
        public UpEmpPasscs(int empId)
        {
            InitializeComponent();
            this.empId = empId;
        }
        //form load event
        private void UpEmpPasscs_Load(object sender, EventArgs e)
        {
            txtEmpID.Text = Convert.ToString(empId);
        }
        //cancel btn click event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //change btn click event
        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                Validation.validateStringAlphaNumeric(txtCurrentPassword.Text, "Current Password");
                Validation.validateStringAlphaNumeric(txtNewPassword.Text, "New Password");
                Validation.validateStringAlphaNumeric(txtConfirm.Text, "Password Confirmation");
                string submissionReport;
                Credintials aCredintial = new Credintials(empId, txtCurrentPassword.Text, txtNewPassword.Text, txtConfirm.Text);
                submissionReport = aCredintial.ChangePassword(aCredintial);
                this.Close();
                MessageBox.Show(submissionReport);
            }
            catch (FormatException er)
            {
                MessageBox.Show(er.Message +"\nPasswords Can any combination of A-Z, a-z, and 0-9");
            }
        }
       
    }
}
