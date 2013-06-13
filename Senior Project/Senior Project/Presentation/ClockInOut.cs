/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Clock In out form*/
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
    public partial class ClockInOut : Form
    {
        //declaratiosn
        private int mode = 0;
        public ArrayList empList;
        Credintials empLogin;
        Employee aEmployee;
        //constructor
        public ClockInOut(int mode, ArrayList empList)
        {
            this.mode = mode;
            this.empList = empList;
            InitializeComponent();
        }
        // clock in out form load
        private void ClockInOut_Load(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                this.Text = "Clock-in";
                lblTitle.Text = "Employee Clock-In";
                btnContinue.Text = "Clock-in";

            }

            else if (mode == 100)
            {
                this.Text = "Clock-out";
                lblTitle.Text = "Employee Clock-Out";
                btnContinue.Text = "Clock-Out";
            }
            else
            {
                this.Text = "Error";
                lblTitle.Text = "Internal Error Please Try Again";
            }
        }
        //cancel btn click event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // continue btn click event
        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                Validation.validateNumeric(txtEmpId.Text, "Employee");
                Validation.validateNotBlank(txtPassword.Text, "Password");

                bool credCheck;
                if (mode == 1)
                {
                    empLogin = new Credintials(Convert.ToInt32(txtEmpId.Text), txtPassword.Text);
                    credCheck = empLogin.loginOrOut(empLogin);

                    if (credCheck == true)
                    {
                        aEmployee = Employee.FindEmployee(Convert.ToInt32(txtEmpId.Text));
                        empList.Add(aEmployee);
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Invalid Employee Number or Password");
                        txtPassword.Clear();
                    }

                }
                else if (mode == 100)
                {
                    empLogin = new Credintials(Convert.ToInt32(txtEmpId.Text), txtPassword.Text);
                    credCheck = empLogin.loginOrOut(empLogin);
                    if (credCheck == true)
                    {
                        int count = empList.Count;
                        int i = 0;
                        aEmployee = Employee.FindEmployee(Convert.ToInt32(txtEmpId.Text));
                        do
                        {
                            Employee emp = (Employee)empList[i];
                            if (aEmployee.EmployeeID == emp.EmployeeID)
                            {
                                empList.RemoveAt(i);
                                i = count - 1;
                            }
                            i++;
                        } while (i != count);
                        this.Hide();

                    }

                    else
                    {
                        MessageBox.Show("Invalid Employee Number Or Password");
                        txtPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                    this.Close();
                }
            }
            catch (FormatException er)
            {
                Console.WriteLine("error  " + er);
                MessageBox.Show(er.Message);
            }
            catch (Exception er)
            {
                Console.WriteLine("error  " + er);
                MessageBox.Show("There was an error please try again");
            }
        }
        //allows main form retrieve arraylist from form
        public ArrayList retrieveEmpList()
        {
            return empList;
        }

        private void ClockInOut_KeyPress(object sender, KeyPressEventArgs e)
            {
            {
                if (e.KeyChar == (char)13)
                {
                    btnContinue_Click(null, null);
                }
            }
        }
    }
}
