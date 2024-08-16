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
    public partial class AddMemberForm : Form
    {
        string connectionString = "Server=.;Database=BookHaven_Library;Trusted_Connection=True;TrustServerCertificate=True;";
        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string comm = @$"INSERT INTO Member (FirstName ,LastName ,Email ,PhoneNumber ,JoinDate ) 
                               VALUES (@FirstName ,@LastName ,@Email ,@PhoneNumber ,@JoinDate);";

                using (SqlCommand command = new SqlCommand(comm, connection))
                {
                  
                    command.Parameters.AddWithValue("@FirstName", FirstName_txtBox.Text);
                    command.Parameters.AddWithValue("@LastName", LastName_txtBox.Text);
                    command.Parameters.AddWithValue("@Email", Email_txtBox.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber_txtBox.Text);
                    command.Parameters.AddWithValue("@JoinDate", (DateTime)dateTimePicker1.Value);
              

                    connection.Open();

                    int rows = command.ExecuteNonQuery();
                    MessageBox.Show($"Updated!{rows}");

                }
            }
        }
    }
}
