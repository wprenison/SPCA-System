using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iShelter
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
            txtbSaveLocation.Text = @Properties.Settings.Default.SaveLocation;
            txtbConnString.Text = @Properties.Settings.Default.DbConnString;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowseSaveLocation.ShowDialog();
            txtbSaveLocation.Text = folderBrowseSaveLocation.SelectedPath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Saves setting for save location of reports and images
            Properties.Settings.Default.SaveLocation = @txtbSaveLocation.Text;
            
            //Validates a conn string has been entered
            if (txtbConnString.Text != "")
            {
                Properties.Settings.Default.DbConnString = @txtbConnString.Text;
                Properties.Settings.Default.Save();
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Please enter a Database Connection String");
        }
    }
}
