namespace BookHaven_Library
{
    partial class AddBorrowingForm
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
            btnCheckOut = new Button();
            label1 = new Label();
            label3 = new Label();
            MemberComboBox = new ComboBox();
            label2 = new Label();
            BookComboBox = new ComboBox();
            label4 = new Label();
            BorrowdateTimePicker = new DateTimePicker();
            label5 = new Label();
            DuedateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = SystemColors.ActiveCaption;
            btnCheckOut.Location = new Point(528, 167);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(94, 102);
            btnCheckOut.TabIndex = 57;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Century", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(232, 26);
            label1.Name = "label1";
            label1.Size = new Size(304, 40);
            label1.TabIndex = 56;
            label1.Text = "Add New Borrowing";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(89, 116);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 43;
            label3.Text = "Member Name :";
            // 
            // MemberComboBox
            // 
            MemberComboBox.FormattingEnabled = true;
            MemberComboBox.Location = new Point(217, 113);
            MemberComboBox.Name = "MemberComboBox";
            MemberComboBox.Size = new Size(187, 28);
            MemberComboBox.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 182);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 59;
            label2.Text = "Book Name :";
            // 
            // BookComboBox
            // 
            BookComboBox.FormattingEnabled = true;
            BookComboBox.Location = new Point(217, 179);
            BookComboBox.Name = "BookComboBox";
            BookComboBox.Size = new Size(187, 28);
            BookComboBox.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(83, 249);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 61;
            label4.Text = "BorrowDate :";
            // 
            // BorrowdateTimePicker
            // 
            BorrowdateTimePicker.Format = DateTimePickerFormat.Short;
            BorrowdateTimePicker.Location = new Point(217, 249);
            BorrowdateTimePicker.Name = "BorrowdateTimePicker";
            BorrowdateTimePicker.Size = new Size(187, 27);
            BorrowdateTimePicker.TabIndex = 62;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(83, 319);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 63;
            label5.Text = "DueDate :";
            // 
            // DuedateTimePicker
            // 
            DuedateTimePicker.Format = DateTimePickerFormat.Short;
            DuedateTimePicker.Location = new Point(217, 319);
            DuedateTimePicker.Name = "DuedateTimePicker";
            DuedateTimePicker.Size = new Size(187, 27);
            DuedateTimePicker.TabIndex = 64;
            // 
            // AddBorrowingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(702, 386);
            Controls.Add(DuedateTimePicker);
            Controls.Add(label5);
            Controls.Add(BorrowdateTimePicker);
            Controls.Add(label4);
            Controls.Add(BookComboBox);
            Controls.Add(label2);
            Controls.Add(MemberComboBox);
            Controls.Add(btnCheckOut);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "AddBorrowingForm";
            Text = "AddBorrowingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheckOut;
        private Label label1;
        private Label label3;
        private ComboBox MemberComboBox;
        private Label label2;
        private ComboBox BookComboBox;
        private Label label4;
        private DateTimePicker BorrowdateTimePicker;
        private Label label5;
        private DateTimePicker DuedateTimePicker;
    }
}