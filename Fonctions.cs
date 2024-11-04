using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Gestion_D_Un_Café
{
    internal class Fonctions
    {
        // Declare instance variables
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private string ConStr;
        private SqlDataAdapter Sda;

        // Method to send data to the database
        public int EnvoyerData(string Req)
        {
            int cnt;

            // Check if the SqlConnection object is closed
            if (Con.State == ConnectionState.Closed)
            {
                // Open the SqlConnection object
                Con.Open();
            }

            // Set the Command Text property of the SqlCommand object to the input query
            Cmd.CommandText = Req;

            // Execute the query and get the number of rows affected
            cnt = Cmd.ExecuteNonQuery();

            // Close the SqlConnection object
            Con.Close();

            // Return the number of rows affected
            return cnt;
        }

        // Method to retrieve data from the database
        public DataTable RecupererData(String Req)
        {
            // Initialize the DataTable object
            dt = new DataTable();

            // Initialize the SqlDataAdapter object with the input query and Connection String
            Sda = new SqlDataAdapter(Req, ConStr);

            // Fill the DataTable object with the data from the database
            Sda.Fill(dt);

            // Return the DataTable object
            return dt;
        }
        // Constructor
        public Fonctions()
        {
            // Initialize the Connection String
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abedh\OneDrive\Documents\CafeGestionBD.mdf;Integrated Security=True;Connect Timeout=30";

            // Initialize the SqlConnection object with the Connection String
            Con = new SqlConnection(ConStr);

            // Initialize the SqlCommand object with the SqlConnection object
            Cmd = new SqlCommand();

            Cmd.Connection = Con;
        }
    }
}
