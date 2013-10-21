namespace iShelter
{
    partial class frmReportDates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportDates));
            this.lblInstructionMsg = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.cmbMonths = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblInstructionMsg
            // 
            this.lblInstructionMsg.AutoSize = true;
            this.lblInstructionMsg.Location = new System.Drawing.Point(12, 24);
            this.lblInstructionMsg.Name = "lblInstructionMsg";
            this.lblInstructionMsg.Size = new System.Drawing.Size(289, 13);
            this.lblInstructionMsg.TabIndex = 0;
            this.lblInstructionMsg.Text = "Please select a day you would like to generate the report for\r\n";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(153, 76);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dtpDay
            // 
            this.dtpDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDay.Location = new System.Drawing.Point(132, 50);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(121, 20);
            this.dtpDay.TabIndex = 3;
            // 
            // cmbMonths
            // 
            this.cmbMonths.FormattingEnabled = true;
            this.cmbMonths.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonths.Location = new System.Drawing.Point(132, 49);
            this.cmbMonths.Name = "cmbMonths";
            this.cmbMonths.Size = new System.Drawing.Size(121, 21);
            this.cmbMonths.TabIndex = 4;
            // 
            // frmReportDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 104);
            this.Controls.Add(this.cmbMonths);
            this.Controls.Add(this.dtpDay);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblInstructionMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportDates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Dates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructionMsg;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.ComboBox cmbMonths;
    }
}