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
            if (!ValidateInput())
                return;
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
                    this.Hide();
               
                }
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(title_txtBox.Text))
            {
                MessageBox.Show("Title cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(author_txtBox.Text))
            {
                MessageBox.Show("Author cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(isbn_txtBox.Text))
            {
                MessageBox.Show("ISBN cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(year_txtBox.Text, out int year) || year <= 0)
            {
                MessageBox.Show("Please enter a valid publication year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((int)Category_txtBox.SelectedValue == 0)
            {
                MessageBox.Show("Please select a valid category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(copies_txtBox.Text, out int copies) || copies < 0)
            {
                MessageBox.Show("Total copies must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(Av_copies_txtBox.Text, out int avCopies) || avCopies < 0 || avCopies > copies)
            {
                MessageBox.Show("Available copies must be a positive integer and cannot exceed total copies.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
