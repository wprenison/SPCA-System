namespace iShelter
{
    partial class frmEditDel
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
            this.dgvEditDel = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.wmtxtbSearchTerm = new wmgCMS.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditDel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEditDel
            // 
            this.dgvEditDel.AllowUserToAddRows = false;
            this.dgvEditDel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEditDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditDel.Location = new System.Drawing.Point(12, 37);
            this.dgvEditDel.Name = "dgvEditDel";
            this.dgvEditDel.Size = new System.Drawing.Size(941, 329);
            this.dgvEditDel.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(878, 372);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // wmtxtbSearchTerm
            // 
            this.wmtxtbSearchTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.wmtxtbSearchTerm.Location = new System.Drawing.Point(12, 13);
            this.wmtxtbSearchTerm.Name = "wmtxtbSearchTerm";
            this.wmtxtbSearchTerm.Size = new System.Drawing.Size(294, 20);
            this.wmtxtbSearchTerm.TabIndex = 3;
            this.wmtxtbSearchTerm.WaterMarkColor = System.Drawing.Color.Gray;
            this.wmtxtbSearchTerm.WaterMarkText = "Search";
            this.wmtxtbSearchTerm.TextChanged += new System.EventHandler(this.waterMarkTextBox1_TextChanged);
            // 
            // frmEditDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 407);
            this.Controls.Add(this.wmtxtbSearchTerm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvEditDel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEditDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditDel";
            this.Load += new System.EventHandler(this.frmEditDel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEditDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private wmgCMS.WaterMarkTextBox wmtxtbSearchTerm;
    }
}