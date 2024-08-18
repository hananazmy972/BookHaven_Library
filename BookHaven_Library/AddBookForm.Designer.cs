namespace BookHaven_Library
{
    partial class AddBookForm
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
            Av_copies_txtBox = new TextBox();
            label9 = new Label();
            Category_txtBox = new ComboBox();
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
            btnSave = new Button();
            SuspendLayout();
            // 
            // Av_copies_txtBox
            // 
            Av_copies_txtBox.Location = new Point(277, 415);
            Av_copies_txtBox.Name = "Av_copies_txtBox";
            Av_copies_txtBox.Size = new Size(141, 27);
            Av_copies_txtBox.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(95, 417);
            label9.Name = "label9";
            label9.Size = new Size(152, 25);
            label9.TabIndex = 38;
            label9.Text = "Availabe Copies ";
            // 
            // Category_txtBox
            // 
            Category_txtBox.FormattingEnabled = true;
            Category_txtBox.Location = new Point(225, 163);
            Category_txtBox.Name = "Category_txtBox";
            Category_txtBox.Size = new Size(193, 28);
            Category_txtBox.TabIndex = 37;
            // 
            // copies_txtBox
            // 
            copies_txtBox.Location = new Point(277, 368);
            copies_txtBox.Name = "copies_txtBox";
            copies_txtBox.Size = new Size(141, 27);
            copies_txtBox.TabIndex = 34;
            // 
            // year_txtBox
            // 
            year_txtBox.Location = new Point(277, 325);
            year_txtBox.Name = "year_txtBox";
            year_txtBox.Size = new Size(141, 27);
            year_txtBox.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(93, 368);
            label7.Name = "label7";
            label7.Size = new Size(125, 25);
            label7.TabIndex = 32;
            label7.Text = "Total Copies :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(93, 325);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 31;
            label6.Text = "PublicationYear :";
            // 
            // isbn_txtBox
            // 
            isbn_txtBox.Location = new Point(225, 269);
            isbn_txtBox.Name = "isbn_txtBox";
            isbn_txtBox.Size = new Size(193, 27);
            isbn_txtBox.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(93, 271);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 29;
            label5.Text = "ISBN :";
            // 
            // author_txtBox
            // 
            author_txtBox.Location = new Point(225, 216);
            author_txtBox.Name = "author_txtBox";
            author_txtBox.Size = new Size(193, 27);
            author_txtBox.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(93, 216);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 27;
            label4.Text = "Autor :";
            // 
            // title_txtBox
            // 
            title_txtBox.Location = new Point(225, 113);
            title_txtBox.Name = "title_txtBox";
            title_txtBox.Size = new Size(193, 27);
            title_txtBox.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(93, 113);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 25;
            label3.Text = "Title :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 162);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 24;
            label2.Text = "Category :";
            // 
            // label1
            // 
            label1.Font = new Font("Century", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(159, 26);
            label1.Name = "label1";
            label1.Size = new Size(259, 40);
            label1.TabIndex = 40;
            label1.Text = "Add New Book";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DimGray;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(200, 493);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(163, 48);
            btnSave.TabIndex = 41;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(534, 571);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(Av_copies_txtBox);
            Controls.Add(label9);
            Controls.Add(Category_txtBox);
            Controls.Add(copies_txtBox);
            Controls.Add(year_txtBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(isbn_txtBox);
            Controls.Add(label5);
            Controls.Add(author_txtBox);
            Controls.Add(label4);
            Controls.Add(title_txtBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "AddBookForm";
            Text = "AddBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Av_copies_txtBox;
        private Label label9;
        private ComboBox Category_txtBox;
        private TextBox copies_txtBox;
        private TextBox year_txtBox;
        private Label label7;
        private Label label6;
        private TextBox isbn_txtBox;
        private Label label5;
        private TextBox author_txtBox;
        private Label label4;
        private TextBox title_txtBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
    }
}