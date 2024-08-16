namespace BookHaven_Library
{
    partial class Members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            btnRefresh = new Button();
            btnDelete = new Button();
            ptnUpdate = new Button();
            btnAdd = new Button();
            MemberID_txtBox = new TextBox();
            label8 = new Label();
            MembersGridView = new DataGridView();
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
            Back_Home = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MembersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Back_Home).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(ptnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(MemberID_txtBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(MembersGridView);
            panel1.Controls.Add(PhoneNumber_txtBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(Email_txtBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(LastName_txtBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(FirstName_txtBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(64, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 552);
            panel1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Cursor = Cursors.IBeam;
            dateTimePicker1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(143, 371);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 25);
            dateTimePicker1.TabIndex = 21;
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
            // btnDelete
            // 
            btnDelete.Location = new Point(177, 438);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(71, 29);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ptnUpdate
            // 
            ptnUpdate.Location = new Point(53, 438);
            ptnUpdate.Name = "ptnUpdate";
            ptnUpdate.Size = new Size(71, 29);
            ptnUpdate.TabIndex = 18;
            ptnUpdate.Text = "Update";
            ptnUpdate.UseVisualStyleBackColor = true;
            ptnUpdate.Click += ptnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(753, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 29);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "ADD New Member";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // MemberID_txtBox
            // 
            MemberID_txtBox.Location = new Point(143, 109);
            MemberID_txtBox.Name = "MemberID_txtBox";
            MemberID_txtBox.ReadOnly = true;
            MemberID_txtBox.Size = new Size(125, 27);
            MemberID_txtBox.TabIndex = 15;
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
            // MembersGridView
            // 
            MembersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MembersGridView.Location = new Point(342, 109);
            MembersGridView.Name = "MembersGridView";
            MembersGridView.RowHeadersWidth = 51;
            MembersGridView.Size = new Size(688, 387);
            MembersGridView.TabIndex = 13;
            // 
            // PhoneNumber_txtBox
            // 
            PhoneNumber_txtBox.Location = new Point(143, 262);
            PhoneNumber_txtBox.Name = "PhoneNumber_txtBox";
            PhoneNumber_txtBox.Size = new Size(125, 27);
            PhoneNumber_txtBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(42, 376);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 10;
            label7.Text = "JoinDate ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 265);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 9;
            label6.Text = "PhoneNumber";
            // 
            // Email_txtBox
            // 
            Email_txtBox.Location = new Point(143, 315);
            Email_txtBox.Name = "Email_txtBox";
            Email_txtBox.Size = new Size(125, 27);
            Email_txtBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(48, 322);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // LastName_txtBox
            // 
            LastName_txtBox.Location = new Point(143, 208);
            LastName_txtBox.Name = "LastName_txtBox";
            LastName_txtBox.Size = new Size(125, 27);
            LastName_txtBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 211);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 5;
            label4.Text = "LastName";
            // 
            // FirstName_txtBox
            // 
            FirstName_txtBox.Location = new Point(143, 155);
            FirstName_txtBox.Name = "FirstName_txtBox";
            FirstName_txtBox.Size = new Size(125, 27);
            FirstName_txtBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 155);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 3;
            label3.Text = "FirstName";
            // 
            // label1
            // 
            label1.Font = new Font("Century", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(374, 39);
            label1.Name = "label1";
            label1.Size = new Size(345, 40);
            label1.TabIndex = 0;
            label1.Text = "Manage Members";
            // 
            // Back_Home
            // 
            Back_Home.Image = (Image)resources.GetObject("Back_Home.Image");
            Back_Home.Location = new Point(0, 23);
            Back_Home.Name = "Back_Home";
            Back_Home.Size = new Size(58, 57);
            Back_Home.TabIndex = 21;
            Back_Home.TabStop = false;
            Back_Home.Click += Back_Home_Click;
            // 
            // Members
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 534);
            Controls.Add(panel1);
            Controls.Add(Back_Home);
            Name = "Members";
            Text = "Members";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MembersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)Back_Home).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRefresh;
        private Button btnDelete;
        private Button ptnUpdate;
        private Button btnAdd;
        private ComboBox Category_txtBox;
        private TextBox MemberID_txtBox;
        private Label label8;
        public DataGridView MembersGridView;
        private TextBox PhoneNumber_txtBox;
        private Label label7;
        private Label label6;
        private TextBox Email_txtBox;
        private Label label5;
        private TextBox LastName_txtBox;
        private Label label4;
        private TextBox FirstName_txtBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox Back_Home;
        private DateTimePicker dateTimePicker1;
    }
}