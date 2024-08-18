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
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BookHaven_Library.Models;
namespace BookHaven_Library
{
    public partial class Books : Form
    {
        public string data;
        BindingSource source;
        public event Action DataUpdated;
        string connectionString = "Server=.;Database=BookHaven_Library;Trusted_Connection=True;TrustServerCertificate=True;";

        public Books()
        {
            InitializeComponent();
            LoadData();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            FillCategoryComboBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddBookForm addBookForm = new AddBookForm())
            {
                addBookForm.ShowDialog(); // Show the form as a modal dialog
            }
            LoadData();
        }

        private void ptnUpdate_Click(object sender, EventArgs e)
        {
            Book book = source.Current as Book;
            if (book != null && book.BookID != 0)
            {
                Update_Book(book);
              
            }
            else
            {
                MessageBox.Show("Please select a record to update.");
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Book book = source.Current as Book;
            if (book != null && book.BookID != 0)
            {
                DeleteBook(book);
                LoadData(); // Reload the data to refresh the DataGridView
                ClearInputs(); // Clear input fields

            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
          
        }
        private void ClearInputs()
        {
            title_txtBox.Text = string.Empty;
            author_txtBox.Text = string.Empty;
            isbn_txtBox.Text = string.Empty;
            year_txtBox.Text = string.Empty;
            Category_txtBox1.SelectedIndex = 0; // Reset to the placeholder value
            copies_txtBox.Text = string.Empty;
            Av_copies_txtBox.Text = string.Empty;
            id_txtBox.Text = string.Empty;

        }


        private void Back_Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void LoadData(int? categoryId = null)
        {
            // Unsubscribe from the SelectionChanged event to prevent it from firing during binding operations
            BookGridView.SelectionChanged -= BookGridView_SelectionChanged;

            // Clear existing bindings to avoid duplicate bindings
            ClearBindings();

            // Fetch data and bind to DataGridView
            BookGridView.DataSource = GetData_Connected(categoryId);

            // Initialize BindingSource and bind text boxes
            if (source == null)
            {
                source = new BindingSource();
            }

            source.DataSource = typeof(Book);

            title_txtBox.DataBindings.Add("Text", source, "Title");
            author_txtBox.DataBindings.Add("Text", source, "Author");
            isbn_txtBox.DataBindings.Add("Text", source, "ISBN");
            year_txtBox.DataBindings.Add("Text", source, "PublicationYear");
            Category_txtBox1.DataBindings.Add("SelectedValue", source, "CategoryID");
            copies_txtBox.DataBindings.Add("Text", source, "TotalCopies");
            Av_copies_txtBox.DataBindings.Add("Text", source, "AvailableCopies");
            id_txtBox.DataBindings.Add("Text", source, "BookID");

            // Re-subscribe to the SelectionChanged event
            BookGridView.SelectionChanged += BookGridView_SelectionChanged;

            // Manually trigger the SelectionChanged event to refresh bindings
            if (BookGridView.Rows.Count > 0)
            {
                BookGridView.Rows[0].Selected = true;
            }
            
        }

        private void ClearBindings()
        {
            title_txtBox.DataBindings.Clear();
            author_txtBox.DataBindings.Clear();
            isbn_txtBox.DataBindings.Clear();
            year_txtBox.DataBindings.Clear();
            Category_txtBox1.DataBindings.Clear();
            copies_txtBox.DataBindings.Clear();
            Av_copies_txtBox.DataBindings.Clear();
            id_txtBox.DataBindings.Clear();
        }

        private void BookGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (BookGridView.SelectedRows.Count > 0)
            {
                var selectedBook = (Book)BookGridView.SelectedRows[0].DataBoundItem;
                source.DataSource = selectedBook;  // This may cause issues if not handled carefully
            }
        }

        private void FillCategoryComboBox()
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

                    // Add a placeholder row for "Select Category"
                    DataRow placeholderRow = table.NewRow();
                    placeholderRow["CategoryID"] = 0; // Use 0 as a special value
                    placeholderRow["CategoryName"] = "Select Category";
                    table.Rows.InsertAt(placeholderRow, 0);

                    Category_txtBox1.DisplayMember = "CategoryName"; // What the user sees
                    Category_txtBox1.ValueMember = "CategoryID";    // What you want to get
                    Category_txtBox1.DataSource = table;

                    Category_txtBox2.DisplayMember = "CategoryName"; 
                    Category_txtBox2.ValueMember = "CategoryID";   
                    Category_txtBox2.DataSource = table;

                    Category_txtBox2.SelectedIndex = 0;

                    // Set the selected index to the placeholder
                    Category_txtBox1.SelectedIndex = 0;
                    Category_txtBox2.SelectedIndex = 0;

                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error connecting to the database: {ex.Message}");
                }
            }
        }

        public List<Book> GetData_Connected(int? categoryId = null)
        {

            List<Book> books = new List<Book>();
            string query = "SELECT BookID, Title, Author, ISBN, PublicationYear, CategoryID, TotalCopies, AvailableCopies FROM Book WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();
            string idText = SearchID.Text;
            string nameText = SearchName.Text;

            if (categoryId.HasValue && categoryId.Value != 0)
            {
                query += " AND CategoryID = @CategoryID";
                parameters.Add(new SqlParameter("@CategoryID", categoryId.Value));
            }

            if (int.TryParse(idText, out int bookID))
            {
                query += " AND BookID = @bookID";
                parameters.Add(new SqlParameter("@bookID", bookID));
            }

            if (!string.IsNullOrEmpty(nameText))
            {
                query += " AND Title LIKE @nameText";
                parameters.Add(new SqlParameter("@nameText", "%" + nameText + "%"));
            }


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters.ToArray());
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book()
                            {
                                BookID = reader.GetInt32("BookID"),
                                Title = reader["Title"].ToString(),
                                Author = reader["Author"].ToString(),
                                ISBN = reader["ISBN"].ToString(),
                                PublicationYear = reader.GetInt32("PublicationYear"),
                                CategoryID = reader.GetInt32("CategoryID"),
                                TotalCopies = reader.GetInt32("TotalCopies"),
                                AvailableCopies = reader.GetInt32("AvailableCopies"),
                            });
                        }
                    }
                }
            }

            return books;
        }
        //Delete Book 
        private void DeleteBook(Book book)
        {
            if (!ValidateInput())
                return;

            string cmd = "DELETE FROM Book WHERE BookID = @BookID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(cmd, conn))
            {
                command.Parameters.AddWithValue("@BookID", book.BookID);

                try
                {
                    conn.Open();
                    int rows = command.ExecuteNonQuery();
                    MessageBox.Show($"Deleted! {rows} row(s) affected.");
                }
                catch (SqlException ex)
                {
                    // Handle foreign key constraint violation (SQL Server error code 547)
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Cannot delete this book because it is referenced by another record.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Update Book
        public void Update_Book(Book book)
        {
            if (!ValidateInput())
                return;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string comm = @$"UPDATE Book SET Title = @Title, Author = @Author, ISBN = @ISBN, PublicationYear = @PublicationYear, CategoryID = @CategoryID, TotalCopies = @TotalCopies, AvailableCopies = @AvailableCopies
                        WHERE BookID = @BookID;";

                using (SqlCommand command = new SqlCommand(comm, connection))
                {
                    command.Parameters.AddWithValue("@Title", book.Title);
                    command.Parameters.AddWithValue("@Author", book.Author);
                    command.Parameters.AddWithValue("@ISBN", book.ISBN);
                    command.Parameters.AddWithValue("@PublicationYear", book.PublicationYear);
                    command.Parameters.AddWithValue("@CategoryID", book.CategoryID);
                    command.Parameters.AddWithValue("@TotalCopies", book.TotalCopies);
                    command.Parameters.AddWithValue("@AvailableCopies", book.AvailableCopies);
                    command.Parameters.AddWithValue("@BookID", book.BookID);

                    try
                    {
                        connection.Open();
                        int rows = command.ExecuteNonQuery();
                        MessageBox.Show($"Updated! {rows} row(s) affected.");
                    }
                    catch (SqlException ex)
                    {
                        // Handle foreign key constraint violation (SQL Server error code 547)
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("Cannot update this book because it is referenced by another record.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        //Filter books by category
        private void Category_txtBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categorySelected = Convert.ToInt32(Category_txtBox2.SelectedValue);
            BookGridView.DataSource = GetData_Connected(categorySelected);
        }

        //Search By ID
        private void SearchID_TextChanged(object sender, EventArgs e)
        {
            BookGridView.DataSource = GetData_Connected();
        }
        //Search By Title
        private void SearchName_TextChanged(object sender, EventArgs e)
        {
            BookGridView.DataSource = GetData_Connected();

        }
        //Extra for Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BookGridView.DataSource = GetData_Connected();

        }

        //Validation
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
                MessageBox.Show("ISBN cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return false;
            }
            if (!int.TryParse(year_txtBox.Text, out int year) || year <= 0 || year > 2024)
            {
                MessageBox.Show("Please enter a valid publication year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
            }
            if ((int)Category_txtBox1.SelectedValue == 0)
            {
                MessageBox.Show("Please select a valid category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return false;
            }
            if (!int.TryParse(copies_txtBox.Text, out int copies) || copies < 0)
            {
                MessageBox.Show("Total copies must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(Av_copies_txtBox.Text, out int avCopies) || avCopies < 0 || avCopies > copies)
            {
                MessageBox.Show("Available copies must be a positive integer and cannot exceed total copies.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}


