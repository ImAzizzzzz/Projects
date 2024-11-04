using Gestion_D_Un_Café;
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

namespace Gestion_D_un_Café
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SeConnecterBtn_Click(object sender, EventArgs e)
        {
            if (NomTb.Text == "" || MotPasseTb.Text == "")
            {
                MessageBox.Show("Info Incomplete!!!");
            }
            else if (NomTb.Text == "Aziz" && MotPasseTb.Text == "Aziz1234")
            {
                Categories obj = new Categories();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Info Incorrecte!!!");
                NomTb.Text = "";
                MotPasseTb.Text = "";
            }
        }

        private void MotPasseTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.linkedin.com/in/mohamed-aziz-abed-713237253/";
            Process.Start(url);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.facebook.com/aziz.abed.255";
            Process.Start(url);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.instagram.com/aziz._.abed/";
            Process.Start(url);
        }
    }
}
