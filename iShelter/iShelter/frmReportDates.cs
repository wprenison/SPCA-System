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
    public partial class frmReportDates : Form
    {
        string reqSelection;

        public frmReportDates(string reqSelection)
        {
            InitializeComponent();
            this.reqSelection = reqSelection;
            if (reqSelection == "Month")
            {
                lblInstructionMsg.Text = "Please select a Month you would like to generate the report for:";
                dtpDay.Visible = false;
                cmbMonths.Visible = true;
            }
            else if (reqSelection == "Day")
            {
                lblInstructionMsg.Text = "Please select a day you would like to generate the report for:";
                dtpDay.Visible = true;
                cmbMonths.Visible = false;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (reqSelection == "Month")
            {                
                frmReportAnimals report = new frmReportAnimals("Month", "" + (cmbMonths.SelectedIndex + 1));
                report.Show();
            }
            else if (reqSelection == "Day")
            {
                frmReportAnimals report = new frmReportAnimals("Day", dtpDay.Value.ToShortDateString());
                report.Show();
            }
        }
    }
}
