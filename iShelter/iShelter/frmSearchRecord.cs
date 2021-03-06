﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace iShelter
{
    public partial class frmSearchRecord : Form
    {
        DataSet dbTable;

        public frmSearchRecord(string frmChoice, string parent)
        {
            InitializeComponent();
            //Uses parameter recieved to decide what the frm does and which extra controls are shown
            if (frmChoice == "ProcedureDetails")
            {
                pnlProcedureDetails.Visible = true;
                cmbSearchCategory.Visible = true;
                cmbSearchCategory.SelectedIndex = 0;
            }
            else if (frmChoice == "GuardianDetails")
            {
                pnlProcedureDetails.Visible = false;
                cmbSearchCategory.Visible = false;
                pnlSearch.Location = new System.Drawing.Point(0, -3);
                this.Size = new System.Drawing.Size(391, 254);
                this.Text = "Registered Guardians";
                wmtxtbSearchTerm.WaterMarkText = "Search Name, Last Name, Tel No";

            }

            //Removes animal option from cmbox when recording a procedure of a newly recorded animal
            //In this way the animal id is already set for the procedure
            if (parent == "Menu")
            {
                cmbSearchCategory.Items.RemoveAt(0);
                txtbAnimalID.Text = Properties.Settings.Default.AnimalID;
               // MessageBox.Show(@Properties.Settings.Default.SaveLocation + @"\animalsPics\Animal" + Properties.Settings.Default.AnimalID + ".jpg");
                picbAnimal.ImageLocation = @Properties.Settings.Default.SaveLocation + @"\animalsPics\Animal" + Properties.Settings.Default.AnimalID + ".jpg"; 
                wmtxtbSearchTerm.WaterMarkText = "Search Procedure ID, Procedure Name";
            }
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (this.Text == "Registered Guardians")
            {
                //Gets the guardian ID of the selected record
                var selectedRecord = dgvSearchTbl.SelectedCells;
                string guardianID = selectedRecord[0].Value.ToString();

                try
                {
                    //Updates the guardian ID for the animal
                    //prepares sql string
                    string sql = "UPDATE tblAnimals SET GuardianID = " + guardianID + " WHERE AnimalID = " + Properties.Settings.Default.AnimalID;

                    //Creates & Opens db Connection
                    SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.DbConnString);
                    sqlConn.Open();

                    //Creates & Executes command
                    SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Guardian Successfully linked to Animal", "iShelter || Info");

                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("An Error occured while trying to update tblAnimals with a guardian ID: " + ex.Message, "iShelter || Error");
                }

            }
            else
            {
                //Validates that a value has been selected for all fields
                string[] reqFields = { txtbAnimalID.Text, txtbProcedureID.Text, txtbVetID.Text };

                //Uses a validation class
                ValidationCalculator validator = new ValidationCalculator();
                int result = validator.valCompleted(reqFields);
                string invalidField;
                // MessageBox.Show("Val Result: " + result);
                switch (result)
                {
                    case 0: invalidField = "Animal ID";
                        break;
                    case 1: invalidField = "Procedure ID";
                        break;
                    case 2: invalidField = "Vetenarian ID";
                        break;
                    default: invalidField = "Error the invalid field could not be determined";
                        break;
                }


                //Proceeds to insert data into db if validation was successfull
                if (result == -1)
                {
                    try
                    {
                        //prepare sql string
                        string sql = "INSERT INTO tblProcedureOp (AnimalID, ProcedureID, VetID)" +
                                        "VALUES(" + txtbAnimalID.Text + ", " + txtbProcedureID.Text + ", " + txtbVetID.Text + ")";

                        //Creates & Opens db Connection
                        SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.DbConnString);
                        sqlConn.Open();

                        //Creates & Executes command then closes db connection
                        SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);
                        sqlCmd.ExecuteNonQuery();
                        sqlConn.Close();

                        MessageBox.Show("Procedure Operation Successfully Added", "iShelter || Info");

                        this.DialogResult = DialogResult.OK;
                        this.Dispose();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("An Error occured when trying to insert the procedure operation into the DataBase: " + ex.Message, "iShelter || Error");
                    }
                }
                else
                    MessageBox.Show("A selection has not been made for the following field: " + invalidField, "iShelter || Error");
            }
        }

        private void frmProcedureDetails_Load(object sender, EventArgs e)
        {

            //sql select statement string for gridView
            string sql = "";

            //Checks which table to load into the gridView and adds the appropriate tbl to the sql string
            if (this.Text == "Registered Guardians")
                sql = "SELECT GuardianID, FirstName, LastName, Tel FROM tblGuardians";
            else if (cmbSearchCategory.SelectedItem.ToString() == "Animals")
                sql = "SELECT AnimalID, Name, Species, Breed, PhotoDir FROM tblAnimals";
            else if (cmbSearchCategory.SelectedItem.ToString() == "Procedures")
                sql = "SELECT * FROM tblProcedures";
            else if (cmbSearchCategory.SelectedItem.ToString() == "Vetenarians")
                sql = "SELECT VetID, FirstName, LastName FROM tblVets";

           try
           {
                //Retriev the data for the gridView from the db
                //Createing and opening db connection
                SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.DbConnString);
                sqlConn.Open();

                //Create a data adapter to fill a dataset
                SqlDataAdapter dbAdapter = new SqlDataAdapter(sql, sqlConn);

                //Create and Fill dataset
                dbTable = new DataSet();
                dbAdapter.Fill(dbTable);

                //Set data source for the grid view            
                dgvSearchTbl.DataSource = dbTable.Tables[0];

                sqlConn.Close();

                //Used to hide photoDir column if the animal table is selected & use that directory for pic box
                if (dbTable.Tables[0].Columns[0].ColumnName == "AnimalID")
                {
                    dgvSearchTbl.Columns[4].Visible = false;
                    string PhotoDir = dgvSearchTbl[4, 0].Value.ToString();
                    picbAnimal.ImageLocation = @Properties.Settings.Default.SaveLocation + @PhotoDir;
                }

            }
            catch (SystemException se)
            {
                MessageBox.Show("An Error occured while loading the table: " + this.Text + " - " + se.Message, "iShelter || Error");
            }

        }

        private void cmbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sets auto complete source and watermark text for the search term box depending on which table was selected
            if (cmbSearchCategory.SelectedItem.ToString() == "Animals")
            {
                wmtxtbSearchTerm.WaterMarkText = "Search Animal ID, Animal Name";                          
            }
            else if (cmbSearchCategory.SelectedItem.ToString() == "Procedures")
            {
                wmtxtbSearchTerm.WaterMarkText = "Search Procedure ID, Procedure Name";
            }
            else if (cmbSearchCategory.SelectedItem.ToString() == "Vetenarians")
            {
                wmtxtbSearchTerm.WaterMarkText = "Search Vet ID, Vet Name, Vet Surname";
            }

            frmProcedureDetails_Load(sender, e);
        }

        private void dgvSearchTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Text == "Registered Guardians")
            {

            }
            else
            {
                //Sets procedure details textboxes to selected values
                //Checks which value has been selected by looking what has been selected in the combo box
                if (cmbSearchCategory.SelectedItem.ToString() == "Animals")
                {
                    var selectedCells = dgvSearchTbl.SelectedCells;
                    txtbAnimalID.Text = selectedCells[0].Value.ToString();
                    picbAnimal.ImageLocation = @Properties.Settings.Default.SaveLocation + selectedCells[4].Value.ToString();
                }
                else if (cmbSearchCategory.SelectedItem.ToString() == "Procedures")
                {
                    var selectedCells = dgvSearchTbl.SelectedCells;
                    txtbProcedureID.Text = selectedCells[0].Value.ToString();
                }
                else if (cmbSearchCategory.SelectedItem.ToString() == "Vetenarians")
                {
                    var selectedCells = dgvSearchTbl.SelectedCells;
                    txtbVetID.Text = selectedCells[0].Value.ToString();
                }              

            }
        }

        private void wmtxtbSearchTerm_TextChanged(object sender, EventArgs e)
        {
            DataView dvFiltering = new DataView(dbTable.Tables[0]);

            //Filters records base on search term and category selected
            if (wmtxtbSearchTerm.Text != "")
            {
                if (this.Text == "Registered Guardians")
                {
                    //Uses a dataView object to filter trough records then updates the data source of the dataGridView
                    //In this manner no data is altered in the DataSet and can be returned to original state if nothing is being searched
                    try
                    {
                        dvFiltering.RowFilter = "GuardianID = " + wmtxtbSearchTerm.Text +  "OR Tel LIKE '" + wmtxtbSearchTerm.Text + "%'";
                        dgvSearchTbl.DataSource = dvFiltering;
                    }
                    catch (EvaluateException)
                    {
                        dvFiltering.RowFilter = "FirstName LIKE '" + wmtxtbSearchTerm.Text + "%' OR LastName LIKE '" + wmtxtbSearchTerm.Text + "%'";
                        dgvSearchTbl.DataSource = dvFiltering;
                    }
                    catch (SyntaxErrorException)
                    {
                        dvFiltering.RowFilter = "FirstName LIKE '" + wmtxtbSearchTerm.Text + "%' OR LastName LIKE '" + wmtxtbSearchTerm.Text + "%'";
                        dgvSearchTbl.DataSource = dvFiltering;
                    }
                }
                else if (cmbSearchCategory.SelectedItem.ToString() == "Animals")
                {
                    try
                    {
                        dvFiltering.RowFilter = "AnimalID = " + wmtxtbSearchTerm.Text;
                        dgvSearchTbl.DataSource = dvFiltering;
                    }
                    catch (EvaluateException)
                    {
                        dvFiltering.RowFilter = "Name LIKE '" + wmtxtbSearchTerm.Text + "%'";
                        dgvSearchTbl.DataSource = dvFiltering;
                    }
                    catch (SyntaxErrorException see)
                    {
                        wmtxtbSearchTerm.Clear();
                        dgvSearchTbl.DataSource = dbTable.Tables[0];
                        MessageBox.Show("Error no field contains such syntax, please refrain from using it. : " + see.Message, "iShelter || Error");
                    }
                }
                else if (cmbSearchCategory.SelectedItem.ToString() == "Procedures")
                {
                    try
                    {
                        dvFiltering.RowFilter = "ProcedureID = " + wmtxtbSearchTerm.Text;
                        dgvSearchTbl.DataSource = dvFiltering;
                    }
                    catch (EvaluateException)
                    {
                        dvFiltering.RowFilter = "Name LIKE '" + wmtxtbSearchTerm.Text + "%'";
                        dgvSearchTbl.DataSource = dvFiltering;
                    }
                    catch (SyntaxErrorException see)
                    {
                        wmtxtbSearchTerm.Clear();
                        dgvSearchTbl.DataSource = dbTable.Tables[0];
                        MessageBox.Show("Error no field contains such syntax, please refrain from using it. : " + see.Message, "iShelter || Error");
                    }
                }
                else if (cmbSearchCategory.SelectedItem.ToString() == "Vetenarians")
                {
                    //Filters according to prefferance
                    try
                    {
                        dvFiltering.RowFilter = "VetID = " + wmtxtbSearchTerm.Text;                       
                        dgvSearchTbl.DataSource = dvFiltering;
                    }
                    catch (EvaluateException)
                    {
                        dvFiltering.RowFilter = "FirstName LIKE '" + wmtxtbSearchTerm.Text + "%' OR LastName LIKE '" + wmtxtbSearchTerm.Text + "%'";
                        dgvSearchTbl.DataSource = dvFiltering;                        
                    }
                    catch (SyntaxErrorException see)
                    {
                        wmtxtbSearchTerm.Clear();
                        dgvSearchTbl.DataSource = dbTable.Tables[0];
                        MessageBox.Show("Error no field contains such syntax, please refrain from using it. : " + see.Message, "iShelter || Error");
                    }
                }
            }
            else
            {
                dgvSearchTbl.DataSource = dbTable.Tables[0];
            }
        }

    }
}
