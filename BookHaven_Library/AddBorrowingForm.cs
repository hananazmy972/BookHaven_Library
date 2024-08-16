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
    }
}
