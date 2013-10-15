using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iShelter
{
    public partial class frmGuardianDetails : Form
    {
        public frmGuardianDetails()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            //Code for storing guardian details to db goes here
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
