namespace BookHaven_Library
{
    partial class AddMemberForm
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
            dateTimePicker1 = new DateTimePicker();
            PhoneNumber_txtBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            Email_txtBox = new TextBox();
            label5 = new Label();
            LastName_txtBox = new TextBox();
            label4 = new Label();
            FirstName_txtBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnSaveMember = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Cursor = Cursors.IBeam;
            dateTimePicker1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(184, 349);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(162, 25);
            dateTimePicker1.TabIndex = 33;
            // 
            // PhoneNumber_txtBox
            // 
            PhoneNumber_txtBox.Location = new Point(184, 285);
            PhoneNumber_txtBox.Name = "PhoneNumber_txtBox";
            PhoneNumber_txtBox.Size = new Size(162, 27);
            PhoneNumber_txtBox.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(56, 349);
            label7.Name = "label7";
            label7.Size = new Size(97, 25);
            label7.TabIndex = 29;
            label7.Text = "JoinDate :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 284);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 28;
            label6.Text = "PhoneNumber";
            // 
            // Email_txtBox
            // 
            Email_txtBox.Location = new Point(184, 229);
            Email_txtBox.Name = "Email_txtBox";
            Email_txtBox.Size = new Size(162, 27);
            Email_txtBox.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 231);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 26;
            label5.Text = "Email :";
            // 
            // LastName_txtBox
            // 
            LastName_txtBox.Location = new Point(184, 177);
            LastName_txtBox.Name = "LastName_txtBox";
            LastName_txtBox.Size = new Size(162, 27);
            LastName_txtBox.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 177);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 24;
            label4.Text = "LastName :";
            // 
            // FirstName_txtBox
            // 
            FirstName_txtBox.Location = new Point(184, 119);
            FirstName_txtBox.Name = "FirstName_txtBox";
            FirstName_txtBox.Size = new Size(162, 27);
            FirstName_txtBox.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 121);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 22;
            label3.Text = "FirstName : ";
            // 
            // label1
            // 
            label1.Font = new Font("Century", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(107, 36);
            label1.Name = "label1";
            label1.Size = new Size(320, 40);
            label1.TabIndex = 41;
            label1.Text = "Add New Member";
            // 
            // btnSaveMember
            // 
            btnSaveMember.BackColor = Color.DimGray;
            btnSaveMember.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveMember.Location = new Point(160, 433);
            btnSaveMember.Name = "btnSaveMember";
            btnSaveMember.Size = new Size(163, 48);
            btnSaveMember.TabIndex = 42;
            btnSaveMember.Text = "Save";
            btnSaveMember.UseVisualStyleBackColor = false;
            btnSaveMember.Click += btnSave_Click;
            // 
            // AddMemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(494, 511);
            Controls.Add(btnSaveMember);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(PhoneNumber_txtBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Email_txtBox);
            Controls.Add(label5);
            Controls.Add(LastName_txtBox);
            Controls.Add(label4);
            Controls.Add(FirstName_txtBox);
            Controls.Add(label3);
            Name = "AddMemberForm";
            Text = "AddMemberForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox PhoneNumber_txtBox;
        private Label label7;
        private Label label6;
        private TextBox Email_txtBox;
        private Label label5;
        private TextBox LastName_txtBox;
        private Label label4;
        private TextBox FirstName_txtBox;
        private Label label3;
        private Label label1;
        private Button btnSaveMember;
    }
}