namespace iShelter
{
    partial class frmSearchRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchRecord));
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlProcedureDetails = new System.Windows.Forms.Panel();
            this.picbAnimal = new System.Windows.Forms.PictureBox();
            this.txtbVetID = new System.Windows.Forms.TextBox();
            this.lblVetID = new System.Windows.Forms.Label();
            this.txtbProcedureID = new System.Windows.Forms.TextBox();
            this.lblProcedureID = new System.Windows.Forms.Label();
            this.txtbAnimalID = new System.Windows.Forms.TextBox();
            this.lblAnimalID = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cmbSearchCategory = new System.Windows.Forms.ComboBox();
            this.dgvSearchTbl = new System.Windows.Forms.DataGridView();
            this.btnProceed = new System.Windows.Forms.Button();
            this.wmtxtbSearchTerm = new wmgCMS.WaterMarkTextBox();
            this.pnlProcedureDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbAnimal)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // pnlProcedureDetails
            // 
            this.pnlProcedureDetails.Controls.Add(this.picbAnimal);
            this.pnlProcedureDetails.Controls.Add(this.txtbVetID);
            this.pnlProcedureDetails.Controls.Add(this.lblVetID);
            this.pnlProcedureDetails.Controls.Add(this.txtbProcedureID);
            this.pnlProcedureDetails.Controls.Add(this.lblProcedureID);
            this.pnlProcedureDetails.Controls.Add(this.txtbAnimalID);
            this.pnlProcedureDetails.Controls.Add(this.lblAnimalID);
            this.pnlProcedureDetails.Location = new System.Drawing.Point(-3, 14);
            this.pnlProcedureDetails.Name = "pnlProcedureDetails";
            this.pnlProcedureDetails.Size = new System.Drawing.Size(135, 176);
            this.pnlProcedureDetails.TabIndex = 13;
            // 
            // picbAnimal
            // 
            this.picbAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbAnimal.Location = new System.Drawing.Point(28, 12);
            this.picbAnimal.Name = "picbAnimal";
            this.picbAnimal.Size = new System.Drawing.Size(82, 74);
            this.picbAnimal.TabIndex = 18;
            this.picbAnimal.TabStop = false;
            // 
            // txtbVetID
            // 
            this.txtbVetID.Location = new System.Drawing.Point(80, 144);
            this.txtbVetID.Name = "txtbVetID";
            this.txtbVetID.ReadOnly = true;
            this.txtbVetID.Size = new System.Drawing.Size(39, 20);
            this.txtbVetID.TabIndex = 17;
            // 
            // lblVetID
            // 
            this.lblVetID.AutoSize = true;
            this.lblVetID.Location = new System.Drawing.Point(15, 147);
            this.lblVetID.Name = "lblVetID";
            this.lblVetID.Size = new System.Drawing.Size(61, 13);
            this.lblVetID.TabIndex = 16;
            this.lblVetID.Text = "Vetenarian:";
            // 
            // txtbProcedureID
            // 
            this.txtbProcedureID.Location = new System.Drawing.Point(80, 118);
            this.txtbProcedureID.Name = "txtbProcedureID";
            this.txtbProcedureID.ReadOnly = true;
            this.txtbProcedureID.Size = new System.Drawing.Size(39, 20);
            this.txtbProcedureID.TabIndex = 15;
            // 
            // lblProcedureID
            // 
            this.lblProcedureID.AutoSize = true;
            this.lblProcedureID.Location = new System.Drawing.Point(15, 121);
            this.lblProcedureID.Name = "lblProcedureID";
            this.lblProcedureID.Size = new System.Drawing.Size(59, 13);
            this.lblProcedureID.TabIndex = 14;
            this.lblProcedureID.Text = "Procedure:";
            // 
            // txtbAnimalID
            // 
            this.txtbAnimalID.Location = new System.Drawing.Point(80, 92);
            this.txtbAnimalID.Name = "txtbAnimalID";
            this.txtbAnimalID.ReadOnly = true;
            this.txtbAnimalID.Size = new System.Drawing.Size(39, 20);
            this.txtbAnimalID.TabIndex = 13;
            // 
            // lblAnimalID
            // 
            this.lblAnimalID.AutoSize = true;
            this.lblAnimalID.Location = new System.Drawing.Point(15, 95);
            this.lblAnimalID.Name = "lblAnimalID";
            this.lblAnimalID.Size = new System.Drawing.Size(41, 13);
            this.lblAnimalID.TabIndex = 12;
            this.lblAnimalID.Text = "Animal:";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.wmtxtbSearchTerm);
            this.pnlSearch.Controls.Add(this.cmbSearchCategory);
            this.pnlSearch.Controls.Add(this.dgvSearchTbl);
            this.pnlSearch.Controls.Add(this.btnProceed);
            this.pnlSearch.Location = new System.Drawing.Point(138, -3);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(383, 231);
            this.pnlSearch.TabIndex = 14;
            // 
            // cmbSearchCategory
            // 
            this.cmbSearchCategory.FormattingEnabled = true;
            this.cmbSearchCategory.Items.AddRange(new object[] {
            "Animals",
            "Procedures",
            "Vetenarians"});
            this.cmbSearchCategory.Location = new System.Drawing.Point(251, 9);
            this.cmbSearchCategory.Name = "cmbSearchCategory";
            this.cmbSearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbSearchCategory.TabIndex = 15;
            this.cmbSearchCategory.SelectedIndexChanged += new System.EventHandler(this.cmbSearchCategory_SelectedIndexChanged);
            // 
            // dgvSearchTbl
            // 
            this.dgvSearchTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSearchTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchTbl.Location = new System.Drawing.Point(6, 35);
            this.dgvSearchTbl.MultiSelect = false;
            this.dgvSearchTbl.Name = "dgvSearchTbl";
            this.dgvSearchTbl.ReadOnly = true;
            this.dgvSearchTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchTbl.Size = new System.Drawing.Size(366, 150);
            this.dgvSearchTbl.TabIndex = 14;
            this.dgvSearchTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchTbl_CellClick);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(297, 199);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 13;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
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
            this.wmtxtbSearchTerm.Location = new System.Drawing.Point(6, 9);
            this.wmtxtbSearchTerm.Name = "wmtxtbSearchTerm";
            this.wmtxtbSearchTerm.Size = new System.Drawing.Size(239, 20);
            this.wmtxtbSearchTerm.TabIndex = 16;
            this.wmtxtbSearchTerm.WaterMarkColor = System.Drawing.Color.Gray;
            this.wmtxtbSearchTerm.WaterMarkText = "Search";
            // 
            // frmSearchRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 225);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlProcedureDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearchRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procedure Details";
            this.Load += new System.EventHandler(this.frmProcedureDetails_Load);
            this.pnlProcedureDetails.ResumeLayout(false);
            this.pnlProcedureDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbAnimal)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlProcedureDetails;
        private System.Windows.Forms.PictureBox picbAnimal;
        private System.Windows.Forms.TextBox txtbVetID;
        private System.Windows.Forms.Label lblVetID;
        private System.Windows.Forms.TextBox txtbProcedureID;
        private System.Windows.Forms.Label lblProcedureID;
        private System.Windows.Forms.TextBox txtbAnimalID;
        private System.Windows.Forms.Label lblAnimalID;
        private System.Windows.Forms.Panel pnlSearch;
        private wmgCMS.WaterMarkTextBox wmtxtbSearchTerm;
        private System.Windows.Forms.ComboBox cmbSearchCategory;
        private System.Windows.Forms.DataGridView dgvSearchTbl;
        private System.Windows.Forms.Button btnProceed;
    }
}