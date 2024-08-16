﻿namespace BookHaven_Library
{
    partial class Books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>s
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            panel1 = new Panel();
            label10 = new Label();
            Name = new Label();
            SearchName = new TextBox();
            SearchID = new TextBox();
            btnSearch = new Button();
            Av_copies_txtBox = new TextBox();
            label9 = new Label();
            Category_txtBox2 = new ComboBox();
            btnDelete = new Button();
            ptnUpdate = new Button();
            btnAdd = new Button();
            Category_txtBox = new ComboBox();
            id_txtBox = new TextBox();
            label8 = new Label();
            BookGridView = new DataGridView();
            copies_txtBox = new TextBox();
            year_txtBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            isbn_txtBox = new TextBox();
            label5 = new Label();
            author_txtBox = new TextBox();
            label4 = new Label();
            title_txtBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Back_Home = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Back_Home).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(Name);
            panel1.Controls.Add(SearchName);
            panel1.Controls.Add(SearchID);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(Av_copies_txtBox);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(Category_txtBox2);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(ptnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(Category_txtBox);
            panel1.Controls.Add(id_txtBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(BookGridView);
            panel1.Controls.Add(copies_txtBox);
            panel1.Controls.Add(year_txtBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(isbn_txtBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(author_txtBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(title_txtBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(62, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 552);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(509, 102);
            label10.Name = "label10";
            label10.Size = new Size(33, 20);
            label10.TabIndex = 28;
            label10.Text = "ID :";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name.Location = new Point(657, 102);
            Name.Name = "Name";
            Name.Size = new Size(48, 20);
            Name.TabIndex = 27;
            Name.Text = "Title :";
            // 
            // SearchName
            // 
            SearchName.Location = new Point(722, 97);
            SearchName.Name = "SearchName";
            SearchName.Size = new Size(86, 27);
            SearchName.TabIndex = 26;
            SearchName.TextChanged += SearchName_TextChanged;
            // 
            // SearchID
            // 
            SearchID.Location = new Point(548, 97);
            SearchID.Name = "SearchID";
            SearchID.Size = new Size(87, 27);
            SearchID.TabIndex = 25;
            SearchID.TextChanged += SearchID_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.TopLeft;
            btnSearch.Location = new Point(470, 94);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(33, 32);
            btnSearch.TabIndex = 24;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Av_copies_txtBox
            // 
            Av_copies_txtBox.Location = new Point(143, 440);
            Av_copies_txtBox.Name = "Av_copies_txtBox";
            Av_copies_txtBox.Size = new Size(125, 27);
            Av_copies_txtBox.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 443);
            label9.Name = "label9";
            label9.Size = new Size(123, 20);
            label9.TabIndex = 22;
            label9.Text = "Availabe Copies ";
            // 
            // Category_txtBox2
            // 
            Category_txtBox2.BackColor = SystemColors.ScrollBar;
            Category_txtBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Category_txtBox2.FormattingEnabled = true;
            Category_txtBox2.Location = new Point(873, 99);
            Category_txtBox2.Name = "Category_txtBox2";
            Category_txtBox2.Size = new Size(141, 28);
            Category_txtBox2.TabIndex = 21;
            Category_txtBox2.Text = "Select Category";
            Category_txtBox2.SelectedIndexChanged += Category_txtBox2_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(166, 491);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(71, 36);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ptnUpdate
            // 
            ptnUpdate.Location = new Point(66, 491);
            ptnUpdate.Name = "ptnUpdate";
            ptnUpdate.Size = new Size(71, 36);
            ptnUpdate.TabIndex = 18;
            ptnUpdate.Text = "Update";
            ptnUpdate.UseVisualStyleBackColor = true;
            ptnUpdate.Click += ptnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.TopCenter;
            btnAdd.Location = new Point(341, 94);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 32);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "ADD New Book";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Category_txtBox
            // 
            Category_txtBox.FormattingEnabled = true;
            Category_txtBox.Location = new Point(143, 202);
            Category_txtBox.Name = "Category_txtBox";
            Category_txtBox.Size = new Size(125, 28);
            Category_txtBox.TabIndex = 16;
            // 
            // id_txtBox
            // 
            id_txtBox.Location = new Point(143, 109);
            id_txtBox.Name = "id_txtBox";
            id_txtBox.ReadOnly = true;
            id_txtBox.Size = new Size(125, 27);
            id_txtBox.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(48, 109);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 14;
            label8.Text = "ID";
            // 
            // BookGridView
            // 
            BookGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookGridView.Location = new Point(341, 131);
            BookGridView.Name = "BookGridView";
            BookGridView.RowHeadersWidth = 51;
            BookGridView.Size = new Size(688, 387);
            BookGridView.TabIndex = 13;
            // 
            // copies_txtBox
            // 
            copies_txtBox.Location = new Point(143, 388);
            copies_txtBox.Name = "copies_txtBox";
            copies_txtBox.Size = new Size(125, 27);
            copies_txtBox.TabIndex = 12;
            // 
            // year_txtBox
            // 
            year_txtBox.Location = new Point(143, 341);
            year_txtBox.Name = "year_txtBox";
            year_txtBox.Size = new Size(125, 27);
            year_txtBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 395);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 10;
            label7.Text = "Copies ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 341);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 9;
            label6.Text = "Year";
            // 
            // isbn_txtBox
            // 
            isbn_txtBox.Location = new Point(143, 295);
            isbn_txtBox.Name = "isbn_txtBox";
            isbn_txtBox.Size = new Size(125, 27);
            isbn_txtBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 295);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 7;
            label5.Text = "ISBN ";
            // 
            // author_txtBox
            // 
            author_txtBox.Location = new Point(143, 248);
            author_txtBox.Name = "author_txtBox";
            author_txtBox.Size = new Size(125, 27);
            author_txtBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 248);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "Autor";
            // 
            // title_txtBox
            // 
            title_txtBox.Location = new Point(143, 155);
            title_txtBox.Name = "title_txtBox";
            title_txtBox.Size = new Size(125, 27);
            title_txtBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 155);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 3;
            label3.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 202);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label1
            // 
            label1.Font = new Font("Century", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(415, 22);
            label1.Name = "label1";
            label1.Size = new Size(259, 40);
            label1.TabIndex = 0;
            label1.Text = "Manage Books";
            // 
            // Back_Home
            // 
            Back_Home.Image = (Image)resources.GetObject("Back_Home.Image");
            Back_Home.Location = new Point(-2, 12);
            Back_Home.Name = "Back_Home";
            Back_Home.Size = new Size(58, 57);
            Back_Home.TabIndex = 1;
            Back_Home.TabStop = false;
            Back_Home.Click += Back_Home_Click;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 534);
            Controls.Add(Back_Home);
            Controls.Add(panel1);
            Text = "Books";
            Load += Books_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)Back_Home).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox title_txtBox;
        private TextBox author_txtBox;
        private Label label4;
        private Label label5;
        private TextBox isbn_txtBox;
        private Label label7;
        private Label label6;
        private TextBox copies_txtBox;
        private TextBox year_txtBox;
        public DataGridView BookGridView;
        private Button btnDelete;
        private Button ptnUpdate;
        private Button btnAdd;
        private ComboBox Category_txtBox;
        private TextBox id_txtBox;
        private Label label8;
        private ComboBox Category_txtBox2;
        private PictureBox Back_Home;
        private TextBox Av_copies_txtBox;
        private Label label9;
        private Label label10;
        private Label Name;
        private TextBox SearchName;
        private TextBox SearchID;
        private Button btnSearch;
    }
}