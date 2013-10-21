namespace iShelter
{
    partial class frmReportAnimals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// If there is an error by dataset and the tableAdapter just remove iShelter. (This gets regenerated whenever the form or data set is modified
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportAnimals));
            this.tblAnimalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Prog_Assignment3DataSet = new Prog_Assignment3DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblAnimalsTableAdapter = new Prog_Assignment3DataSetTableAdapters.tblAnimalsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnimalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prog_Assignment3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblAnimalsBindingSource
            // 
            this.tblAnimalsBindingSource.DataMember = "tblAnimals";
            this.tblAnimalsBindingSource.DataSource = this.Prog_Assignment3DataSet;
            // 
            // Prog_Assignment3DataSet
            // 
            this.Prog_Assignment3DataSet.DataSetName = "Prog_Assignment3DataSet";
            this.Prog_Assignment3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReports";
            reportDataSource1.Value = this.tblAnimalsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "iShelter.ReportAnimals.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(635, 391);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblAnimalsTableAdapter
            // 
            this.tblAnimalsTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 391);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportAnimals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adopted Animal Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblAnimalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prog_Assignment3DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblAnimalsBindingSource;
        private Prog_Assignment3DataSet Prog_Assignment3DataSet;
        private Prog_Assignment3DataSetTableAdapters.tblAnimalsTableAdapter tblAnimalsTableAdapter;

    }
}