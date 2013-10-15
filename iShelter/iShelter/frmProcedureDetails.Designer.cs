namespace iShelter
{
    partial class frmProcedureDetails
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
            this.lblCancel = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbSearchCategory = new System.Windows.Forms.ComboBox();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.lblAnimalID = new System.Windows.Forms.Label();
            this.txtbAnimalID = new System.Windows.Forms.TextBox();
            this.txtbProcedureID = new System.Windows.Forms.TextBox();
            this.lblProcedureID = new System.Windows.Forms.Label();
            this.txtbVetID = new System.Windows.Forms.TextBox();
            this.lblVetID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCancel
            // 
            this.lblCancel.Location = new System.Drawing.Point(12, 196);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(75, 23);
            this.lblCancel.TabIndex = 0;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.UseVisualStyleBackColor = true;
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(303, 196);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 1;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(138, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // cmbSearchCategory
            // 
            this.cmbSearchCategory.FormattingEnabled = true;
            this.cmbSearchCategory.Items.AddRange(new object[] {
            "Animals",
            "Procedures",
            "Vetenarians"});
            this.cmbSearchCategory.Location = new System.Drawing.Point(257, 13);
            this.cmbSearchCategory.Name = "cmbSearchCategory";
            this.cmbSearchCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbSearchCategory.TabIndex = 3;
            // 
            // txtbSearch
            // 
            this.txtbSearch.AccessibleDescription = "";
            this.txtbSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "Bob",
            "Bane",
            "Blaze"});
            this.txtbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbSearch.Location = new System.Drawing.Point(151, 13);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbSearch.Size = new System.Drawing.Size(100, 20);
            this.txtbSearch.TabIndex = 4;
            this.txtbSearch.Tag = "";
            // 
            // lblAnimalID
            // 
            this.lblAnimalID.AutoSize = true;
            this.lblAnimalID.Location = new System.Drawing.Point(13, 43);
            this.lblAnimalID.Name = "lblAnimalID";
            this.lblAnimalID.Size = new System.Drawing.Size(41, 13);
            this.lblAnimalID.TabIndex = 5;
            this.lblAnimalID.Text = "Animal:";
            // 
            // txtbAnimalID
            // 
            this.txtbAnimalID.Location = new System.Drawing.Point(78, 40);
            this.txtbAnimalID.Name = "txtbAnimalID";
            this.txtbAnimalID.ReadOnly = true;
            this.txtbAnimalID.Size = new System.Drawing.Size(39, 20);
            this.txtbAnimalID.TabIndex = 6;
            this.txtbAnimalID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbProcedureID
            // 
            this.txtbProcedureID.Location = new System.Drawing.Point(78, 66);
            this.txtbProcedureID.Name = "txtbProcedureID";
            this.txtbProcedureID.ReadOnly = true;
            this.txtbProcedureID.Size = new System.Drawing.Size(39, 20);
            this.txtbProcedureID.TabIndex = 8;
            this.txtbProcedureID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblProcedureID
            // 
            this.lblProcedureID.AutoSize = true;
            this.lblProcedureID.Location = new System.Drawing.Point(13, 69);
            this.lblProcedureID.Name = "lblProcedureID";
            this.lblProcedureID.Size = new System.Drawing.Size(59, 13);
            this.lblProcedureID.TabIndex = 7;
            this.lblProcedureID.Text = "Procedure:";
            // 
            // txtbVetID
            // 
            this.txtbVetID.Location = new System.Drawing.Point(78, 92);
            this.txtbVetID.Name = "txtbVetID";
            this.txtbVetID.ReadOnly = true;
            this.txtbVetID.Size = new System.Drawing.Size(39, 20);
            this.txtbVetID.TabIndex = 10;
            // 
            // lblVetID
            // 
            this.lblVetID.AutoSize = true;
            this.lblVetID.Location = new System.Drawing.Point(13, 95);
            this.lblVetID.Name = "lblVetID";
            this.lblVetID.Size = new System.Drawing.Size(61, 13);
            this.lblVetID.TabIndex = 9;
            this.lblVetID.Text = "Vetenarian:";
            // 
            // frmProcedureDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 222);
            this.Controls.Add(this.txtbVetID);
            this.Controls.Add(this.lblVetID);
            this.Controls.Add(this.txtbProcedureID);
            this.Controls.Add(this.lblProcedureID);
            this.Controls.Add(this.txtbAnimalID);
            this.Controls.Add(this.lblAnimalID);
            this.Controls.Add(this.txtbSearch);
            this.Controls.Add(this.cmbSearchCategory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.lblCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProcedureDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProcedureDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblCancel;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbSearchCategory;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.Label lblAnimalID;
        private System.Windows.Forms.TextBox txtbAnimalID;
        private System.Windows.Forms.TextBox txtbProcedureID;
        private System.Windows.Forms.Label lblProcedureID;
        private System.Windows.Forms.TextBox txtbVetID;
        private System.Windows.Forms.Label lblVetID;
    }
}