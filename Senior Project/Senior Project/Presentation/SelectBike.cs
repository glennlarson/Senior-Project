//Glenn Larson
//CIS591 Senior Project
//Select Bike Form Code


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
    public partial class SelectBike : Form
    {
        //declarations
        private int custID;
        private ArrayList custBikeList;
        private static CBike cBike;
        //constructor
        public SelectBike(int custID)
        {
            InitializeComponent();
            this.custID = custID;
        }
        // cancel btn click event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // newbike btn click event
        private void btnNewBike_Click(object sender, EventArgs e)
        {
            NewCustomerBike custBike = new NewCustomerBike(custID);
            custBike.ShowDialog();
            LoadFormData();

        }
        // load form data method
        private void LoadFormData()
        {
            custBikeList = new ArrayList();
            custBikeList = CBike.CustBikes(custID);
            loadDataGrid();
        }
        // form load event
        private void SelectBike_Load(object sender, EventArgs e)
        {
            LoadFormData();
        }
        //load data grid datasource
        private void loadDataGrid()
        {
            dgCustBikes.DataSource = custBikeList;
        }
        // data grid click event
        private void dgCustBikes_Click(object sender, EventArgs e)
        {
            if (custBikeList.Count != 0)
            {
                cBike = new CBike();
                cBike = (CBike)custBikeList[dgCustBikes.CurrentRow.Index];
            }
        }
        // get bike method for calling form to retieve selected bike
        public CBike RetrieveBike()
        {
            return cBike;
        }
        // select btn click event
        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
