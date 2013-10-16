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
        WebCam webcam;
        public iShelter()
        {
            InitializeComponent();
            //Set as default Canine
            cmbSpecies.SelectedIndex = 1;

            //Webcam object
            webcam = new WebCam();
            webcam.InitializeWebCam(ref picbAnimal);
            webcam.ResolutionSetting();
            webcam.Start();
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
                string errorMsg = "The following fiel was not completed: ";

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
                    SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.DbConnString);
                    sqlConn.Open();
                    string sql = "INSERT INTO tblAnimals (Name, Species, Breed, DateRecieved, Illnesses, Injuries, Notes, RoomNo, Neutered, EstimatedAge, AgroRating)" +
                                   " VALUES (@Name, @Species, @Breed, @DateRecieved, @Illnesses, @Injuries, @Notes, @RoomNo, @Neutered, @EstimatedAge, @AgroRating)";

                    SqlCommand sqlCmd = new SqlCommand(sql, sqlConn);

                    sqlCmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtbName.Text;
                    sqlCmd.Parameters.Add("@Species", SqlDbType.VarChar).Value = cmbSpecies.SelectedItem.ToString();
                    sqlCmd.Parameters.Add("@Breed", SqlDbType.VarChar).Value = txtbBreed.Text;
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

                    sqlCmd.ExecuteNonQuery();
                    sqlConn.Close();

                    MessageBox.Show("Animal Succesfully Added", "Info");

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTakePic_Click(object sender, EventArgs e)
        {
            Image pic = picbAnimal.Image;
            webcam.Stop();
        }
    }
}
