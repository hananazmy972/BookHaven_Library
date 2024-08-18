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
    public partial class Members : Form
    {
        public string data;
        BindingSource source;
        public event Action DataUpdated;
        string connectionString = "Server=.;Database=BookHaven_Library;Trusted_Connection=True;TrustServerCertificate=True;";
        public Members()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddMemberForm addMemeberForm = new AddMemberForm())
            {
                addMemeberForm.ShowDialog(); // Show the form as a modal dialog
                LoadData();
            }
        }

        private void Back_Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Member member = source.Current as Member;
            if (member != null && member.MemberID != 0)
            {
                Delete_Member(member);
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }
        private void ptnUpdate_Click(object sender, EventArgs e)
        {
            Member member = source.Current as Member;
            if (member != null && member.MemberID != 0)
            {
                Update_Member(member);
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a record to Update.");
            }
        }


        public List<Member> GetData_Connected()
        {
            List<Member> members = new List<Member>();
            string query = "SELECT MemberID, FirstName , LastName , Email , PhoneNumber , JoinDate  FROM Member WHERE 1=1";
            List<SqlParameter> parameters = new List<SqlParameter>();
            string nameText = SearchName.Text;

            if (!string.IsNullOrEmpty(nameText))
            {
                query += " AND FirstName LIKE @nameText";
                parameters.Add(new SqlParameter("@nameText", "%" + nameText + "%"));
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddRange(parameters.ToArray());
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        members.Add(new Member()
                        {
                            MemberID = reader.GetInt32("MemberID"),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            JoinDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"))
                        });
                    }
                }
            }

            return members;
        }
        private void MemberGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (MembersGridView.SelectedRows.Count > 0)
            {
                var selectedMember = (Member)MembersGridView.SelectedRows[0].DataBoundItem;
                source.DataSource = selectedMember;  // This may cause issues if not handled carefully
            }
        }

        public void LoadData()
        {
            MembersGridView.SelectionChanged -= MemberGridView_SelectionChanged;
            ClearBindings();
            MembersGridView.DataSource = GetData_Connected();
            // Initialize BindingSource and bind text boxes
            if (source == null)
            {
                source = new BindingSource();
            }

            source.DataSource = typeof(Member);

            MemberID_txtBox.DataBindings.Add("Text", source, "MemberID");
            FirstName_txtBox.DataBindings.Add("Text", source, "FirstName");
            LastName_txtBox.DataBindings.Add("Text", source, "LastName");
            PhoneNumber_txtBox.DataBindings.Add("Text", source, "PhoneNumber");
            Email_txtBox.DataBindings.Add("Text", source, "Email");
            dateTimePicker1.DataBindings.Add("Text", source, "JoinDate");
            // Re-subscribe to the SelectionChanged event
            MembersGridView.SelectionChanged += MemberGridView_SelectionChanged;

            // Manually trigger the SelectionChanged event to refresh bindings
            if (MembersGridView.Rows.Count > 0)
            {
                MembersGridView.Rows[0].Selected = true;
            }
        }

        private void ClearBindings()
        {
            FirstName_txtBox.DataBindings.Clear();
            LastName_txtBox.DataBindings.Clear();
            PhoneNumber_txtBox.DataBindings.Clear();
            Email_txtBox.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            MemberID_txtBox.DataBindings.Clear();
        }

     

        public void Update_Member(Member member)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string comm = @$"UPDATE Member SET FirstName = @FirstName , LastName = @LastName , Email = @Email , PhoneNumber = @PhoneNumber , JoinDate = @JoinDate
                                  WHERE MemberID = @MemberID";
                using (SqlCommand command = new SqlCommand(comm, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", member.FirstName);
                    command.Parameters.AddWithValue("@LastName", member.LastName);
                    command.Parameters.AddWithValue("@Email", member.Email);
                    command.Parameters.AddWithValue("@PhoneNumber", member.PhoneNumber);
                    command.Parameters.AddWithValue("@JoinDate", member.JoinDate);
                    command.Parameters.AddWithValue("@MemberID", member.MemberID);


                    connection.Open();

                    int rows = command.ExecuteNonQuery();
                    MessageBox.Show($"Updated! {rows} row(s) affected.");
                }
            }
        }

        public void Delete_Member(Member member)
        {
            string cmd = "DELETE FROM Member WHERE MemberID = @MemberID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(cmd, conn))
            {
                command.Parameters.AddWithValue("@MemberID", member.MemberID);
                conn.Open();

                int rows = command.ExecuteNonQuery();
                MessageBox.Show($"Deleted! {rows} row(s) affected.");
            }
        }

        private void SearchName_TextChanged(object sender, EventArgs e)
        {

            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
