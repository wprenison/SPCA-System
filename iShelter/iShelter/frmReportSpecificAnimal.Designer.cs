namespace iShelter
{
    partial class frmReportSpecificAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportSpecificAnimal));
            this.wmtxtbSearchTerm = new wmgCMS.WaterMarkTextBox();
            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.picbAnimal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbAnimal)).BeginInit();
            this.SuspendLayout();
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
            this.wmtxtbSearchTerm.Location = new System.Drawing.Point(94, 19);
            this.wmtxtbSearchTerm.Name = "wmtxtbSearchTerm";
            this.wmtxtbSearchTerm.Size = new System.Drawing.Size(113, 20);
            this.wmtxtbSearchTerm.TabIndex = 15;
            this.wmtxtbSearchTerm.WaterMarkColor = System.Drawing.Color.Gray;
            this.wmtxtbSearchTerm.WaterMarkText = "Search ID, Name";
            // 
            // dgvAnimals
            // 
            this.dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimals.Location = new System.Drawing.Point(94, 45);
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.Size = new System.Drawing.Size(240, 150);
            this.dgvAnimals.TabIndex = 13;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(239, 199);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(95, 23);
            this.btnGenerate.TabIndex = 16;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // picbAnimal
            // 
            this.picbAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbAnimal.Location = new System.Drawing.Point(6, 45);
            this.picbAnimal.Name = "picbAnimal";
            this.picbAnimal.Size = new System.Drawing.Size(82, 74);
            this.picbAnimal.TabIndex = 17;
            this.picbAnimal.TabStop = false;
            // 
            // frmReportSpecificAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 234);
            this.Controls.Add(this.picbAnimal);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.wmtxtbSearchTerm);
            this.Controls.Add(this.dgvAnimals);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportSpecificAnimal";
            this.Text = "Report fo a specific Animal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private wmgCMS.WaterMarkTextBox wmtxtbSearchTerm;
        private System.Windows.Forms.DataGridView dgvAnimals;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox picbAnimal;
    }
}