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
    public partial class Borrowings : Form
    {
        public string data;
        BindingSource source;
        public event Action DataUpdated;
        string connectionString = "Server=.;Database=BookHaven_Library;Trusted_Connection=True;TrustServerCertificate=True;";

        public Borrowings()
        {
            InitializeComponent();
            BorrowingsGridView.DataSource = GetData_Connected();
        }

        private void Back_Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BorrowingsGridView.DataSource = GetData_Connected();
        }
        public List<Object> GetData_Connected()
        {
            List<Object> borrowings = new List<Object>();
            string query = $@"SELECT B.BorrowID , Concat(M.FirstName,' ', M.LastName) AS MemberName ,BK.Title, B.BorrowDate,B.DueDate ,B.ReturnDate
                             FROM Borrowing B 
	                         JOIN Member M ON B.MemberID = M.MemberID
	                         JOIN Book BK ON B.BookID = BK.BookID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        borrowings.Add(new
                        {
                            BorrowID = reader.GetInt32("BorrowID"),
                            MemberName = reader["MemberName"].ToString(),
                            BookName = reader["Title"].ToString(),
                            BorrowDate = reader.GetDateTime(reader.GetOrdinal("BorrowDate")),
                            DueDate = reader.GetDateTime(reader.GetOrdinal("DueDate")),
                            ReturnDate = reader.IsDBNull(reader.GetOrdinal("ReturnDate"))
                        ? (DateTime?)null
                        : reader.GetDateTime(reader.GetOrdinal("ReturnDate"))
                        });
                    }
                }
            }

            return borrowings;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddBorrowingForm borrow = new AddBorrowingForm();
            borrow.ShowDialog();    
            this.Hide();    
        }
    }
}
