﻿namespace iShelter
{
    partial class iShelter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iShelter));
            this.mnsAnimal = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuardians = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiEditGuardians = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnimals = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiEditAnimals = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcedures = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiRecordProcedure = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiEditProcedure = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiAnimals = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiSpecificAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiAdopted = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiNotNuetered = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiProcessedPer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiDay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiGuardians = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiSpecificGuardian = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiProcedures = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.picbAnimal = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.txtbBreed = new System.Windows.Forms.TextBox();
            this.lblBreed = new System.Windows.Forms.Label();
            this.txtbIllnesses = new System.Windows.Forms.TextBox();
            this.lblIllnesses = new System.Windows.Forms.Label();
            this.txtbInjuries = new System.Windows.Forms.TextBox();
            this.lblInjuries = new System.Windows.Forms.Label();
            this.txtbNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.mtxtRoomNo = new System.Windows.Forms.MaskedTextBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.mtxtAge = new System.Windows.Forms.MaskedTextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnTakePic = new System.Windows.Forms.Button();
            this.grpbGender = new System.Windows.Forms.GroupBox();
            this.rabF = new System.Windows.Forms.RadioButton();
            this.rabM = new System.Windows.Forms.RadioButton();
            this.btnProceed = new System.Windows.Forms.Button();
            this.lblAgroRating = new System.Windows.Forms.Label();
            this.nudAgroRating = new System.Windows.Forms.NumericUpDown();
            this.picbAgroRatingInfo = new System.Windows.Forms.PictureBox();
            this.ttAgroRatingInfo = new System.Windows.Forms.ToolTip(this.components);
            this.cbNuetered = new System.Windows.Forms.CheckBox();
            this.mnsAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbAnimal)).BeginInit();
            this.grpbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgroRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbAgroRatingInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsAnimal
            // 
            this.mnsAnimal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuGuardians,
            this.mnuAnimals,
            this.mnuProcedures,
            this.mnuReports,
            this.mnuHelp});
            this.mnsAnimal.Location = new System.Drawing.Point(0, 0);
            this.mnsAnimal.Name = "mnsAnimal";
            this.mnsAnimal.Size = new System.Drawing.Size(359, 24);
            this.mnsAnimal.TabIndex = 0;
            this.mnsAnimal.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuiExit
            // 
            this.mnuiExit.Name = "mnuiExit";
            this.mnuiExit.Size = new System.Drawing.Size(92, 22);
            this.mnuiExit.Text = "Exit";
            this.mnuiExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuGuardians
            // 
            this.mnuGuardians.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiEditGuardians});
            this.mnuGuardians.Name = "mnuGuardians";
            this.mnuGuardians.Size = new System.Drawing.Size(72, 20);
            this.mnuGuardians.Text = "Guardians";
            // 
            // mnuiEditGuardians
            // 
            this.mnuiEditGuardians.Name = "mnuiEditGuardians";
            this.mnuiEditGuardians.Size = new System.Drawing.Size(172, 22);
            this.mnuiEditGuardians.Text = "Edit\\Del Guardians";
            // 
            // mnuAnimals
            // 
            this.mnuAnimals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiEditAnimals});
            this.mnuAnimals.Name = "mnuAnimals";
            this.mnuAnimals.Size = new System.Drawing.Size(62, 20);
            this.mnuAnimals.Text = "Animals";
            // 
            // mnuiEditAnimals
            // 
            this.mnuiEditAnimals.Name = "mnuiEditAnimals";
            this.mnuiEditAnimals.Size = new System.Drawing.Size(162, 22);
            this.mnuiEditAnimals.Text = "Edit/Del Animals";
            // 
            // mnuProcedures
            // 
            this.mnuProcedures.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiRecordProcedure,
            this.mnuiEditProcedure});
            this.mnuProcedures.Name = "mnuProcedures";
            this.mnuProcedures.Size = new System.Drawing.Size(78, 20);
            this.mnuProcedures.Text = "Procedures";
            // 
            // mnuiRecordProcedure
            // 
            this.mnuiRecordProcedure.Name = "mnuiRecordProcedure";
            this.mnuiRecordProcedure.Size = new System.Drawing.Size(173, 22);
            this.mnuiRecordProcedure.Text = "Record Procedure";
            this.mnuiRecordProcedure.Click += new System.EventHandler(this.mnuiRecordProcedure_Click);
            // 
            // mnuiEditProcedure
            // 
            this.mnuiEditProcedure.Name = "mnuiEditProcedure";
            this.mnuiEditProcedure.Size = new System.Drawing.Size(173, 22);
            this.mnuiEditProcedure.Text = "Edit\\Del Procedure";
            // 
            // mnuReports
            // 
            this.mnuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiAnimals,
            this.mnuiGuardians,
            this.mnuiProcedures});
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(59, 20);
            this.mnuReports.Text = "Reports";
            // 
            // mnuiAnimals
            // 
            this.mnuiAnimals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiSpecificAnimal,
            this.mnuiAdopted,
            this.mnuiNotNuetered,
            this.mnuiProcessedPer});
            this.mnuiAnimals.Name = "mnuiAnimals";
            this.mnuiAnimals.Size = new System.Drawing.Size(133, 22);
            this.mnuiAnimals.Text = "Animals";
            // 
            // mnuiSpecificAnimal
            // 
            this.mnuiSpecificAnimal.Name = "mnuiSpecificAnimal";
            this.mnuiSpecificAnimal.Size = new System.Drawing.Size(190, 22);
            this.mnuiSpecificAnimal.Text = "Specific Animal";
            // 
            // mnuiAdopted
            // 
            this.mnuiAdopted.Name = "mnuiAdopted";
            this.mnuiAdopted.Size = new System.Drawing.Size(190, 22);
            this.mnuiAdopted.Text = "Adopted";
            // 
            // mnuiNotNuetered
            // 
            this.mnuiNotNuetered.Name = "mnuiNotNuetered";
            this.mnuiNotNuetered.Size = new System.Drawing.Size(190, 22);
            this.mnuiNotNuetered.Text = "Not Nuetered";
            // 
            // mnuiProcessedPer
            // 
            this.mnuiProcessedPer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiMonth,
            this.mnuiWeek,
            this.mnuiDay});
            this.mnuiProcessedPer.Name = "mnuiProcessedPer";
            this.mnuiProcessedPer.Size = new System.Drawing.Size(190, 22);
            this.mnuiProcessedPer.Text = "Processed per specific";
            // 
            // mnuiMonth
            // 
            this.mnuiMonth.Name = "mnuiMonth";
            this.mnuiMonth.Size = new System.Drawing.Size(110, 22);
            this.mnuiMonth.Text = "Month";
            // 
            // mnuiWeek
            // 
            this.mnuiWeek.Name = "mnuiWeek";
            this.mnuiWeek.Size = new System.Drawing.Size(110, 22);
            this.mnuiWeek.Text = "Week";
            // 
            // mnuiDay
            // 
            this.mnuiDay.Name = "mnuiDay";
            this.mnuiDay.Size = new System.Drawing.Size(110, 22);
            this.mnuiDay.Text = "Day";
            // 
            // mnuiGuardians
            // 
            this.mnuiGuardians.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiSpecificGuardian});
            this.mnuiGuardians.Name = "mnuiGuardians";
            this.mnuiGuardians.Size = new System.Drawing.Size(133, 22);
            this.mnuiGuardians.Text = "Guardians";
            // 
            // mnuiSpecificGuardian
            // 
            this.mnuiSpecificGuardian.Name = "mnuiSpecificGuardian";
            this.mnuiSpecificGuardian.Size = new System.Drawing.Size(166, 22);
            this.mnuiSpecificGuardian.Text = "Specific Guardian";
            // 
            // mnuiProcedures
            // 
            this.mnuiProcedures.Name = "mnuiProcedures";
            this.mnuiProcedures.Size = new System.Drawing.Size(133, 22);
            this.mnuiProcedures.Text = "Procedures";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiAbout,
            this.mnuiHelp});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuiAbout
            // 
            this.mnuiAbout.Name = "mnuiAbout";
            this.mnuiAbout.Size = new System.Drawing.Size(114, 22);
            this.mnuiAbout.Text = "About";
            // 
            // mnuiHelp
            // 
            this.mnuiHelp.Name = "mnuiHelp";
            this.mnuiHelp.Size = new System.Drawing.Size(114, 22);
            this.mnuiHelp.Text = "Help F1";
            // 
            // picbAnimal
            // 
            this.picbAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picbAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbAnimal.Location = new System.Drawing.Point(242, 40);
            this.picbAnimal.Name = "picbAnimal";
            this.picbAnimal.Size = new System.Drawing.Size(82, 74);
            this.picbAnimal.TabIndex = 1;
            this.picbAnimal.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(61, 40);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(121, 20);
            this.txtbName.TabIndex = 3;
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Items.AddRange(new object[] {
            "Bird",
            "Canine",
            "Feline"});
            this.cmbSpecies.Location = new System.Drawing.Point(61, 66);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(121, 21);
            this.cmbSpecies.Sorted = true;
            this.cmbSpecies.TabIndex = 4;
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(7, 69);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(48, 13);
            this.lblSpecies.TabIndex = 5;
            this.lblSpecies.Text = "Species:";
            // 
            // txtbBreed
            // 
            this.txtbBreed.Location = new System.Drawing.Point(61, 94);
            this.txtbBreed.Name = "txtbBreed";
            this.txtbBreed.Size = new System.Drawing.Size(121, 20);
            this.txtbBreed.TabIndex = 6;
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(7, 97);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(38, 13);
            this.lblBreed.TabIndex = 7;
            this.lblBreed.Text = "Breed:";
            // 
            // txtbIllnesses
            // 
            this.txtbIllnesses.Location = new System.Drawing.Point(61, 121);
            this.txtbIllnesses.Multiline = true;
            this.txtbIllnesses.Name = "txtbIllnesses";
            this.txtbIllnesses.Size = new System.Drawing.Size(121, 30);
            this.txtbIllnesses.TabIndex = 8;
            // 
            // lblIllnesses
            // 
            this.lblIllnesses.AutoSize = true;
            this.lblIllnesses.Location = new System.Drawing.Point(7, 124);
            this.lblIllnesses.Name = "lblIllnesses";
            this.lblIllnesses.Size = new System.Drawing.Size(50, 13);
            this.lblIllnesses.TabIndex = 9;
            this.lblIllnesses.Text = "Illnesses:";
            // 
            // txtbInjuries
            // 
            this.txtbInjuries.Location = new System.Drawing.Point(61, 157);
            this.txtbInjuries.Multiline = true;
            this.txtbInjuries.Name = "txtbInjuries";
            this.txtbInjuries.Size = new System.Drawing.Size(121, 30);
            this.txtbInjuries.TabIndex = 10;
            // 
            // lblInjuries
            // 
            this.lblInjuries.AutoSize = true;
            this.lblInjuries.Location = new System.Drawing.Point(7, 160);
            this.lblInjuries.Name = "lblInjuries";
            this.lblInjuries.Size = new System.Drawing.Size(43, 13);
            this.lblInjuries.TabIndex = 11;
            this.lblInjuries.Text = "Injuries:";
            // 
            // txtbNotes
            // 
            this.txtbNotes.Location = new System.Drawing.Point(61, 193);
            this.txtbNotes.Multiline = true;
            this.txtbNotes.Name = "txtbNotes";
            this.txtbNotes.Size = new System.Drawing.Size(121, 53);
            this.txtbNotes.TabIndex = 12;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(7, 196);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 13;
            this.lblNotes.Text = "Notes:";
            // 
            // mtxtRoomNo
            // 
            this.mtxtRoomNo.Location = new System.Drawing.Point(279, 183);
            this.mtxtRoomNo.Mask = "000";
            this.mtxtRoomNo.Name = "mtxtRoomNo";
            this.mtxtRoomNo.PromptChar = '#';
            this.mtxtRoomNo.Size = new System.Drawing.Size(49, 20);
            this.mtxtRoomNo.TabIndex = 14;
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Location = new System.Drawing.Point(218, 186);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(55, 13);
            this.lblRoomNo.TabIndex = 15;
            this.lblRoomNo.Text = "Room No:";
            // 
            // mtxtAge
            // 
            this.mtxtAge.Location = new System.Drawing.Point(279, 157);
            this.mtxtAge.Mask = "00";
            this.mtxtAge.Name = "mtxtAge";
            this.mtxtAge.PromptChar = '#';
            this.mtxtAge.Size = new System.Drawing.Size(49, 20);
            this.mtxtAge.TabIndex = 16;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(218, 160);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 17;
            this.lblAge.Text = "Age:";
            // 
            // btnTakePic
            // 
            this.btnTakePic.Location = new System.Drawing.Point(238, 124);
            this.btnTakePic.Name = "btnTakePic";
            this.btnTakePic.Size = new System.Drawing.Size(90, 23);
            this.btnTakePic.TabIndex = 18;
            this.btnTakePic.Text = "Take Picture";
            this.btnTakePic.UseVisualStyleBackColor = true;
            this.btnTakePic.Click += new System.EventHandler(this.btnTakePic_Click);
            // 
            // grpbGender
            // 
            this.grpbGender.Controls.Add(this.rabF);
            this.grpbGender.Controls.Add(this.rabM);
            this.grpbGender.Location = new System.Drawing.Point(221, 209);
            this.grpbGender.Name = "grpbGender";
            this.grpbGender.Size = new System.Drawing.Size(107, 30);
            this.grpbGender.TabIndex = 19;
            this.grpbGender.TabStop = false;
            this.grpbGender.Text = "Gender";
            // 
            // rabF
            // 
            this.rabF.AutoSize = true;
            this.rabF.Location = new System.Drawing.Point(58, 11);
            this.rabF.Name = "rabF";
            this.rabF.Size = new System.Drawing.Size(31, 17);
            this.rabF.TabIndex = 1;
            this.rabF.TabStop = true;
            this.rabF.Text = "F";
            this.rabF.UseVisualStyleBackColor = true;
            // 
            // rabM
            // 
            this.rabM.AutoSize = true;
            this.rabM.Location = new System.Drawing.Point(18, 12);
            this.rabM.Name = "rabM";
            this.rabM.Size = new System.Drawing.Size(34, 17);
            this.rabM.TabIndex = 0;
            this.rabM.TabStop = true;
            this.rabM.Text = "M";
            this.rabM.UseVisualStyleBackColor = true;
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(238, 280);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(90, 23);
            this.btnProceed.TabIndex = 20;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // lblAgroRating
            // 
            this.lblAgroRating.AutoSize = true;
            this.lblAgroRating.Location = new System.Drawing.Point(58, 257);
            this.lblAgroRating.Name = "lblAgroRating";
            this.lblAgroRating.Size = new System.Drawing.Size(66, 13);
            this.lblAgroRating.TabIndex = 21;
            this.lblAgroRating.Text = "Agro Rating:";
            // 
            // nudAgroRating
            // 
            this.nudAgroRating.Location = new System.Drawing.Point(131, 254);
            this.nudAgroRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAgroRating.Name = "nudAgroRating";
            this.nudAgroRating.Size = new System.Drawing.Size(28, 20);
            this.nudAgroRating.TabIndex = 23;
            // 
            // picbAgroRatingInfo
            // 
            this.picbAgroRatingInfo.Image = ((System.Drawing.Image)(resources.GetObject("picbAgroRatingInfo.Image")));
            this.picbAgroRatingInfo.Location = new System.Drawing.Point(162, 257);
            this.picbAgroRatingInfo.Name = "picbAgroRatingInfo";
            this.picbAgroRatingInfo.Size = new System.Drawing.Size(17, 17);
            this.picbAgroRatingInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbAgroRatingInfo.TabIndex = 24;
            this.picbAgroRatingInfo.TabStop = false;
            this.ttAgroRatingInfo.SetToolTip(this.picbAgroRatingInfo, "AgroRating on a scale 0 - 5\r\nNo agro = 0\r\nagro towards other animals = 1 or 2\r\nag" +
                    "ro towards people = 3 or 4\r\nagro towards everyone = 5");
            // 
            // ttAgroRatingInfo
            // 
            this.ttAgroRatingInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttAgroRatingInfo.ToolTipTitle = "Info about Agro Rating";
            // 
            // cbNuetered
            // 
            this.cbNuetered.AutoSize = true;
            this.cbNuetered.Location = new System.Drawing.Point(221, 256);
            this.cbNuetered.Name = "cbNuetered";
            this.cbNuetered.Size = new System.Drawing.Size(70, 17);
            this.cbNuetered.TabIndex = 25;
            this.cbNuetered.Text = "Nuetered";
            this.cbNuetered.UseVisualStyleBackColor = true;
            // 
            // iShelter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 313);
            this.Controls.Add(this.cbNuetered);
            this.Controls.Add(this.picbAgroRatingInfo);
            this.Controls.Add(this.nudAgroRating);
            this.Controls.Add(this.lblAgroRating);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.grpbGender);
            this.Controls.Add(this.btnTakePic);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.mtxtAge);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.mtxtRoomNo);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtbNotes);
            this.Controls.Add(this.lblInjuries);
            this.Controls.Add(this.txtbInjuries);
            this.Controls.Add(this.lblIllnesses);
            this.Controls.Add(this.txtbIllnesses);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.txtbBreed);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.cmbSpecies);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picbAnimal);
            this.Controls.Add(this.mnsAnimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsAnimal;
            this.Name = "iShelter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iShelter";
            this.mnsAnimal.ResumeLayout(false);
            this.mnsAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbAnimal)).EndInit();
            this.grpbGender.ResumeLayout(false);
            this.grpbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgroRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbAgroRatingInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsAnimal;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuiExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuiAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuiHelp;
        private System.Windows.Forms.PictureBox picbAnimal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.TextBox txtbBreed;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.TextBox txtbIllnesses;
        private System.Windows.Forms.Label lblIllnesses;
        private System.Windows.Forms.TextBox txtbInjuries;
        private System.Windows.Forms.Label lblInjuries;
        private System.Windows.Forms.TextBox txtbNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.MaskedTextBox mtxtRoomNo;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.MaskedTextBox mtxtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnTakePic;
        private System.Windows.Forms.GroupBox grpbGender;
        private System.Windows.Forms.RadioButton rabF;
        private System.Windows.Forms.RadioButton rabM;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.Label lblAgroRating;
        private System.Windows.Forms.NumericUpDown nudAgroRating;
        private System.Windows.Forms.PictureBox picbAgroRatingInfo;
        private System.Windows.Forms.ToolTip ttAgroRatingInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuProcedures;
        private System.Windows.Forms.ToolStripMenuItem mnuGuardians;
        private System.Windows.Forms.ToolStripMenuItem mnuiEditGuardians;
        private System.Windows.Forms.ToolStripMenuItem mnuAnimals;
        private System.Windows.Forms.ToolStripMenuItem mnuiRecordProcedure;
        private System.Windows.Forms.ToolStripMenuItem mnuiEditAnimals;
        private System.Windows.Forms.ToolStripMenuItem mnuiEditProcedure;
        private System.Windows.Forms.ToolStripMenuItem mnuiAnimals;
        private System.Windows.Forms.ToolStripMenuItem mnuiSpecificAnimal;
        private System.Windows.Forms.ToolStripMenuItem mnuiAdopted;
        private System.Windows.Forms.ToolStripMenuItem mnuiNotNuetered;
        private System.Windows.Forms.ToolStripMenuItem mnuiProcessedPer;
        private System.Windows.Forms.ToolStripMenuItem mnuiMonth;
        private System.Windows.Forms.ToolStripMenuItem mnuiWeek;
        private System.Windows.Forms.ToolStripMenuItem mnuiDay;
        private System.Windows.Forms.ToolStripMenuItem mnuiGuardians;
        private System.Windows.Forms.ToolStripMenuItem mnuiSpecificGuardian;
        private System.Windows.Forms.ToolStripMenuItem mnuiProcedures;
        private System.Windows.Forms.CheckBox cbNuetered;
    }
}

