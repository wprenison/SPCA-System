namespace iShelter
{
    partial class frmGuardianDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuardianDetails));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtbFirstName = new System.Windows.Forms.TextBox();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtbAddress = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.mtxtTelNo = new System.Windows.Forms.MaskedTextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDob = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnGuardianExists = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtbFirstName
            // 
            this.txtbFirstName.Location = new System.Drawing.Point(89, 43);
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.Size = new System.Drawing.Size(134, 20);
            this.txtbFirstName.TabIndex = 1;
            this.txtbFirstName.TextChanged += new System.EventHandler(this.txtbFirstName_TextChanged);
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(89, 69);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(134, 20);
            this.txtbLastName.TabIndex = 3;
            this.txtbLastName.TextChanged += new System.EventHandler(this.txtbLastName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 72);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 124);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            // 
            // txtbAddress
            // 
            this.txtbAddress.Location = new System.Drawing.Point(89, 121);
            this.txtbAddress.Multiline = true;
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.Size = new System.Drawing.Size(134, 53);
            this.txtbAddress.TabIndex = 5;
            this.txtbAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(12, 98);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(42, 13);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Tel No:";
            // 
            // mtxtTelNo
            // 
            this.mtxtTelNo.Location = new System.Drawing.Point(89, 95);
            this.mtxtTelNo.Name = "mtxtTelNo";
            this.mtxtTelNo.Size = new System.Drawing.Size(134, 20);
            this.mtxtTelNo.TabIndex = 7;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(89, 184);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(134, 20);
            this.dtpDateOfBirth.TabIndex = 8;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(12, 187);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(71, 13);
            this.lblDob.TabIndex = 9;
            this.lblDob.Text = "Date Of Birth:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(148, 214);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 11;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnGuardianExists
            // 
            this.btnGuardianExists.Location = new System.Drawing.Point(15, 10);
            this.btnGuardianExists.Name = "btnGuardianExists";
            this.btnGuardianExists.Size = new System.Drawing.Size(208, 23);
            this.btnGuardianExists.TabIndex = 12;
            this.btnGuardianExists.Text = "Guardian Already Registered";
            this.btnGuardianExists.UseVisualStyleBackColor = true;
            this.btnGuardianExists.Click += new System.EventHandler(this.btnGuardianExists_Click);
            // 
            // frmGuardianDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 245);
            this.Controls.Add(this.btnGuardianExists);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.mtxtTelNo);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtbAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtbLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtbFirstName);
            this.Controls.Add(this.lblFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGuardianDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardian Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtbFirstName;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtbAddress;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.MaskedTextBox mtxtTelNo;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnGuardianExists;
    }
}