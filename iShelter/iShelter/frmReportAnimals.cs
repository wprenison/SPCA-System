using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace iShelter
{
    public partial class frmReportAnimals : Form
    {
        string reportType;
        string date;
        public frmReportAnimals(string reportType)
        {
            InitializeComponent();
            this.reportType = reportType;
        }

        public frmReportAnimals(string reportType, string date)
        {
            InitializeComponent();
            this.reportType = reportType;
            this.date = date;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'Prog_Assignment3DataSet.tblAnimals' table. You can move, or remove it, as needed.          

            if (reportType == "Adopted")                 
                this.tblAnimalsTableAdapter.Fill(this.Prog_Assignment3DataSet.tblAnimals);
            else if (reportType == "Neutered")
            {
                this.Text = "Animals Not Neutered Report";
                this.tblAnimalsTableAdapter.FillByNotNeutered(this.Prog_Assignment3DataSet.tblAnimals);
            }
            else if(reportType == "Day")
            {
                this.Text = "Animals Proccessed on: " + date;
                this.tblAnimalsTableAdapter.FillByDayProcessed(this.Prog_Assignment3DataSet.tblAnimals, date);
            }
            else if(reportType == "Month")
            {
                this.Text = "Animals Proccessed in Month: " + date;
                this.tblAnimalsTableAdapter.FillByMonthProcessed(this.Prog_Assignment3DataSet.tblAnimals, int.Parse(date));
            }
            
            
            this.reportViewer1.RefreshReport();
        }
              
    }
}
