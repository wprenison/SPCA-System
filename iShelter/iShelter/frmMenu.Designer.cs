namespace iShelter
{
    partial class frmMenu
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
            this.btnGuardian = new System.Windows.Forms.Button();
            this.btnProcedure = new System.Windows.Forms.Button();
            this.btnAdopt = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardian
            // 
            this.btnGuardian.Location = new System.Drawing.Point(18, 26);
            this.btnGuardian.Name = "btnGuardian";
            this.btnGuardian.Size = new System.Drawing.Size(75, 23);
            this.btnGuardian.TabIndex = 0;
            this.btnGuardian.Text = "Guardian";
            this.btnGuardian.UseVisualStyleBackColor = true;
            this.btnGuardian.Click += new System.EventHandler(this.btnGuardian_Click);
            // 
            // btnProcedure
            // 
            this.btnProcedure.Location = new System.Drawing.Point(97, 26);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(75, 23);
            this.btnProcedure.TabIndex = 1;
            this.btnProcedure.Text = "Procedure";
            this.btnProcedure.UseVisualStyleBackColor = true;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // btnAdopt
            // 
            this.btnAdopt.Location = new System.Drawing.Point(178, 26);
            this.btnAdopt.Name = "btnAdopt";
            this.btnAdopt.Size = new System.Drawing.Size(75, 23);
            this.btnAdopt.TabIndex = 2;
            this.btnAdopt.Text = "Adopt";
            this.btnAdopt.UseVisualStyleBackColor = true;
            this.btnAdopt.Click += new System.EventHandler(this.btnAdopt_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(97, 55);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 86);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdopt);
            this.Controls.Add(this.btnProcedure);
            this.Controls.Add(this.btnGuardian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardian;
        private System.Windows.Forms.Button btnProcedure;
        private System.Windows.Forms.Button btnAdopt;
        private System.Windows.Forms.Button btnCancel;
    }
}