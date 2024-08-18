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
            if(!ValidateInput())
            {
                return;
            }
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
                    this.Hide();
                }
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(FirstName_txtBox.Text))
            {
                MessageBox.Show("First name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(LastName_txtBox.Text))
            {
                MessageBox.Show("Last name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(Email_txtBox.Text))
            {
                MessageBox.Show("Email cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsValidEmail(Email_txtBox.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(PhoneNumber_txtBox.Text))
            {
                MessageBox.Show("Phone number cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsValidPhoneNumber(PhoneNumber_txtBox.Text))
            {
                MessageBox.Show("Please enter a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Add your phone number validation logic here
            return true; // Placeholder, replace with actual logic
        }
    }
}
