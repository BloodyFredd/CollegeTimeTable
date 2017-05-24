namespace BranchA_MazalPlus.Lecturer
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.StudentsReport = new System.Windows.Forms.DataGridView();
            this.Available_Classes = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Semester = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.LecturerCourses = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Grades_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Report = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsReport
            // 
            this.StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsReport.Location = new System.Drawing.Point(292, 58);
            this.StudentsReport.Margin = new System.Windows.Forms.Padding(13, 17, 13, 17);
            this.StudentsReport.Name = "StudentsReport";
            this.StudentsReport.RowTemplate.Height = 24;
            this.StudentsReport.Size = new System.Drawing.Size(1025, 755);
            this.StudentsReport.TabIndex = 2;
            this.StudentsReport.Visible = false;
            this.StudentsReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsReport_CellContentClick);
            // 
            // Available_Classes
            // 
            this.Available_Classes.AccessibleDescription = "Available_Classes";
            this.Available_Classes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Available_Classes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Available_Classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Available_Classes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Available_Classes.Location = new System.Drawing.Point(0, 57);
            this.Available_Classes.Margin = new System.Windows.Forms.Padding(13, 17, 13, 17);
            this.Available_Classes.Name = "Available_Classes";
            this.Available_Classes.Size = new System.Drawing.Size(291, 61);
            this.Available_Classes.TabIndex = 8;
            this.Available_Classes.Text = "Available Classes";
            this.Available_Classes.UseVisualStyleBackColor = false;
            this.Available_Classes.Click += new System.EventHandler(this.Available_Classes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Semester});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(60, 118);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(43, 17, 0, 17);
            this.menuStrip1.Size = new System.Drawing.Size(125, 60);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Semester
            // 
            this.Semester.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem});
            this.Semester.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(81, 24);
            this.Semester.Text = "Semester";
            this.Semester.Click += new System.EventHandler(this.Semester_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.aToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
            this.aToolStripMenuItem.Text = "A";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.AccessibleName = "toolStripComboBox2";
            this.toolStripComboBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripComboBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "2016-08-07",
            "2016-08-08",
            "2016-08-09",
            "2016-08-10",
            "2016-08-11",
            "2016-08-12",
            "2016-08-14",
            "2016-08-15",
            "2016-08-16",
            "2016-08-17",
            "2016-08-18",
            "2016-08-19",
            "2016-08-21",
            "2016-08-22",
            "2016-08-23",
            "2016-08-24",
            "2016-08-25",
            "2016-08-26",
            "2016-08-28",
            "2016-08-29",
            "2016-08-30",
            "2016-08-31",
            "2016-09-01",
            "2016-09-02",
            "2016-09-04",
            "2016-09-05",
            "2016-09-06",
            "2016-09-07",
            "2016-09-08",
            "2016-09-09",
            "2016-09-11",
            "2016-09-12",
            "2016-09-13",
            "2016-09-14",
            "2016-09-15",
            "2016-09-16",
            "2016-09-18",
            "2016-09-19",
            "2016-09-20",
            "2016-09-21",
            "2016-09-22",
            "2016-09-23",
            "2016-09-25",
            "2016-09-26",
            "2016-09-27",
            "2016-09-28",
            "2016-09-29",
            "2016-09-30",
            "2016-10-02",
            "2016-10-03",
            "2016-10-04",
            "2016-10-05",
            "2016-10-06",
            "2016-10-07",
            "2016-10-09",
            "2016-10-10",
            "2016-10-11",
            "2016-10-12",
            "2016-10-13",
            "2016-10-14",
            "2016-10-16",
            "2016-10-17",
            "2016-10-18",
            "2016-10-19",
            "2016-10-20",
            "2016-10-21",
            "2016-10-23",
            "2016-10-24",
            "2016-10-25",
            "2016-10-26",
            "2016-10-27",
            "2016-10-28",
            "2016-10-30",
            "2016-10-31",
            "2016-11-01",
            "2016-11-02",
            "2016-11-03",
            "2016-11-04",
            "2016-11-06",
            "2016-11-07",
            "2016-11-08",
            "2016-11-09",
            "2016-11-10",
            "2016-11-11"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 28);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.bToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
            this.bToolStripMenuItem.Text = "B";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AccessibleName = "toolStripComboBox1";
            this.toolStripComboBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripComboBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "2017-01-01",
            "2017-01-02",
            "2017-01-03",
            "2017-01-04",
            "2017-01-05",
            "2017-01-06",
            "2017-01-08",
            "2017-01-09",
            "2017-01-10",
            "2017-01-11",
            "2017-01-12",
            "2017-01-13",
            "2017-01-15",
            "2017-01-16",
            "2017-01-17",
            "2017-01-18",
            "2017-01-19",
            "2017-01-20",
            "2017-01-22",
            "2017-01-23",
            "2017-01-24",
            "2017-01-25",
            "2017-01-26",
            "2017-01-27",
            "2017-01-29",
            "2017-01-30",
            "2017-01-31",
            "2017-02-01",
            "2017-02-02",
            "2017-02-03",
            "2017-02-05",
            "2017-02-06",
            "2017-02-07",
            "2017-02-08",
            "2017-02-09",
            "2017-02-10",
            "2017-02-12",
            "2017-02-13",
            "2017-02-14",
            "2017-02-15",
            "2017-02-16",
            "2017-02-17",
            "2017-02-19",
            "2017-02-20",
            "2017-02-21",
            "2017-02-22",
            "2017-02-23",
            "2017-02-24",
            "2017-02-26",
            "2017-02-27",
            "2017-02-28",
            "2017-03-01",
            "2017-03-02",
            "2017-03-03",
            "2017-03-05",
            "2017-03-06",
            "2017-03-07",
            "2017-03-08",
            "2017-03-09",
            "2017-03-10",
            "2017-03-12",
            "2017-03-13",
            "2017-03-14",
            "2017-03-15",
            "2017-03-16",
            "2017-03-17",
            "2017-03-19",
            "2017-03-20",
            "2017-03-21",
            "2017-03-22",
            "2017-03-23",
            "2017-03-24",
            "2017-03-26",
            "2017-03-27",
            "2017-03-28",
            "2017-03-29",
            "2017-03-30",
            "2017-03-31",
            "2017-04-02",
            "2017-04-03",
            "2017-04-04",
            "2017-04-05",
            "2017-04-06",
            "2017-04-07"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click_1);
            // 
            // LecturerCourses
            // 
            this.LecturerCourses.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LecturerCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LecturerCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LecturerCourses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LecturerCourses.Location = new System.Drawing.Point(-1, 242);
            this.LecturerCourses.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.LecturerCourses.Name = "LecturerCourses";
            this.LecturerCourses.Size = new System.Drawing.Size(291, 67);
            this.LecturerCourses.TabIndex = 10;
            this.LecturerCourses.Text = "Lecturer Courses";
            this.LecturerCourses.UseVisualStyleBackColor = false;
            this.LecturerCourses.Click += new System.EventHandler(this.LecturerCourses_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(-1, 308);
            this.button2.Margin = new System.Windows.Forms.Padding(13, 17, 13, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 67);
            this.button2.TabIndex = 11;
            this.button2.Text = "Show my students";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Grades_Button
            // 
            this.Grades_Button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Grades_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grades_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grades_Button.Location = new System.Drawing.Point(0, 191);
            this.Grades_Button.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Grades_Button.Name = "Grades_Button";
            this.Grades_Button.Size = new System.Drawing.Size(291, 52);
            this.Grades_Button.TabIndex = 12;
            this.Grades_Button.Text = "Grades of Students";
            this.Grades_Button.UseVisualStyleBackColor = false;
            this.Grades_Button.Click += new System.EventHandler(this.Grades_Button_Click);
            // 
            // panel2
            // 
            this.panel2.AccessibleName = "Buttons_place";
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.Grades_Button);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Available_Classes);
            this.panel2.Controls.Add(this.LecturerCourses);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.panel2.Size = new System.Drawing.Size(291, 870);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "Header";
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Report);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(291, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 57);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(629, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 1, 12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 16, 45, 0);
            this.pictureBox1.Size = new System.Drawing.Size(67, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Report
            // 
            this.Report.AccessibleName = "Reports";
            this.Report.AutoSize = true;
            this.Report.Dock = System.Windows.Forms.DockStyle.Left;
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.ForeColor = System.Drawing.Color.White;
            this.Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Report.Location = new System.Drawing.Point(0, 0);
            this.Report.Margin = new System.Windows.Forms.Padding(3, 11, 5, 0);
            this.Report.Name = "Report";
            this.Report.Padding = new System.Windows.Forms.Padding(13, 20, 0, 0);
            this.Report.Size = new System.Drawing.Size(92, 45);
            this.Report.TabIndex = 2;
            this.Report.Text = "Reports";
            this.Report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(987, 870);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.StudentsReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(13, 17, 13, 17);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView StudentsReport;
        private System.Windows.Forms.Button Available_Classes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Semester;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.Button LecturerCourses;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Grades_Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label Report;
    }
}