namespace PRPJECT4NEW
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Student_Name = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.Alerts_Button = new System.Windows.Forms.Button();
            this.Exam_Res_Button = new System.Windows.Forms.Button();
            this.Fees_Button = new System.Windows.Forms.Button();
            this.Requests_Button = new System.Windows.Forms.Button();
            this.Holidays_Button = new System.Windows.Forms.Button();
            this.Exams_Button = new System.Windows.Forms.Button();
            this.Messages_Button = new System.Windows.Forms.Button();
            this.Update_Calendar_Button = new System.Windows.Forms.Button();
            this.Celender_button = new System.Windows.Forms.Button();
            this.Buttons_view = new System.Windows.Forms.Panel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "Header";
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Student_Name);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 46);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(611, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(0, 13, 34, 0);
            this.pictureBox2.Size = new System.Drawing.Size(29, 46);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(640, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 9, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 13, 34, 0);
            this.pictureBox1.Size = new System.Drawing.Size(56, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Student_Name
            // 
            this.Student_Name.AutoSize = true;
            this.Student_Name.Dock = System.Windows.Forms.DockStyle.Left;
            this.Student_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Name.ForeColor = System.Drawing.Color.White;
            this.Student_Name.Image = ((System.Drawing.Image)(resources.GetObject("Student_Name.Image")));
            this.Student_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Student_Name.Location = new System.Drawing.Point(179, 0);
            this.Student_Name.Margin = new System.Windows.Forms.Padding(1, 9, 4, 0);
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Padding = new System.Windows.Forms.Padding(11, 16, 0, 0);
            this.Student_Name.Size = new System.Drawing.Size(152, 37);
            this.Student_Name.TabIndex = 2;
            this.Student_Name.Text = "     Matan Vaknin";
            this.Student_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Student_Name.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 46);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.flowLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 46);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 7);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(98, 35);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(294, 98);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AccessibleName = "Buttons_place";
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.panel2.Controls.Add(this.Logout_Button);
            this.panel2.Controls.Add(this.Alerts_Button);
            this.panel2.Controls.Add(this.Exam_Res_Button);
            this.panel2.Controls.Add(this.Fees_Button);
            this.panel2.Controls.Add(this.Requests_Button);
            this.panel2.Controls.Add(this.Holidays_Button);
            this.panel2.Controls.Add(this.Exams_Button);
            this.panel2.Controls.Add(this.Messages_Button);
            this.panel2.Controls.Add(this.Update_Calendar_Button);
            this.panel2.Controls.Add(this.Celender_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.panel2.Size = new System.Drawing.Size(179, 463);
            this.panel2.TabIndex = 1;
            // 
            // Logout_Button
            // 
            this.Logout_Button.AccessibleName = "Logout_Button";
            this.Logout_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Logout_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logout_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logout_Button.FlatAppearance.BorderSize = 0;
            this.Logout_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Logout_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_Button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_Button.ForeColor = System.Drawing.Color.White;
            this.Logout_Button.Image = ((System.Drawing.Image)(resources.GetObject("Logout_Button.Image")));
            this.Logout_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_Button.Location = new System.Drawing.Point(0, 376);
            this.Logout_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Logout_Button.Size = new System.Drawing.Size(179, 41);
            this.Logout_Button.TabIndex = 10;
            this.Logout_Button.Text = " Logout";
            this.Logout_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logout_Button.UseVisualStyleBackColor = false;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Alerts_Button
            // 
            this.Alerts_Button.AccessibleName = "Alerts_Button";
            this.Alerts_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Alerts_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Alerts_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Alerts_Button.FlatAppearance.BorderSize = 0;
            this.Alerts_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Alerts_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alerts_Button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alerts_Button.ForeColor = System.Drawing.Color.White;
            this.Alerts_Button.Image = ((System.Drawing.Image)(resources.GetObject("Alerts_Button.Image")));
            this.Alerts_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Alerts_Button.Location = new System.Drawing.Point(0, 335);
            this.Alerts_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Alerts_Button.Name = "Alerts_Button";
            this.Alerts_Button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Alerts_Button.Size = new System.Drawing.Size(179, 41);
            this.Alerts_Button.TabIndex = 9;
            this.Alerts_Button.Text = " Alerts";
            this.Alerts_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Alerts_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Alerts_Button.UseVisualStyleBackColor = false;
            this.Alerts_Button.Click += new System.EventHandler(this.Alerts_Button_Click);
            // 
            // Exam_Res_Button
            // 
            this.Exam_Res_Button.AccessibleName = "Exam_Res_Button";
            this.Exam_Res_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Exam_Res_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Exam_Res_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exam_Res_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exam_Res_Button.FlatAppearance.BorderSize = 0;
            this.Exam_Res_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Exam_Res_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exam_Res_Button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exam_Res_Button.ForeColor = System.Drawing.Color.White;
            this.Exam_Res_Button.Image = ((System.Drawing.Image)(resources.GetObject("Exam_Res_Button.Image")));
            this.Exam_Res_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exam_Res_Button.Location = new System.Drawing.Point(0, 294);
            this.Exam_Res_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Exam_Res_Button.Name = "Exam_Res_Button";
            this.Exam_Res_Button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Exam_Res_Button.Size = new System.Drawing.Size(179, 41);
            this.Exam_Res_Button.TabIndex = 8;
            this.Exam_Res_Button.Text = " Exams results";
            this.Exam_Res_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exam_Res_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exam_Res_Button.UseVisualStyleBackColor = false;
            this.Exam_Res_Button.Click += new System.EventHandler(this.Exam_Res_Button_Click);
            // 
            // Fees_Button
            // 
            this.Fees_Button.AccessibleName = "Fees_Button";
            this.Fees_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Fees_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Fees_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Fees_Button.FlatAppearance.BorderSize = 0;
            this.Fees_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Fees_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fees_Button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fees_Button.ForeColor = System.Drawing.Color.White;
            this.Fees_Button.Image = ((System.Drawing.Image)(resources.GetObject("Fees_Button.Image")));
            this.Fees_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Fees_Button.Location = new System.Drawing.Point(0, 253);
            this.Fees_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Fees_Button.Name = "Fees_Button";
            this.Fees_Button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Fees_Button.Size = new System.Drawing.Size(179, 41);
            this.Fees_Button.TabIndex = 7;
            this.Fees_Button.Text = " Tuition fees";
            this.Fees_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Fees_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Fees_Button.UseVisualStyleBackColor = false;
            this.Fees_Button.Click += new System.EventHandler(this.Fees_Button_Click);
            // 
            // Requests_Button
            // 
            this.Requests_Button.AccessibleName = "Requests_Button";
            this.Requests_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Requests_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Requests_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Requests_Button.FlatAppearance.BorderSize = 0;
            this.Requests_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Requests_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Requests_Button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Requests_Button.ForeColor = System.Drawing.Color.White;
            this.Requests_Button.Image = ((System.Drawing.Image)(resources.GetObject("Requests_Button.Image")));
            this.Requests_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Requests_Button.Location = new System.Drawing.Point(0, 212);
            this.Requests_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Requests_Button.Name = "Requests_Button";
            this.Requests_Button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Requests_Button.Size = new System.Drawing.Size(179, 41);
            this.Requests_Button.TabIndex = 6;
            this.Requests_Button.Text = " Requests";
            this.Requests_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Requests_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Requests_Button.UseVisualStyleBackColor = false;
            this.Requests_Button.Click += new System.EventHandler(this.Requests_Button_Click);
            // 
            // Holidays_Button
            // 
            this.Holidays_Button.AccessibleName = "Holidays_Button";
            this.Holidays_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Holidays_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Holidays_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Holidays_Button.FlatAppearance.BorderSize = 0;
            this.Holidays_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Holidays_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Holidays_Button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Holidays_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Holidays_Button.Image = ((System.Drawing.Image)(resources.GetObject("Holidays_Button.Image")));
            this.Holidays_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Holidays_Button.Location = new System.Drawing.Point(0, 171);
            this.Holidays_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Holidays_Button.Name = "Holidays_Button";
            this.Holidays_Button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Holidays_Button.Size = new System.Drawing.Size(179, 41);
            this.Holidays_Button.TabIndex = 5;
            this.Holidays_Button.Text = " Holidays";
            this.Holidays_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Holidays_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Holidays_Button.UseVisualStyleBackColor = false;
            this.Holidays_Button.Click += new System.EventHandler(this.Holidays_Button_Click);
            // 
            // Exams_Button
            // 
            this.Exams_Button.AccessibleName = "Exams_Button";
            this.Exams_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Exams_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exams_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exams_Button.FlatAppearance.BorderSize = 0;
            this.Exams_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Exams_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exams_Button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exams_Button.ForeColor = System.Drawing.Color.White;
            this.Exams_Button.Image = ((System.Drawing.Image)(resources.GetObject("Exams_Button.Image")));
            this.Exams_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exams_Button.Location = new System.Drawing.Point(0, 130);
            this.Exams_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Exams_Button.Name = "Exams_Button";
            this.Exams_Button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Exams_Button.Size = new System.Drawing.Size(179, 41);
            this.Exams_Button.TabIndex = 4;
            this.Exams_Button.Text = " Exams";
            this.Exams_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exams_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exams_Button.UseVisualStyleBackColor = false;
            this.Exams_Button.Click += new System.EventHandler(this.Exams_Button_Click);
            // 
            // Messages_Button
            // 
            this.Messages_Button.AccessibleName = "Messages_Button";
            this.Messages_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Messages_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Messages_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Messages_Button.FlatAppearance.BorderSize = 0;
            this.Messages_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Messages_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Messages_Button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messages_Button.ForeColor = System.Drawing.Color.White;
            this.Messages_Button.Image = ((System.Drawing.Image)(resources.GetObject("Messages_Button.Image")));
            this.Messages_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Messages_Button.Location = new System.Drawing.Point(0, 89);
            this.Messages_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Messages_Button.Name = "Messages_Button";
            this.Messages_Button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Messages_Button.Size = new System.Drawing.Size(179, 41);
            this.Messages_Button.TabIndex = 3;
            this.Messages_Button.Text = " Messages";
            this.Messages_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Messages_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Messages_Button.UseVisualStyleBackColor = false;
            this.Messages_Button.Click += new System.EventHandler(this.Messages_Button_Click);
            // 
            // Update_Calendar_Button
            // 
            this.Update_Calendar_Button.AccessibleName = "Update_Calendar_Button";
            this.Update_Calendar_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Update_Calendar_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Update_Calendar_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Update_Calendar_Button.FlatAppearance.BorderSize = 0;
            this.Update_Calendar_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Update_Calendar_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Calendar_Button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Calendar_Button.ForeColor = System.Drawing.Color.White;
            this.Update_Calendar_Button.Image = ((System.Drawing.Image)(resources.GetObject("Update_Calendar_Button.Image")));
            this.Update_Calendar_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update_Calendar_Button.Location = new System.Drawing.Point(0, 48);
            this.Update_Calendar_Button.Margin = new System.Windows.Forms.Padding(1);
            this.Update_Calendar_Button.Name = "Update_Calendar_Button";
            this.Update_Calendar_Button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Update_Calendar_Button.Size = new System.Drawing.Size(179, 41);
            this.Update_Calendar_Button.TabIndex = 2;
            this.Update_Calendar_Button.Text = " Update Celender";
            this.Update_Calendar_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update_Calendar_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Update_Calendar_Button.UseVisualStyleBackColor = false;
            this.Update_Calendar_Button.Click += new System.EventHandler(this.Update_Calendar_Button_Click);
            // 
            // Celender_button
            // 
            this.Celender_button.AccessibleName = "Celender_button";
            this.Celender_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Celender_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Celender_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Celender_button.FlatAppearance.BorderSize = 0;
            this.Celender_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Celender_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Celender_button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Celender_button.ForeColor = System.Drawing.Color.White;
            this.Celender_button.Image = ((System.Drawing.Image)(resources.GetObject("Celender_button.Image")));
            this.Celender_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Celender_button.Location = new System.Drawing.Point(0, 7);
            this.Celender_button.Margin = new System.Windows.Forms.Padding(1);
            this.Celender_button.Name = "Celender_button";
            this.Celender_button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Celender_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Celender_button.Size = new System.Drawing.Size(179, 41);
            this.Celender_button.TabIndex = 0;
            this.Celender_button.Text = " Celender";
            this.Celender_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Celender_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Celender_button.UseVisualStyleBackColor = false;
            this.Celender_button.Click += new System.EventHandler(this.Celender_Click);
            // 
            // Buttons_view
            // 
            this.Buttons_view.AccessibleName = "Buttons_view";
            this.Buttons_view.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Buttons_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Buttons_view.Location = new System.Drawing.Point(179, 46);
            this.Buttons_view.Margin = new System.Windows.Forms.Padding(1);
            this.Buttons_view.Name = "Buttons_view";
            this.Buttons_view.Size = new System.Drawing.Size(517, 463);
            this.Buttons_view.TabIndex = 2;
            this.Buttons_view.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(696, 509);
            this.Controls.Add(this.Buttons_view);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Logout_Button;
        private System.Windows.Forms.Button Alerts_Button;
        private System.Windows.Forms.Button Exam_Res_Button;
        private System.Windows.Forms.Button Fees_Button;
        private System.Windows.Forms.Button Requests_Button;
        private System.Windows.Forms.Button Holidays_Button;
        private System.Windows.Forms.Button Exams_Button;
        private System.Windows.Forms.Button Messages_Button;
        private System.Windows.Forms.Button Update_Calendar_Button;
        private System.Windows.Forms.Button Celender_button;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Buttons_view;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label Student_Name;
    }
}

