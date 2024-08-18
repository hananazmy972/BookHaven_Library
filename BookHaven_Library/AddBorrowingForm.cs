using BookHaven_Library.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
    public partial class AddBorrowingForm : Form
    {
        public string data;
        BindingSource source;
        public event Action DataUpdated;
        string connectionString = "Server=.;Database=BookHaven_Library;Trusted_Connection=True;TrustServerCertificate=True;";
        public AddBorrowingForm()
        {
            InitializeComponent();
            fill_data();

        }
        public void fill_date()
        {
            BorrowdateTimePicker.Value = DateTime.Now;
            // due date 
            DuedateTimePicker.Value = DateTime.Now.AddDays(15);
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
            fill_date();
            fill_Member();
            fill_Book();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            int selectedBookID = (int)BookComboBox.SelectedValue;
            int selectedMemberID = (int)MemberComboBox.SelectedValue;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //Query 1: Check Available Copies
                string query1 = "SELECT AvailableCopies FROM Book WHERE BookID = @BookID";
                SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("@BookID", selectedBookID);
                int availableCopies = (int)cmd1.ExecuteScalar();

                //Query 2: Check if the member already borrowed the book
                string query2 = "SELECT COUNT(*) FROM Borrowing WHERE MemberID = @MemberID AND BookID = @BookID AND ReturnDate IS NULL";
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                cmd2.Parameters.AddWithValue("@MemberID", selectedMemberID);
                cmd2.Parameters.AddWithValue("@BookID", selectedBookID);
                int existingBorrowCount = (int)cmd2.ExecuteScalar();

                if (availableCopies > 0 && existingBorrowCount == 0)
                {
                    // Add a new borrowing record
                    Borrowing newBorrowing = new Borrowing
                    {
                        MemberID = selectedMemberID,
                        BookID = selectedBookID,
                        BorrowDate = BorrowdateTimePicker.Value,
                        DueDate = DuedateTimePicker.Value,
                        ReturnDate = null
                    };

                    add_Borrow(newBorrowing);
                    MessageBox.Show("Book borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (availableCopies == 0)
                {
                    MessageBox.Show("No available copies of this book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (existingBorrowCount > 0)
                {
                    MessageBox.Show("This member has already borrowed this book and hasn't returned it yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }
        }

        private bool ValidateInput()
        {
            if (MemberComboBox.SelectedIndex == -1 || MemberComboBox.Text == "Select Member")
            {
                MessageBox.Show("Please select a valid member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (BookComboBox.SelectedIndex == -1 || BookComboBox.Text == "Select Book")
            {
                MessageBox.Show("Please select a valid book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void add_Borrow(Borrowing borrowing)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Borrowing (MemberID, BookID, BorrowDate, DueDate) VALUES (@MemberID, @BookID, @BorrowDate, @DueDate)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@MemberID", borrowing.MemberID);
                command.Parameters.AddWithValue("@BookID", borrowing.BookID);
                command.Parameters.AddWithValue("@BorrowDate", borrowing.BorrowDate);
                command.Parameters.AddWithValue("@DueDate", borrowing.DueDate);

                connection.Open();
                command.ExecuteNonQuery();

                // Update the available copies in the Book table
                string updateCopiesQuery = "UPDATE Book SET AvailableCopies = AvailableCopies - 1 WHERE BookID = @BookID";
                SqlCommand updateCopiesCommand = new SqlCommand(updateCopiesQuery, connection);
                updateCopiesCommand.Parameters.AddWithValue("@BookID", borrowing.BookID);
                updateCopiesCommand.ExecuteNonQuery();

                connection.Close();
            }

            // Trigger the DataUpdated event to refresh the main form data
            DataUpdated?.Invoke();
        }


    }
}
