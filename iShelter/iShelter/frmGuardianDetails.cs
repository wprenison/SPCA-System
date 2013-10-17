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
    public partial class frmGuardianDetails : Form
    {
        public frmGuardianDetails()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            //bool to determine if all fields have passed validation
            bool allFieldsValid = false;
            
            //Collect all fields data
            string fname = txtbFirstName.Text;
            string lname = txtbLastName.Text;
            string telno = mtxtTelNo.Text;
            string address = txtbAddress.Text;
            string dob = dtpDateOfBirth.Text;

            //Validate that req fields are complete
            //string array to use validationCalculator Class
            string[] reqFields = { fname, lname, telno, address };

            ValidationCalculator validator = new ValidationCalculator();
            int invalidFieldNo = validator.valCompleted(reqFields); //Returns the index of the invalid element and -1 if none are invalid

            if (invalidFieldNo > -1)
            {
                string invalidField;

                //Checks which field is the incomplete/invalid field and stores a name for thaat field to be used in the error message that follows
                switch (invalidFieldNo)
                {
                    case 0: invalidField = "First Name";
                            break;
                    case 1: invalidField = "Last Name";
                            break;
                    case 2: invalidField = "Tel No";
                            break;
                    case 3: invalidField = "Address";
                            break;
                    default: invalidField = "Error the invalid field could not be determined";
                             break;
                }

                MessageBox.Show("The following field was not completed: " + invalidField, "Error");
            }
            
            //Checks that the dob field has been changed if it hasnthen it checks that all fiedls have been completed befor setting the bool to true inorder to insert the data into the db
            if(dtpDateOfBirth.Value.Date == DateTime.Now.Date)
            {
                MessageBox.Show("The Date Of Birth field has not been set.", "Error");
            }
            else if(invalidFieldNo == -1)
                allFieldsValid = true;

            if(allFieldsValid)
            {
                try
                {
                    //Prepare sql string
                    string sql = "INSERT INTO tblGuardians (FirstName, LastName, DateOfBirth, Tel, ResAddress)" +
                                    "VALUES('" + fname + "', '" + lname + "', '" + dob + "', '" + telno + "', '" + address + "')";

                    //Connects to db and inserts guardian data
                    SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.DbConnString);
                    sqlConn.Open();

                    //Creates command and executes
                    SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);
                    sqlCmd.ExecuteNonQuery();
                    sqlConn.Close();

                    MessageBox.Show("Guardian Details Successfully Added", "Info");

                    //Returns a dialogue value and closes the current form to return to frmMenu
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();

                    //Gets the recently inserted guardian's id in order to complete link table tblRecievedPatient this links an animal and guardian
                    try
                    {
                        string guardianID = "";

                        //prepare sql string
                        string sqlGuardianID = "SELECT GuardianID FROM tblGuardians";
                        sqlConn.Open();
                        sqlCmd = new SqlCommand(sqlGuardianID, sqlConn);
                        SqlDataReader reader = sqlCmd.ExecuteReader();

                        while (reader.Read())
                        {
                            guardianID = reader[0].ToString();
                        }

                        reader.Close();
                        sqlConn.Close();

                        //Inserts the animalID from settings and the guardianID into the link table tblRecievePatient
                        try
                        {
                            //prepare sql string
                            string sqlInsertLinkTable = "INSERT INTO tblRecievePatient (GuardianID, AnimalID)" +
                                                            "VALUES (" + guardianID + "," + Properties.Settings.Default.AnimalID + ")";

                            sqlConn.Open();
                            sqlCmd = new SqlCommand(sqlInsertLinkTable, sqlConn);
                            sqlCmd.ExecuteNonQuery();
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("An Error occured while inserting data into link tblRecievedPatient: " + ex.Message);
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("An error occured while retriving new guardian ID: " + ex.Message);
                    }
                }
                catch(System.Exception ex)
                {
                    MessageBox.Show("An Error occured while trying to insert guardian data into the DataBase: " + ex.Message);
                }                
            }            
        }
    }
}
