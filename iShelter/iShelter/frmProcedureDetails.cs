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
    public partial class frmProcedureDetails : Form
    {
        public frmProcedureDetails()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
