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
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(BorrowingsGridView);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(58, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 552);
            panel1.TabIndex = 1;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(68, 335);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 65);
            btnReturn.TabIndex = 22;
            btnReturn.Text = "Return Book";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(68, 229);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 65);
            btnNew.TabIndex = 21;
            btnNew.Text = "New Borrowing";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(923, 74);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // BorrowingsGridView
            // 
            BorrowingsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BorrowingsGridView.Location = new Point(209, 109);
            BorrowingsGridView.Name = "BorrowingsGridView";
            BorrowingsGridView.RowHeadersWidth = 51;
            BorrowingsGridView.Size = new Size(808, 387);
            BorrowingsGridView.TabIndex = 13;
            // 
            // label1
            // 
            label1.Font = new Font("Century", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(324, 40);
            label1.Name = "label1";
            label1.Size = new Size(330, 40);
            label1.TabIndex = 0;
            label1.Text = "Manage Borrowings";
            // 
            // Back_Home
            // 
            Back_Home.Image = (Image)resources.GetObject("Back_Home.Image");
            Back_Home.Location = new Point(3, 25);
            Back_Home.Name = "Back_Home";
            Back_Home.Size = new Size(58, 57);
            Back_Home.TabIndex = 2;
            Back_Home.TabStop = false;
            Back_Home.Click += Back_Home_Click;
            // 
            // Borrowings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 534);
            Controls.Add(Back_Home);
            Controls.Add(panel1);
            Name = "Borrowings";
            Text = "Borrowings";
            panel1.ResumeLayout(false);
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
    }
}