/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Help Form*/
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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.SendKeys.Send("{PGUP}");
            System.Windows.Forms.SendKeys.Send("{PGUP}");
            System.Windows.Forms.SendKeys.Send("{PGUP}");
        }

    }
}
