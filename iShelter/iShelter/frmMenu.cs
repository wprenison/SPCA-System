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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnAdopt_Click(object sender, EventArgs e)
        {
            //DialogResult result = DialogResult.OK;
            this.Dispose();
        }

        private void btnGuardian_Click(object sender, EventArgs e)
        {
            //Hides the menu and displays frmGuardianDetails
            frmGuardianDetails guardian = new frmGuardianDetails();
            //this.Visible = false;
            DialogResult result = guardian.ShowDialog();
            //this.Visible = true;

            //frmGuardianDetails returns a value if this value is "OK" then the guardian button gets disabled to prevent 
            //another guardian entry for the same animal
            if (result == DialogResult.OK)
                btnGuardian.Enabled = false;
           
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            frmProcedureDetails procedure = new frmProcedureDetails();
            //this.Visible = false;
            DialogResult result = procedure.ShowDialog();
            //this.Visible = true;

            //frmProcedureDetails returns a value if this value is "OK" then the procedurebutton gets disabled to prevent 
            //another guardian entry for the same animal
            if (result == DialogResult.OK)
                btnProcedure.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
