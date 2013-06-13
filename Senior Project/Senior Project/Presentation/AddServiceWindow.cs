//Glenn Larson
//CIS591 Senior Project
//Add Service to service Ticket Form

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
    public partial class AddServiceWindow : Form
    {
        //declare variables
        public ArrayList sList;
        private static Service aService;
        //constructor
        public AddServiceWindow()
        {
            InitializeComponent();
        }
        // cancel btn click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            aService = null;
            this.Close();
        }
        //form load event
        private void AddServiceWindow_Load(object sender, EventArgs e)
        {
            sList = Service.allServices();
            dgServices.DataSource = sList;
        }
        //add btn click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            aService = (Service)sList[dgServices.CurrentRow.Index];
            this.Hide();
        }
        // method to retrieve service from form.
        public Service GetService()
        {
            return aService;
        }
    }
}
