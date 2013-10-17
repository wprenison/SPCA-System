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
    public partial class frmSearchRecord : Form
    {
        public frmSearchRecord(string frmChoice)
        {
            InitializeComponent();

            //Uses parameter recieved to decide what the frm does and which extra controls are shown
            if (frmChoice == "ProcedureDetails")
            {
                pnlProcedureDetails.Visible = true;
                cmbSearchCategory.Visible = true;
            }
            else if (frmChoice == "GuardianDetails")
            {
                pnlProcedureDetails.Visible = false;
                cmbSearchCategory.Visible = false;
                pnlSearch.Location = new System.Drawing.Point(0, -3);
                this.Size = new System.Drawing.Size(262, 254);
               // btnCancel.BringToFront();
                wmtxtbSearchTerm.WaterMarkText = "Search Name, Last Name, Tel No";

            }
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void frmProcedureDetails_Load(object sender, EventArgs e)
        {

        }

        private void cmbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchCategory.SelectedText == "Animals")
            {
                wmtxtbSearchTerm.WaterMarkText = "Search Animal ID, Animal Name";
            }
            else if (cmbSearchCategory.SelectedText == "Procedures")
            {
                wmtxtbSearchTerm.WaterMarkText = "Search Procedure ID, Procedure Name";
            }
            else if (cmbSearchCategory.SelectedText == "Vetenarians")
            {
                wmtxtbSearchTerm.WaterMarkText = "Search Vet ID, Vet Name, Vet Surname";
            }
        }
    }
}
