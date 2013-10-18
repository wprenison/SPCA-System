using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data.SqlClient;

namespace iShelter
{
    public partial class frmReportTest : Form
    {
        public frmReportTest()
        {
            InitializeComponent();
        }
        DataSet dbTable = new DataSet();

        string animalID;
        string name;
        string species;
        string breed;
        string dateRecieved;
        string illnesses;
        string injuries;
        string notes;
        string roomNo;
        string neutered;
        string age;
        string agroRating;
        string photoDir;
        string guardianID;

        private void frmReportTest_Load(object sender, EventArgs e)
        {
            //Perpare sql string
            string sql = "SELECT * FROM tblAnimals";

            //Create & Open Connection
            SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.DbConnString);
            sqlConn.Open();

            //Create a data adapter to fill a dataset
            SqlDataAdapter dbAdapter = new SqlDataAdapter(sql, sqlConn);

            // Fill dataset
            dbAdapter.Fill(dbTable);

            //Set data source for the grid view
            dgvReport.DataSource = dbTable.Tables[0];

            sqlConn.Close();

            //Edit Columns visibility
            dgvReport.Columns[4].Visible = false;
            dgvReport.Columns[5].Visible = false;
            dgvReport.Columns[6].Visible = false;
            dgvReport.Columns[7].Visible = false;
            dgvReport.Columns[8].Visible = false;
            dgvReport.Columns[9].Visible = false;
            dgvReport.Columns[10].Visible = false;
            dgvReport.Columns[11].Visible = false;
            dgvReport.Columns[12].Visible = false;
            dgvReport.Columns[13].Visible = false;

        }

        private void dgvReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCells = dgvReport.SelectedCells;

            //Retrieve required report data
            animalID = selectedCells[0].Value.ToString();
            name = selectedCells[1].Value.ToString();
            species = selectedCells[2].Value.ToString();
            breed = selectedCells[3].Value.ToString();
            dateRecieved = selectedCells[4].Value.ToString();
            illnesses = selectedCells[5].Value.ToString();
            injuries = selectedCells[6].Value.ToString();
            notes = selectedCells[7].Value.ToString();
            roomNo = selectedCells[8].Value.ToString();
            neutered = selectedCells[9].Value.ToString();
            age = selectedCells[10].Value.ToString();
            agroRating = selectedCells[11].Value.ToString();
            photoDir = selectedCells[12].Value.ToString();
            guardianID = selectedCells[13].Value.ToString();
        }

        private void btnGenPDF_Click(object sender, EventArgs e)
        {           
            //Create and Write pdf file with the paragraph from the para textbox
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Shadow\Documents\iShelterReports\Animal" + animalID + "Report.pdf", FileMode.Create));
            doc.Open();
            
            //Insert Logo img
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"D:\VC Work\C#\Semester2\Assignment3\SPCA-System\Logo.jpg");
            logo.ScalePercent(30f);
            doc.Add(logo);

            //Insert todays date top right corner
            Paragraph todaysDate = new Paragraph(DateTime.Now.ToString());
            todaysDate.IndentationLeft = 500f;
            doc.Add(todaysDate);

            //Insert Title
            Paragraph title = new Paragraph("Specific Animal Report");
            title.IndentationLeft = 250f;
            doc.Add(title);

            //Rule trough
            Paragraph lineTrough = new Paragraph("________________________________________________________________________________________");
            doc.Add(lineTrough);

            //Animal Details
            Paragraph animalDetails = new Paragraph("Animal ID: " + animalID + "                                                                                                                                 AgroRating: " + agroRating);
            doc.Add(animalDetails);

            //Animal Pic
            iTextSharp.text.Image animalPic = iTextSharp.text.Image.GetInstance(@"D:\VC Work\C#\Semester2\Assignment3\SPCA-System\Logo.jpg");
            animalPic.ScalePercent(30f);
            animalPic.SetAbsolutePosition(doc.PageSize.Width - 320f, doc.PageSize.Height - 240f);
            doc.Add(animalPic);
            
            
            doc.Close();
        }
    }
}
