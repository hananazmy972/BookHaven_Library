using BookHaven_Library.Models;

namespace BookHaven_Library
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BooksBox_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Members members = new Members();
            members.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Borrowings borrowings = new Borrowings();
            borrowings.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }


}
