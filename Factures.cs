using Gestion_D_Un_Café;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Globalization;
using System.IO;
using System.Diagnostics;
using Font = System.Drawing.Font;

namespace Gestion_D_un_Café
{
    public partial class Factures : Form
    {
        public Factures()
        {
            InitializeComponent();
            Con = new Fonctions(); // Initialize the Con object
            AfficherArticles();
        }

        Fonctions Con;
        private void AfficherArticles()
        {
            string Req = "Select ArtCode as Code,Nom,Prix as [Prix En DT] from ArticleTb1";
            ListeArticles.DataSource = Con.RecupererData(Req); // Set the data source for the ListeArticles DataGridView
        }

        int n = 0;
        int Total;
        int GrdTotal = 0;
        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            if ((ArticleTb.Text == "" || ClientTb.Text == "" || QuantitéTb.Text == "") || (ArticleTb.Text == "Article" || ClientTb.Text == "Client" || QuantitéTb.Text == "Quantité"))
            {
                MessageBox.Show("Missing Data!!!"); 
            }
            else
            {
                if (Int32.TryParse(QuantitéTb.Text,out int Qte))
                {
                    Total = Qte * Prix;
                }

                // Create a new row for the ListeFacture DataGridView
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(ListeFacture);

                // Set the values for the cells in the new row
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ArticleTb.Text;
                newRow.Cells[2].Value = Prix + "";
                newRow.Cells[3].Value = Qte;
                newRow.Cells[4].Value = Total;

                ListeFacture.Rows.Add(newRow); // Add the new row to the ListeFacture DataGridView

                n++;
                GrdTotal = GrdTotal + Total;

                MontantLbl.Text = GrdTotal + " DT"; // Update the Total
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        int Prix;
        private void ListeArticles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ArticleTb.Text = ListeArticles.SelectedRows[0].Cells[1].Value.ToString(); // Set the ArticleTb text box to the selected article name
            Prix = Convert.ToInt32(ListeArticles.SelectedRows[0].Cells[2].Value.ToString()); // Set the Prix variable to the selected article price
        }

        private void ImprimerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Nom = ClientTb.Text;
                string Req = "Insert into FactureTb1 values('{0}','{1}',{2})";
                Req = string.Format(Req, DateTb.Value.Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), Nom, GrdTotal);
                Con.EnvoyerData(Req);

                // Create a new PDF document and set the file path
                Document doc = new Document(new iTextSharp.text.Rectangle(290,600));
                string filePath = "Facture.pdf";
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                // Open the document for writing
                doc.Open();
                
                // Write the document details
                Paragraph title = new Paragraph("L'Espresso Cozy Ticket");
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                doc.Add(new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))));
                doc.Add(new Paragraph("Client: " + Nom));
                doc.Add(new Paragraph("Date : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)));
                doc.Add(new Paragraph("Orders:"));
                n = 0;
                foreach (DataGridViewRow row in ListeFacture.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string articleName = row.Cells[1].Value.ToString();
                        string quantity = row.Cells[3].Value.ToString();
                        string price = row.Cells[2].Value.ToString();
                        int total = Convert.ToInt32(row.Cells[4].Value);

                        doc.Add(new Paragraph($"               {n + 1}. {articleName} x {quantity} = {total} DT"));
                        n++;
                    }
                }


                Paragraph totalParagraph = new Paragraph("Total : " + GrdTotal + " DT");
                totalParagraph.Alignment = Element.ALIGN_RIGHT;
                doc.Add(new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1))));
                doc.Add(totalParagraph);

                // Close the document
                doc.Close();

                MessageBox.Show("Facture Enregistrée!!!");
                AfficherArticles();
                ClientTb.Text = "";
                string url = "file:///C:\\Users\\abedh\\OneDrive\\Desktop\\IHEC\\Semestre 2\\10 - Programmation Evénementielle\\Projects\\1 - Gestion D'un Café PDF\\Gestion D'un Café\\bin\\Debug\\Facture.pdf";
                Process.Start(url);
                Articles Obj = new Articles();
                Obj.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Connexion Obj = new Connexion();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Articles Obj = new Articles();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();
        }

        private void ReinitaliserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListeFacture.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in ListeFacture.SelectedRows)
                    {
                        int totalToRemove = Convert.ToInt32(row.Cells[4].Value);
                        GrdTotal -= totalToRemove;
                        ListeFacture.Rows.Remove(row);
                    }
                    MontantLbl.Text = GrdTotal + " DT"; //Update Total
                }
                else
                {
                    MessageBox.Show("Please select the row(s) you want to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListeFacture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
