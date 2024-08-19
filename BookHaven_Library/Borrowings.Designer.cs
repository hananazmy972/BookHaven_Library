namespace BookHaven_Library
{
    partial class Borrowings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borrowings));
            panel1 = new Panel();
            SearchName = new TextBox();
            Name = new Label();
            btnSearch = new Button();
            DisplayOverDue = new Button();
            btnReturn = new Button();
            btnNew = new Button();
            btnRefresh = new Button();
            BorrowingsGridView = new DataGridView();
            label1 = new Label();
            Back_Home = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BorrowingsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Back_Home).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(SearchName);
            panel1.Controls.Add(Name);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(DisplayOverDue);
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(BorrowingsGridView);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(60, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 611);
            panel1.TabIndex = 1;
            // 
            // SearchName
            // 
            SearchName.Location = new Point(427, 146);
            SearchName.Name = "SearchName";
            SearchName.Size = new Size(154, 27);
            SearchName.TabIndex = 29;
            SearchName.TextChanged += SearchName_TextChanged;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name.Location = new Point(257, 142);
            Name.Name = "Name";
            Name.Size = new Size(164, 28);
            Name.TabIndex = 28;
            Name.Text = "Member Name :";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SeaShell;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.TopLeft;
            btnSearch.Location = new Point(218, 142);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(33, 32);
            btnSearch.TabIndex = 25;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // DisplayOverDue
            // 
            DisplayOverDue.BackColor = Color.Brown;
            DisplayOverDue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DisplayOverDue.Location = new Point(659, 134);
            DisplayOverDue.Name = "DisplayOverDue";
            DisplayOverDue.Size = new Size(241, 42);
            DisplayOverDue.TabIndex = 23;
            DisplayOverDue.Text = "Display Overdue Borrowings";
            DisplayOverDue.UseVisualStyleBackColor = false;
            DisplayOverDue.Click += DisplayOverDue_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.DimGray;
            btnReturn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = SystemColors.ButtonFace;
            btnReturn.Location = new Point(89, 409);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(103, 85);
            btnReturn.TabIndex = 22;
            btnReturn.Text = "Return Book";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.DimGray;
            btnNew.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = SystemColors.ButtonFace;
            btnNew.Location = new Point(89, 261);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(103, 85);
            btnNew.TabIndex = 21;
            btnNew.Text = "New Borrowing";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(921, 134);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 42);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // BorrowingsGridView
            // 
            BorrowingsGridView.BackgroundColor = SystemColors.ButtonHighlight;
            BorrowingsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BorrowingsGridView.GridColor = Color.Black;
            BorrowingsGridView.Location = new Point(218, 185);
            BorrowingsGridView.Name = "BorrowingsGridView";
            BorrowingsGridView.RowHeadersWidth = 51;
            BorrowingsGridView.Size = new Size(808, 387);
            BorrowingsGridView.TabIndex = 13;
            // 
            // label1
            // 
            label1.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(289, 44);
            label1.Name = "label1";
            label1.Size = new Size(439, 40);
            label1.TabIndex = 0;
            label1.Text = "Borrowing and Returning";
            // 
            // Back_Home
            // 
            Back_Home.ErrorImage = null;
            Back_Home.Image = (Image)resources.GetObject("Back_Home.Image");
            Back_Home.Location = new Point(5, 12);
            Back_Home.Name = "Back_Home";
            Back_Home.Size = new Size(49, 57);
            Back_Home.TabIndex = 2;
            Back_Home.TabStop = false;
            Back_Home.Click += Back_Home_Click;
            // 
            // Borrowings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(1118, 597);
            Controls.Add(Back_Home);
            Controls.Add(panel1);
            Text = "Borrowings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BorrowingsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)Back_Home).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRefresh;
        public DataGridView BorrowingsGridView;
        private Label label1;
        private Button btnReturn;
        private Button btnNew;
        private PictureBox Back_Home;
        private Button DisplayOverDue;
        private Button btnSearch;
        private Label Name;
        private TextBox SearchName;
    }
}