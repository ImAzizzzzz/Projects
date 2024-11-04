using Gestion_D_un_Café;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gestion_D_Un_Café
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent(); 
            Con = new Fonctions(); // Creating an instance of the Fonctions class
            AfficherCategorie();
        }
        Fonctions Con;
        private void AfficherCategorie()
        {
            string Req = "Select * from CategorieTb1";
            ListeCategorie.DataSource = Con.RecupererData(Req); // Setting the data source of the ListeCategorie DataGridView to the result of the RecupererData method of the Con object
        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            if (NomTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Info Incomplete!!!");
            }
            else
            {
                try
                {
                    string Nom = NomTb.Text;
                    string Desc = DescTb.Text;
                    string Req = "insert into CategorieTb1 values('{0}','{1}')";
                    Req = string.Format(Req, Nom, Desc); // Format the SQL query with the variable values
                    Con.EnvoyerData(Req);
                    MessageBox.Show("Categorie Enregistrée!!!");
                    AfficherCategorie();
                    NomTb.Text = "";
                    DescTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

        }
        int Cle = 0;
        private void ListeCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModiferBtn_Click(object sender, EventArgs e)
        {
            if (NomTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Info Incomplete!!!");
            }
            else
            {
                try
                {
                    string Nom = NomTb.Text;
                    string Desc = DescTb.Text;
                    string Req = "Update CategorieTb1 set CatNom = '{0}',CatDesc = '{1}' where CatCode = {2}";
                    Req = string.Format(Req, Nom, Desc, Cle); // Format the SQL query with the variable values
                    Con.EnvoyerData(Req);
                    MessageBox.Show("Categorie Modifiée!!!");
                    AfficherCategorie();
                    NomTb.Text = "";
                    DescTb.Text = "";
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
                MessageBox.Show("Sélectionnez Une Catégorie!!!");
            }
            else
            {
                try
                {
                    string Nom = NomTb.Text;
                    string Desc = DescTb.Text;
                    string Req = "Delete from CategorieTb1 where CatCode = '{0}'";
                    Req = string.Format(Req, Cle); // Format the SQL query with the Cle variable value
                    Con.EnvoyerData(Req);
                    MessageBox.Show("Categorie Supprimée!!!");
                    AfficherCategorie();
                    NomTb.Text = "";
                    DescTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Articles Obj = new Articles();
            Obj.Show();
            this.Hide();
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
        
        private void ListeCategorie_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Set the text of the NomTb textbox to the value of the second cell (index 1) of the selected row
            NomTb.Text = ListeCategorie.SelectedRows[0].Cells[1].Value.ToString();

            // Set the text of the DescTb textbox to the value of the third cell (index 2) of the selected row
            DescTb.Text = ListeCategorie.SelectedRows[0].Cells[2].Value.ToString();

            if (NomTb.Text == "")
            {
                Cle = 0;
            }
            else
            {
                Cle = Convert.ToInt32(ListeCategorie.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
