/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Credintials Class*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Senior_Project
{
    class Credintials
    {
        // declaration
        private bool loginPass;
        //constructors
        public Credintials()
        {

        }
        public Credintials(int empID, string password)
        {
            this.empID = empID;
            this.password = password;
            
        }
        public Credintials(int empID, string password, string newPassword, string confirmPassword)
        {
            this.empID = empID;
            this.password = password;
            this.newPassword = newPassword;
            this.confirmPassword = confirmPassword;

        }
        // attributes
        int empID;
        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }
        string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        string newPassword;
        public string NewPassword
        {
            get { return newPassword; }
            set { newPassword = value; }
        }
        string confirmPassword;
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { confirmPassword = value; }
        }
        string passCompare;
        public string PassCompare
        {
            get { return passCompare; }
            set { passCompare = value; }
        }
        //change password method
        public string ChangePassword(Credintials aCredintial)
        {
            string submissionReport;
            if (newPassword == confirmPassword)
            { 
                aCredintial = EmployeeDA.EmployeeLogin(aCredintial);
                if (password == PassCompare)
                {
                   submissionReport =  EmployeeDA.UpdatePassword(aCredintial);
                }
                else
                {
                    submissionReport = ("Incorrect Password Please Reenter");
                }

            }
            else
            {
                submissionReport = ("New Password doesn't match Please Reenter");
            }
            return submissionReport;
        }
        //login logout method
        public Boolean loginOrOut(Credintials aCredintial)
        {
            aCredintial = EmployeeDA.EmployeeLogin(aCredintial);
            if (password == passCompare)
            {
                loginPass = true;
            }
            else
            {
                loginPass = false;
            }
            return loginPass;
        }
    }
}
