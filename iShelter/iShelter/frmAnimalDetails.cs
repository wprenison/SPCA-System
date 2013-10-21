using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WinFormCharpWebCam;
using WebCam_Capture;

namespace iShelter
{
    public partial class iShelter : Form
    {
        //WebCam Object
        WebCam webcam = new WebCam();
        Image pic;
        int webcamToggle = 0; //Toggle value used to det weither to switch cam on or off

        public iShelter()
        {
            InitializeComponent();
            //Set as default Canine
            cmbSpecies.SelectedIndex = 1;

            //Set pic Box to use for webcam
            webcam.InitializeWebCam(ref picbAnimal);

        }

        

        private void btnProceed_Click(object sender, EventArgs e)
        {
            //Validate required fields on form
            bool allReqFilledIn = false;

            
            //Builds a string array to be used as input to a validationCalculator methode. This methode then returns an int value equal to the index of the non completed element.
            //A value of -1 means all the elements have been completed
            string[] reqFields = { txtbName.Text, txtbBreed.Text, mtxtAge.Text, mtxtRoomNo.Text };

            ValidationCalculator validator = new ValidationCalculator();
            int validationResult = validator.valCompleted(reqFields);

            if (validationResult == -1)
                allReqFilledIn = true;
            else
            {
                //Used to modify the error msg acordingly
                string errorMsg = "The following field was not completed: ";

                if (validationResult == 0)
                    errorMsg = errorMsg + "Name";
                else if (validationResult == 1)
                    errorMsg = errorMsg + "Breed";
                else if (validationResult == 2)
                    errorMsg = errorMsg + "Age";
                else if (validationResult == 3)
                    errorMsg = errorMsg + "Room No";
                else
                    errorMsg = errorMsg + "Unknown";

                MessageBox.Show(errorMsg, "Error");
            }

            //Validates that a gender has been selected
            bool valGender = false;
            RadioButton[] genderRads = { rabM, rabF };
            valGender = validator.valRadioButtonComplete(genderRads);

            if (!valGender)
                MessageBox.Show("A gender was not selected", "Error");

            if (allReqFilledIn && valGender)
            {
                
                try
                {
                    //Creates & Opens connection to db
                    SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.DbConnString);
                    sqlConn.Open();
                    //Prepares sql string using parameters and ensures null values are inserted as the db type null
                    string sql = "INSERT INTO tblAnimals (Name, Species, Breed, Gender, DateRecieved, Illnesses, Injuries, Notes, RoomNo, Neutered, EstimatedAge, AgroRating)" +
                                   " VALUES (@Name, @Species, @Breed, @Gender, @DateRecieved, @Illnesses, @Injuries, @Notes, @RoomNo, @Neutered, @EstimatedAge, @AgroRating)";

                    SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);

                    sqlCmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtbName.Text;
                    sqlCmd.Parameters.Add("@Species", SqlDbType.VarChar).Value = cmbSpecies.SelectedItem.ToString();
                    sqlCmd.Parameters.Add("@Breed", SqlDbType.VarChar).Value = txtbBreed.Text;

                    //Check Which gender has been selected
                    if (rabM.Checked)
                        sqlCmd.Parameters.Add("@Gender", SqlDbType.Char).Value = 'M';
                    else
                        sqlCmd.Parameters.Add("@Gender", SqlDbType.Char).Value = 'F';

                    sqlCmd.Parameters.Add("@DateRecieved", SqlDbType.Date).Value = DateTime.Now.ToString();

                    //Check for null values
                    if (txtbIllnesses.Text == "" || txtbIllnesses.Text.ToLower() == "none")
                        sqlCmd.Parameters.Add("@Illnesses", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        sqlCmd.Parameters.Add("@Illnesses", SqlDbType.VarChar).Value = txtbIllnesses.Text;

                    if (txtbInjuries.Text == "" || txtbInjuries.Text.ToLower() == "none")
                        sqlCmd.Parameters.Add("@Injuries", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        sqlCmd.Parameters.Add("@Injuries", SqlDbType.VarChar).Value = txtbInjuries.Text;

                    if (txtbInjuries.Text == "" || txtbInjuries.Text.ToLower() == "none")
                        sqlCmd.Parameters.Add("@Notes", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        sqlCmd.Parameters.Add("@Notes", SqlDbType.VarChar).Value = txtbNotes.Text;

                    sqlCmd.Parameters.Add("@RoomNo", SqlDbType.Int).Value = mtxtRoomNo.Text;

                    //Checking for animals that can not be neutered in order to set the value to null
                    if (cmbSpecies.SelectedItem.ToString() == "Bird")
                        sqlCmd.Parameters.Add("@Neutured", SqlDbType.Bit).Value = DBNull.Value;
                    else
                        sqlCmd.Parameters.Add("@Neutered", SqlDbType.Bit).Value = cbNuetered.Checked.ToString();

                    sqlCmd.Parameters.Add("@EstimatedAge", SqlDbType.Int).Value = mtxtAge.Text;
                    sqlCmd.Parameters.Add("@AgroRating", SqlDbType.Int).Value = nudAgroRating.Value.ToString();
                    //Executes insert query
                    sqlCmd.ExecuteNonQuery();
                    sqlConn.Close();

                    clearAllFields();
                    MessageBox.Show("Animal Succesfully Added", "Info");

                    //Get the animalID of the animal just added to the db
                    try
                    {
                        string animalID = "";

                        //prepare sql string
                        string sqlAnimalID = "SELECT AnimalID FROM tblAnimals";

                        //Opens connection to db and populates the data reader
                        sqlConn.Open();
                        sqlCmd = new SqlCommand(sqlAnimalID, sqlConn);
                        SqlDataReader reader = sqlCmd.ExecuteReader();
                        reader.Read();
                        while (reader.Read())
                        {
                            animalID = reader[0].ToString();
                        }
                        reader.Close();
                        sqlConn.Close();

                        Properties.Settings.Default.AnimalID = animalID;
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("An Error occured when finding the animalID: " + ex.Message);
                    }

                    //Change forms and dispose of the new one depending on a return value recieved
                    //Adopt btn returns OK, Cancel button and closing cross returns Cancel
                    frmMenu menu = new frmMenu();
                    DialogResult result = menu.ShowDialog();

                    if (result == DialogResult.OK || result == DialogResult.Cancel)
                        menu.Dispose();

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("An Error ocurred: " + ex.Message);
                }                
                
            }
                
            
        }

        private void clearAllFields()
        {
            txtbName.Clear();
            cmbSpecies.SelectedIndex = 1;
            txtbBreed.Clear();
            txtbIllnesses.Clear();
            txtbInjuries.Clear();
            txtbNotes.Clear();
            mtxtAge.Clear();
            mtxtRoomNo.Clear();
            rabF.Checked = false;
            rabM.Checked = false;
            cbNuetered.Checked = false;
            nudAgroRating.Value = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTakePic_Click(object sender, EventArgs e)
        {
            pic = picbAnimal.Image;
            webcam.Stop();
        }

        private void mnuiRecordProcedure_Click(object sender, EventArgs e)
        {
            frmSearchRecord recordProcedure = new frmSearchRecord("ProcedureDetails", "ToolStripMenu");
            recordProcedure.ShowDialog();
        }

        private void mnuiSpecificAnimal_Click(object sender, EventArgs e)
        {
            frmReportSpecific reportTest = new frmReportSpecific();
            reportTest.ShowDialog();
        }

        private void picbWebcamOnOff_Click(object sender, EventArgs e)
        {
            if (webcamToggle == 0)
            {
                webcam.Start();
                webcamToggle = 1;
            }
            else if (webcamToggle == 1)
            {
                webcam.Stop();
                picbAnimal.Image = null;
                webcamToggle = 0;
            }
        }

        private void mnuiOptions_Click(object sender, EventArgs e)
        {
            frmOptions options = new frmOptions();
            options.ShowDialog();
        }

        private void iShelter_Load(object sender, EventArgs e)
        {
            bool saveLocationSet = false;
            bool dbConnStringSet = false;

            //Forces a save Location be saved
            if (Properties.Settings.Default.SaveLocation == "" || Properties.Settings.Default.DbConnString == "")
            {
                while (!saveLocationSet || !dbConnStringSet)
                {
                    MessageBox.Show("Please select a save location for any reports and animal photos\n And a database connection string");
                    frmOptions options = new frmOptions();
                    DialogResult result = options.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        saveLocationSet = true;
                        dbConnStringSet = true;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        DialogResult exitResult = MessageBox.Show("Would you like to exit?", "Exit Confirm", MessageBoxButtons.YesNo);

                        if (exitResult == DialogResult.Yes)
                            Application.Exit();

                    }
                }
            }
        }

        private void mnuiAdopted_Click(object sender, EventArgs e)
        {
            frmReportAnimals report = new frmReportAnimals("Adopted");
            report.Show();
        }

        private void mnuiNotNuetered_Click(object sender, EventArgs e)
        {
            frmReportAnimals report = new frmReportAnimals("Neutered");
            report.Show();
        }

        private void mnuiDay_Click(object sender, EventArgs e)
        {
            frmReportDates reportDates = new frmReportDates("Day");
            reportDates.ShowDialog();
        }

        private void mnuiMonth_Click(object sender, EventArgs e)
        {
            frmReportDates reportDates = new frmReportDates("Month");
            reportDates.ShowDialog();
        }

        private void mnuiAbout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DbConnString = "";
            Properties.Settings.Default.SaveLocation = "";
            Properties.Settings.Default.Save();
        }

        private void animalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditDel editDel = new frmEditDel("tblAnimals");
            editDel.ShowDialog();
        }

        private void guardiansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditDel editDel = new frmEditDel("tblGuardians");
            editDel.ShowDialog();
        }

        private void mnuiEditVets_Click(object sender, EventArgs e)
        {
            frmEditDel editDel = new frmEditDel("tblVets");
            editDel.ShowDialog();
        }

        private void mnuiEditProcedures_Click(object sender, EventArgs e)
        {
            frmEditDel editDel = new frmEditDel("tblProcedureOp");
            editDel.ShowDialog();
        }

        private void mnuiEditProcedureTypes_Click(object sender, EventArgs e)
        {
            frmEditDel editDel = new frmEditDel("tblProcedures");
            editDel.ShowDialog();
        }        
    }
}
