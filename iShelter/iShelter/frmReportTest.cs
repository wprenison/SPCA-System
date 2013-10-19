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
using System.Diagnostics;

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
        string gender;
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
            dgvReport.Columns[14].Visible = false;

        }

        private void dgvReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCells = dgvReport.SelectedCells;

            //Retrieve required report data
            animalID = selectedCells[0].Value.ToString();
            name = selectedCells[1].Value.ToString();
            species = selectedCells[2].Value.ToString();
            breed = selectedCells[3].Value.ToString();
            gender = selectedCells[4].Value.ToString();
            dateRecieved = selectedCells[5].Value.ToString();
            illnesses = selectedCells[6].Value.ToString();
            injuries = selectedCells[7].Value.ToString();
            notes = selectedCells[8].Value.ToString();
            roomNo = selectedCells[9].Value.ToString();
            neutered = selectedCells[10].Value.ToString();
            age = selectedCells[11].Value.ToString();
            agroRating = selectedCells[12].Value.ToString();
            photoDir = selectedCells[13].Value.ToString();
            guardianID = selectedCells[14].Value.ToString();
        }

        private void btnGenPDF_Click(object sender, EventArgs e)
        {
           //Create and Write pdf file with the paragraph from the para textbox
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Shadow\Documents\iShelterReports\Animal" + animalID + "Report.pdf", FileMode.Create));
            doc.Open();
            writer.ClearTextWrap();

            //Backgorund
            /*iTextSharp.text.Image bgPic = iTextSharp.text.Image.GetInstance(@"D:\VC Work\C#\Semester2\Assignment3\SPCA-System\PdfBgImg.png");
            bgPic.Alignment = iTextSharp.text.Image.UNDERLYING;
            bgPic.ScalePercent(300f);
            doc.Add(bgPic);*/

            //Insert Logo img
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"D:\VC Work\C#\Semester2\Assignment3\SPCA-System\Logo.jpg");
            logo.ScalePercent(30f);
            doc.Add(logo);

            //Insert todays date top right corner
            Paragraph todaysDate = new Paragraph(DateTime.Now.ToString());
            todaysDate.IndentationLeft = 500f;
            doc.Add(todaysDate);

            //Insert Title
            Paragraph title = new Paragraph("Specific Animal Report", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14f, iTextSharp.text.Font.BOLD));
            title.IndentationLeft = 215f;
            doc.Add(title);

            //Rule trough
            Paragraph lineTrough = new Paragraph("________________________________________________________________________________________");
            doc.Add(lineTrough);

            //Animal Details
            string line1 = string.Format("\n\n{0,-65}{1,-70}{2,-65}\n", "Animal ID: " + animalID, "", "Agro Rating: " + agroRating);
            string line2 = string.Format("{0,-65}{1,-55}{2,-65}\n", "Name: " + name, "Species: " + species, "Breed: " + breed);
            string line3 = string.Format("{0,-72}{1,-59}{2,-65}\n", "Age: " + age, "Gender: F", "Nuetered: " + neutered);
            string line4 = "________________________________________________________________________________________\n";
            Chunk animalDetails = new Chunk(line1 + line2 + line3 + line4);
            doc.Add(animalDetails);

            PdfPTable descDetailsTable = new PdfPTable(3);
            iTextSharp.text.Font headingFont = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14f, iTextSharp.text.Font.BOLD);

            //Row1
            Phrase heading1 = new Phrase("    Illnesses", headingFont);
            Phrase heading2 = new Phrase("      Injuries", headingFont);
            Phrase heading3 = new Phrase("        Notes", headingFont);
            descDetailsTable.AddCell(heading1);
            descDetailsTable.AddCell(heading2);
            descDetailsTable.AddCell(heading3);

            //Row2
            descDetailsTable.AddCell(illnesses);
            descDetailsTable.AddCell(injuries);
            descDetailsTable.AddCell(notes);

            doc.Add(descDetailsTable);
            
            //Animal Pic
            iTextSharp.text.Image animalPic = iTextSharp.text.Image.GetInstance(@"D:\VC Work\C#\Semester2\Assignment3\SPCA-System\Logo.jpg");
            animalPic.ScalePercent(30f);
            animalPic.SetAbsolutePosition(doc.PageSize.Width - 320f, doc.PageSize.Height - 240f);
            doc.Add(animalPic);
            
            doc.Close();

            //Open Report
            Process.Start(@"C:\Users\Shadow\Documents\iShelterReports\Animal" + animalID + "Report.pdf");
        }

        private void wmtxtbSearchTerm_TextChanged(object sender, EventArgs e)
        {
            DataView dvFiltering = new DataView(dbTable.Tables[0]);

            if (wmtxtbSearchTerm.Text != "")
            {
                try
                {
                    dvFiltering.RowFilter = "AnimalID = " + wmtxtbSearchTerm.Text;
                    dgvReport.DataSource = dvFiltering;
                }
                catch (EvaluateException)
                {
                    dvFiltering.RowFilter = "Name LIKE '" + wmtxtbSearchTerm.Text + "%'";
                    dgvReport.DataSource = dvFiltering;
                }
                catch (SyntaxErrorException see)
                {
                    wmtxtbSearchTerm.Clear();
                    dgvReport.DataSource = dbTable.Tables[0];
                    MessageBox.Show("Error no field contains such syntax, please refrain from using it. : " + see.Message);
                }
            }
        }
    }
}
