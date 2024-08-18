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

namespace BookHaven_Library
{
    public partial class ReturnBookForm : Form
    {
        public string data;
        BindingSource source;
        public event Action DataUpdated;
        string connectionString = "Server=.;Database=BookHaven_Library;Trusted_Connection=True;TrustServerCertificate=True;";
        public ReturnBookForm()
        {
            InitializeComponent();
            fill_data();


        }
        public void fill_Member()
        {
            string query = @$"SELECT MemberID , Concat(FirstName , ' ' , LastName) AS Name FROM Member ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader adpt = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(adpt);

                    MemberComboBox.DisplayMember = "Name"; // What the user sees
                    MemberComboBox.ValueMember = "MemberID";    // What you want to get
                    MemberComboBox.DataSource = table;
                    MemberComboBox.Text = "Select Member";

                }
            }
        }
        public void fill_Book()
        {
            string query = @$"SELECT BookID , Title FROM Book ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader adpt = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(adpt);

                    BookComboBox.DisplayMember = "Title";   // What the user sees
                    BookComboBox.ValueMember = "BookID";    // What you want to get
                    BookComboBox.DataSource = table;
                    BookComboBox.Text = "Select Book";

                }
            }
        }

        public void fill_data()
        {
            ReturnDateTimePicker.Value = DateTime.Now;
            fill_Member();
            fill_Book();
        }


        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int selectedBookID = (int)BookComboBox.SelectedValue;
            int selectedMemberID = (int)MemberComboBox.SelectedValue;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query 1: Check if there is an active borrowing record
                string query1 = "SELECT COUNT(*) FROM Borrowing WHERE MemberID = @MemberID AND BookID = @BookID AND ReturnDate IS NULL";
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("@MemberID", selectedMemberID);
                cmd1.Parameters.AddWithValue("@BookID", selectedBookID);
                int existingBorrowCount = (int)cmd1.ExecuteScalar();

                if (existingBorrowCount == 1)
                {
                    // Query 2: Update the borrowing record with the return date
                    string query2 = "UPDATE Borrowing SET ReturnDate = @ReturnDate WHERE MemberID = @MemberID AND BookID = @BookID AND ReturnDate IS NULL";
                    SqlCommand cmd2 = new SqlCommand(query2, connection);
                    cmd2.Parameters.AddWithValue("@ReturnDate", ReturnDateTimePicker.Value);
                    cmd2.Parameters.AddWithValue("@MemberID", selectedMemberID);
                    cmd2.Parameters.AddWithValue("@BookID", selectedBookID);
                    cmd2.ExecuteNonQuery();

                    // Query 3: Update the available copies in the Book table
                    string query3 = "UPDATE Book SET AvailableCopies = AvailableCopies + 1 WHERE BookID = @BookID";
                    SqlCommand cmd3 = new SqlCommand(query3, connection);
                    cmd3.Parameters.AddWithValue("@BookID", selectedBookID);
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Book returned successfully!");
                }
                else
                {
                    MessageBox.Show("No active borrowing record found for this member and book.");
                }

                connection.Close();
            }

            // Optionally, trigger the DataUpdated event to refresh the main form data
            DataUpdated?.Invoke();
            this.Hide();
        }

       
    }
}
