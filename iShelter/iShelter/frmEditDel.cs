using System;
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
    public partial class frmEditDel : Form
    {
        private string tblChoice;

        private DataSet dbTable;
        private SqlDataAdapter dbAdapter;
        SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.DbConnString);
        DataView dvFiltering;

        public frmEditDel(string tblChoice)
        {
            InitializeComponent();
            this.tblChoice = tblChoice;            
        }

        private void frmEditDel_Load(object sender, EventArgs e)
        {
            //prepare sql string
            string sql = "SELECT * FROM " + tblChoice;

            try
            {
                //Create & Open db Connection                
                sqlConn.Open();

                //Create adapter to fill dataset
                dbAdapter = new SqlDataAdapter(sql, sqlConn);

                //Initialise & fill the dataset
                dbTable = new DataSet();
                dbAdapter.Fill(dbTable);

                dgvEditDel.DataSource = dbTable.Tables[0];

                sqlConn.Close();

                //Changes water mark text in search box
                if (tblChoice == "tblAnimals")
                    wmtxtbSearchTerm.WaterMarkText = "Search Animal ID, Animal Name";
                else if (tblChoice == "tblGuardians")
                    wmtxtbSearchTerm.WaterMarkText = "Search Guardian ID, First Name, Last Name";
                else if (tblChoice == "tblProcedureOp")
                    wmtxtbSearchTerm.WaterMarkText = "Search ProcedureOp ID, Procedure ID, Animal ID, Vet ID";
                else if (tblChoice == "tblProcedures")
                    wmtxtbSearchTerm.WaterMarkText = "Search Procedure ID, Name";
                else if (tblChoice == "tblVets")
                    wmtxtbSearchTerm.WaterMarkText = "Search Vet ID, First Name, Last Name";
            }
            catch (SystemException se)
            {
                MessageBox.Show("An Error occured while loading the table: " + tblChoice + " - " + se.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {              
                //Create cmd builder to generate update sql statements
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dbAdapter);

                //Push updates to db
                dbAdapter.Update(dbTable);
            }
            catch (SystemException se)
            {
                MessageBox.Show("An Error occured while Updating the table: " + tblChoice + " - " + se.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void waterMarkTextBox1_TextChanged(object sender, EventArgs e)
        {
            dvFiltering = new DataView(dbTable.Tables[0]);

            //Filtering records based on search term
            //Uses a dataView object to filter trough records then updates the data source of the dataGridView
            //In this manner no data is altered in the DataSet and can be returned to original state if nothing is being searched
            if (wmtxtbSearchTerm.Text != "")
            {
                if (tblChoice == "tblAnimals")
                {
                    try
                    {
                        dvFiltering.RowFilter = "AnimalID = " + wmtxtbSearchTerm.Text;
                        dgvEditDel.DataSource = dvFiltering;
                    }
                    catch (EvaluateException)
                    {
                        dvFiltering.RowFilter = "Name LIKE '" + wmtxtbSearchTerm.Text + "%'";
                        dgvEditDel.DataSource = dvFiltering;
                    }
                    catch (SyntaxErrorException see)
                    {
                        wmtxtbSearchTerm.Clear();
                        dgvEditDel.DataSource = dbTable.Tables[0];
                        MessageBox.Show("Error no field contains such syntax, please refrain from using it. : " + see.Message);
                    }
                }
                else if (tblChoice == "tblGuardians")
                {
                    try
                    {
                        dvFiltering.RowFilter = "GuardianID = " + wmtxtbSearchTerm.Text + "OR Tel LIKE '" + wmtxtbSearchTerm.Text + "%'";
                        dgvEditDel.DataSource = dvFiltering;
                    }
                    catch (EvaluateException)
                    {
                        dvFiltering.RowFilter = "FirstName LIKE '" + wmtxtbSearchTerm.Text + "%' OR LastName LIKE '" + wmtxtbSearchTerm.Text + "%'";
                        dgvEditDel.DataSource = dvFiltering;
                    }
                    catch (SyntaxErrorException)
                    {
                        dvFiltering.RowFilter = "FirstName LIKE '" + wmtxtbSearchTerm.Text + "%' OR LastName LIKE '" + wmtxtbSearchTerm.Text + "%'";
                        dgvEditDel.DataSource = dvFiltering;
                    }
                }
                else if (tblChoice == "tblProcedures")
                {
                    try
                    {
                        dvFiltering.RowFilter = "ProcedureID = " + wmtxtbSearchTerm.Text;
                        dgvEditDel.DataSource = dvFiltering;
                    }
                    catch (EvaluateException)
                    {
                        dvFiltering.RowFilter = "Name LIKE '" + wmtxtbSearchTerm.Text + "%'";
                        dgvEditDel.DataSource = dvFiltering;
                    }
                    catch (SyntaxErrorException see)
                    {
                        wmtxtbSearchTerm.Clear();
                        dgvEditDel.DataSource = dbTable.Tables[0];
                        MessageBox.Show("Error no field contains such syntax, please refrain from using it. : " + see.Message);
                    }
                }
                else if (tblChoice == "tblProcedureOp")
                {
                    try
                    {
                        dvFiltering.RowFilter = "ProcedureOpID = " + wmtxtbSearchTerm.Text;
                        dgvEditDel.DataSource = dvFiltering;

                        dvFiltering.RowFilter = "ProcedureID = " + wmtxtbSearchTerm.Text;
                        dgvEditDel.DataSource = dvFiltering;

                        dvFiltering.RowFilter = "AnimalID = " + wmtxtbSearchTerm.Text;
                        dgvEditDel.DataSource = dvFiltering;

                        dvFiltering.RowFilter = "VetID = " + wmtxtbSearchTerm.Text;
                        dgvEditDel.DataSource = dvFiltering;
                    }
                    catch (EvaluateException ee)
                    {
                        wmtxtbSearchTerm.Clear();
                        dgvEditDel.DataSource = dbTable.Tables[0];
                        MessageBox.Show("Error no field contains such syntax, please refrain from using it. : " + ee.Message);
                    }
                    catch (SyntaxErrorException see)
                    {
                        wmtxtbSearchTerm.Clear();
                        dgvEditDel.DataSource = dbTable.Tables[0];
                        MessageBox.Show("Error no field contains such syntax, please refrain from using it. : " + see.Message);
                    }
                }
                else if (tblChoice == "tblVets")
                {
                    try
                    {
                        dvFiltering.RowFilter = "VetID = " + wmtxtbSearchTerm.Text;
                        dgvEditDel.DataSource = dvFiltering;
                    }
                    catch (EvaluateException)
                    {
                        dvFiltering.RowFilter = "FirstName LIKE '" + wmtxtbSearchTerm.Text + "%' OR LastName LIKE '" + wmtxtbSearchTerm.Text + "%'";
                        dgvEditDel.DataSource = dvFiltering;
                    }
                    catch (SyntaxErrorException see)
                    {
                        wmtxtbSearchTerm.Clear();
                        dgvEditDel.DataSource = dbTable.Tables[0];
                        MessageBox.Show("Error no field contains such syntax, please refrain from using it. : " + see.Message);
                    }
                }
            }
            else
            {
                dgvEditDel.DataSource = dbTable.Tables[0];
            }
          }

        }
    }

