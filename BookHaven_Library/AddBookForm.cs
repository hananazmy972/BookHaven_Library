using BookHaven_Library.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace BookHaven_Library
{
    public partial class AddBookForm : Form
    {

        string connectionString = "Server=.;Database=BookHaven_Library;Trusted_Connection=True;TrustServerCertificate=True;";
        public AddBookForm()
        {
            InitializeComponent();
            fill_compo();
        }
        private void fill_compo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand comm = new SqlCommand("SELECT CategoryID, CategoryName FROM Category", connection);
                    SqlDataReader adpt = comm.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(adpt);

                    Category_txtBox.DisplayMember = "CategoryName"; // What the user sees
                    Category_txtBox.ValueMember = "CategoryID";    // What you want to get
                    Category_txtBox.DataSource = table;
                    Category_txtBox.Text = "Select a Category";
                   

                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error connecting to the database: {ex.Message}");
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string comm = @$"INSERT INTO Book (Title ,Author ,ISBN ,PublicationYear ,CategoryID ,TotalCopies, AvailableCopies) 
                               VALUES (@Title ,@Author ,@ISBN ,@PublicationYear ,@CategoryID ,@TotalCopies, @AvailableCopies);";

                using (SqlCommand command = new SqlCommand(comm, connection))
                {
                    command.Parameters.AddWithValue("@Title", title_txtBox.Text);
                    command.Parameters.AddWithValue("@Author", author_txtBox.Text);
                    command.Parameters.AddWithValue("@ISBN", isbn_txtBox.Text);
                    command.Parameters.AddWithValue("@PublicationYear", year_txtBox.Text);
                    command.Parameters.AddWithValue("@CategoryID", (int)Category_txtBox.SelectedValue);
                    command.Parameters.AddWithValue("@TotalCopies", copies_txtBox.Text);
                    command.Parameters.AddWithValue("@AvailableCopies", Av_copies_txtBox.Text);

                    connection.Open();

                    int rows = command.ExecuteNonQuery();
                    MessageBox.Show($"Updated!{rows}");
               
                }
            }
        }
    }
}
