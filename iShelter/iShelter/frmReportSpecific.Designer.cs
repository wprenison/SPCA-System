namespace iShelter
{
    partial class frmReportSpecific
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
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenPDF = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.picbAnimal = new System.Windows.Forms.PictureBox();
            this.wmtxtbSearchTerm = new wmgCMS.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenPDF
            // 
            this.btnGenPDF.Location = new System.Drawing.Point(365, 154);
            this.btnGenPDF.Name = "btnGenPDF";
            this.btnGenPDF.Size = new System.Drawing.Size(75, 23);
            this.btnGenPDF.TabIndex = 1;
            this.btnGenPDF.Text = "Generate PDF";
            this.btnGenPDF.UseVisualStyleBackColor = true;
            this.btnGenPDF.Click += new System.EventHandler(this.btnGenPDF_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(12, 41);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(344, 150);
            this.dgvReport.TabIndex = 2;
            this.dgvReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellClick);
            // 
            // picbAnimal
            // 
            this.picbAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbAnimal.Location = new System.Drawing.Point(362, 74);
            this.picbAnimal.Name = "picbAnimal";
            this.picbAnimal.Size = new System.Drawing.Size(82, 74);
            this.picbAnimal.TabIndex = 19;
            this.picbAnimal.TabStop = false;
            // 
            // wmtxtbSearchTerm
            // 
            this.wmtxtbSearchTerm.AutoCompleteCustomSource.AddRange(new string[] {
            "Bob",
            "Bane",
            "Blaze"});
            this.wmtxtbSearchTerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.wmtxtbSearchTerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.wmtxtbSearchTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.wmtxtbSearchTerm.Location = new System.Drawing.Point(12, 15);
            this.wmtxtbSearchTerm.Name = "wmtxtbSearchTerm";
            this.wmtxtbSearchTerm.Size = new System.Drawing.Size(239, 20);
            this.wmtxtbSearchTerm.TabIndex = 20;
            this.wmtxtbSearchTerm.WaterMarkColor = System.Drawing.Color.Gray;
            this.wmtxtbSearchTerm.WaterMarkText = "Search Animal ID, Name";
            this.wmtxtbSearchTerm.TextChanged += new System.EventHandler(this.wmtxtbSearchTerm_TextChanged);
            // 
            // frmReportTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 203);
            this.Controls.Add(this.wmtxtbSearchTerm);
            this.Controls.Add(this.picbAnimal);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnGenPDF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReportTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportTest";
            this.Load += new System.EventHandler(this.frmReportTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenPDF;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.PictureBox picbAnimal;
        private wmgCMS.WaterMarkTextBox wmtxtbSearchTerm;

    }
}