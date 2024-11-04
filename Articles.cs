using Gestion_D_Un_Café;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_D_un_Café
{
    public partial class Articles : Form
    {
        public Articles()
        {
            InitializeComponent();
            Con = new Fonctions(); // Creating an instance of the Fonctions class
            AfficherArticles();
            RecupererCategorie();
        }

        Fonctions Con;
        private void AfficherArticles()
        {
            string Req = "Select * from ArticleTb1"; // Define the SQL query to select all columns from the ArticleTb1 table
            ListeArticles.DataSource = Con.RecupererData(Req);
        }

        private void RecupererCategorie()
        {
            string Req = "Select * from CategorieTb1";

            // Set the CategorieCb ComboBox's ValueMember and DisplayMember properties to the CatCode and CatNom columns of the DataTable
            CategorieCb.ValueMember = Con.RecupererData(Req).Columns["CatCode"].ToString(); 
            CategorieCb.DisplayMember = Con.RecupererData(Req).Columns["CatNom"].ToString();

            // Set the CategorieCb ComboBox's DataSource to the DataTable
            CategorieCb.DataSource = Con.RecupererData(Req);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (NomTb.Text == "" || PrixTb.Text == "" || CategorieCb.SelectedIndex == -1)
            {
                MessageBox.Show("Info Incomplete!!!");
            }
            else
            {
                try
                {
                    string Nom = NomTb.Text;
                    int Prix = Convert.ToInt32(PrixTb.Text);
                    string Cat = CategorieCb.SelectedValue.ToString();

                    string Req = "Insert into ArticleTb1 values('{0}',{1},{2},'{3}')";
                    Req = string.Format(Req, Nom, Prix, Cat, DateExp.Value.Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));

                    Con.EnvoyerData(Req);
                    MessageBox.Show("Article Enregistré!!!");
                    AfficherArticles();
                    NomTb.Text = "";
                    PrixTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        
        private void label5_Click(object sender, EventArgs e)
        {
            Categories Obj = new Categories();
            Obj.Show();
            this.Hide();
        }
        int Cle = 0;
        private void ListeCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the values of the selected row and assign them to the corresponding text boxes
            NomTb.Text = ListeArticles.SelectedRows[0].Cells[1].Value.ToString();
            PrixTb.Text = ListeArticles.SelectedRows[0].Cells[2].Value.ToString();
            CategorieCb.Text = ListeArticles.SelectedRows[0].Cells[3].Value.ToString();

            // If the NomTb text is empty, set Cle to 0, otherwise set it to the Article ID
            if (NomTb.Text == "")
            {
                Cle = 0;
            }
            else
            {
                Cle = Convert.ToInt32(ListeArticles.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            if (NomTb.Text == "" || PrixTb.Text == "" || CategorieCb.SelectedIndex == -1)
            {
                MessageBox.Show("Info Incomplete!!!");
            }
            else
            {
                try
                {
                    // Get the values of the text boxes and combobox
                    string Nom = NomTb.Text;
                    int Prix = Convert.ToInt32(PrixTb.Text);
                    string Cat = CategorieCb.SelectedValue.ToString();

                    string Req = "Update ArticleTb1 set Nom = '{0}',Prix = {1},Categorie = {2},DateExp = '{3}' where ArtCode = {4}";
                    Req = string.Format(Req, Nom, Prix, Cat, DateExp.Value.Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),Cle);

                    Con.EnvoyerData(Req);
                    MessageBox.Show("Article Modifié!!!");
                    AfficherArticles();
                    NomTb.Text = "";
                    PrixTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            if (Cle == 0)
            {
                MessageBox.Show("Sélectionnez Un Article!!!");
            }
            else
            {
                try
                {
                    string Nom = NomTb.Text;
                    int Prix = Convert.ToInt32(PrixTb.Text);
                    string Cat = CategorieCb.SelectedValue.ToString();

                    string Req = "Delete from ArticleTb1 where ArtCode = {0}";
                    Req = string.Format(Req, Cle);

                    Con.EnvoyerData(Req);
                    MessageBox.Show("Article Supprimé!!!");
                    AfficherArticles();
                    NomTb.Text = "";
                    PrixTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void NomTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Factures Obj = new Factures();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Connexion Obj = new Connexion();
            Obj.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
