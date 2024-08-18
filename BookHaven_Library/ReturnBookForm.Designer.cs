namespace BookHaven_Library
{
    partial class ReturnBookForm
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
            ReturnDateTimePicker = new DateTimePicker();
            label4 = new Label();
            BookComboBox = new ComboBox();
            label2 = new Label();
            MemberComboBox = new ComboBox();
            btnCheckOut = new Button();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ReturnDateTimePicker
            // 
            ReturnDateTimePicker.Enabled = false;
            ReturnDateTimePicker.Format = DateTimePickerFormat.Short;
            ReturnDateTimePicker.Location = new Point(220, 290);
            ReturnDateTimePicker.Name = "ReturnDateTimePicker";
            ReturnDateTimePicker.Size = new Size(187, 27);
            ReturnDateTimePicker.TabIndex = 70;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 290);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 69;
            label4.Text = "Return Date :";
            // 
            // BookComboBox
            // 
            BookComboBox.FormattingEnabled = true;
            BookComboBox.Location = new Point(220, 220);
            BookComboBox.Name = "BookComboBox";
            BookComboBox.Size = new Size(187, 28);
            BookComboBox.TabIndex = 68;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 223);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 67;
            label2.Text = "Book Name :";
            // 
            // MemberComboBox
            // 
            MemberComboBox.FormattingEnabled = true;
            MemberComboBox.Location = new Point(220, 154);
            MemberComboBox.Name = "MemberComboBox";
            MemberComboBox.Size = new Size(187, 28);
            MemberComboBox.TabIndex = 66;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.Gray;
            btnCheckOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckOut.ForeColor = SystemColors.ButtonFace;
            btnCheckOut.Location = new Point(168, 421);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(163, 48);
            btnCheckOut.TabIndex = 65;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Century", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(155, 43);
            label1.Name = "label1";
            label1.Size = new Size(210, 38);
            label1.TabIndex = 64;
            label1.Text = "Return Book";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 157);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 63;
            label3.Text = "Member Name :";
            // 
            // ReturnBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(534, 571);
            Controls.Add(ReturnDateTimePicker);
            Controls.Add(label4);
            Controls.Add(BookComboBox);
            Controls.Add(label2);
            Controls.Add(MemberComboBox);
            Controls.Add(btnCheckOut);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "ReturnBookForm";
            Text = "ReturnBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker ReturnDateTimePicker;
        private Label label4;
        private ComboBox BookComboBox;
        private Label label2;
        private ComboBox MemberComboBox;
        private Button btnCheckOut;
        private Label label1;
        private Label label3;
    }
}