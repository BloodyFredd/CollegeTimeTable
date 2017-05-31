namespace PRPJECT4NEW.Admin
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
            this.Failing_Students = new System.Windows.Forms.Button();
            this.Available_Classes = new System.Windows.Forms.Button();
            this.CourseID = new System.Windows.Forms.ComboBox();
            this.All_Person_Button = new System.Windows.Forms.Button();
            this.ExcellentStudents = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox4 = new System.Windows.Forms.ToolStripComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.StudentsReport = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).BeginInit();
            this.SuspendLayout();
            // 
            // Failing_Students
            // 
            this.Failing_Students.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Failing_Students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Failing_Students.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Failing_Students.Location = new System.Drawing.Point(0, 560);
            this.Failing_Students.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Failing_Students.Name = "Failing_Students";
            this.Failing_Students.Size = new System.Drawing.Size(582, 78);
            this.Failing_Students.TabIndex = 4;
            this.Failing_Students.Text = "Failing Students";
            this.Failing_Students.UseVisualStyleBackColor = false;
            this.Failing_Students.Click += new System.EventHandler(this.button1_Click);
            // 
            // Available_Classes
            // 
            this.Available_Classes.AccessibleDescription = "Available_Classes";
            this.Available_Classes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Available_Classes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.Available_Classes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Available_Classes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Available_Classes.Location = new System.Drawing.Point(0, 128);
            this.Available_Classes.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Available_Classes.Name = "Available_Classes";
            this.Available_Classes.Size = new System.Drawing.Size(582, 85);
            this.Available_Classes.TabIndex = 8;
            this.Available_Classes.Text = "Available Classes";
            this.Available_Classes.UseVisualStyleBackColor = false;
            this.Available_Classes.Click += new System.EventHandler(this.Available_Classes_Click);
            // 
            // CourseID
            // 
            this.CourseID.AccessibleDescription = "Course ID";
            this.CourseID.BackColor = System.Drawing.SystemColors.Highlight;
            this.CourseID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CourseID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CourseID.FormattingEnabled = true;
            this.CourseID.Items.AddRange(new object[] {
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "300",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "400",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406"});
            this.CourseID.Location = new System.Drawing.Point(0, 515);
            this.CourseID.Margin = new System.Windows.Forms.Padding(8);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(578, 39);
            this.CourseID.TabIndex = 11;
            this.CourseID.Text = "                         Course ID";
            this.CourseID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // All_Person_Button
            // 
            this.All_Person_Button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.All_Person_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.All_Person_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.All_Person_Button.Location = new System.Drawing.Point(0, 347);
            this.All_Person_Button.Margin = new System.Windows.Forms.Padding(8);
            this.All_Person_Button.Name = "All_Person_Button";
            this.All_Person_Button.Size = new System.Drawing.Size(582, 83);
            this.All_Person_Button.TabIndex = 12;
            this.All_Person_Button.Text = "All Persons";
            this.All_Person_Button.UseVisualStyleBackColor = false;
            this.All_Person_Button.Click += new System.EventHandler(this.All_Person_Button_Click);
            // 
            // ExcellentStudents
            // 
            this.ExcellentStudents.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ExcellentStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcellentStudents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExcellentStudents.Location = new System.Drawing.Point(0, 428);
            this.ExcellentStudents.Margin = new System.Windows.Forms.Padding(8);
            this.ExcellentStudents.Name = "ExcellentStudents";
            this.ExcellentStudents.Size = new System.Drawing.Size(582, 89);
            this.ExcellentStudents.TabIndex = 13;
            this.ExcellentStudents.Text = "Excellent students";
            this.ExcellentStudents.UseVisualStyleBackColor = false;
            this.ExcellentStudents.Click += new System.EventHandler(this.ExcellentStudents_Click);
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Print.Location = new System.Drawing.Point(0, 636);
            this.Print.Margin = new System.Windows.Forms.Padding(6);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(582, 78);
            this.Print.TabIndex = 14;
            this.Print.Text = "Export to Excel";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Visible = false;
            this.Print.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.AccessibleName = "Buttons_place";
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Controls.Add(this.Available_Classes);
            this.panel2.Controls.Add(this.Print);
            this.panel2.Controls.Add(this.All_Person_Button);
            this.panel2.Controls.Add(this.Failing_Students);
            this.panel2.Controls.Add(this.CourseID);
            this.panel2.Controls.Add(this.ExcellentStudents);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 17, 0, 0);
            this.panel2.Size = new System.Drawing.Size(582, 1006);
            this.panel2.TabIndex = 16;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(122, 221);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(86, 33, 0, 33);
            this.menuStrip2.Size = new System.Drawing.Size(239, 113);
            this.menuStrip2.TabIndex = 15;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 45);
            this.toolStripMenuItem1.Text = "Semester";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 46);
            this.toolStripMenuItem2.Text = "A";
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.AccessibleName = "toolStripComboBox3";
            this.toolStripComboBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripComboBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripComboBox3.Items.AddRange(new object[] {
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
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 49);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox4});
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 46);
            this.toolStripMenuItem3.Text = "B";
            // 
            // toolStripComboBox4
            // 
            this.toolStripComboBox4.AccessibleName = "toolStripComboBox4";
            this.toolStripComboBox4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripComboBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripComboBox4.Items.AddRange(new object[] {
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
            this.toolStripComboBox4.Name = "toolStripComboBox4";
            this.toolStripComboBox4.Size = new System.Drawing.Size(121, 49);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(-3, 713);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(589, 83);
            this.button2.TabIndex = 20;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StudentsReport
            // 
            this.StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsReport.Location = new System.Drawing.Point(582, 0);
            this.StudentsReport.Margin = new System.Windows.Forms.Padding(5);
            this.StudentsReport.Name = "StudentsReport";
            this.StudentsReport.RowTemplate.Height = 24;
            this.StudentsReport.Size = new System.Drawing.Size(1168, 1006);
            this.StudentsReport.TabIndex = 17;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 1006);
            this.Controls.Add(this.StudentsReport);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Failing_Students;
        private System.Windows.Forms.Button Available_Classes;
        private System.Windows.Forms.ComboBox CourseID;
        private System.Windows.Forms.Button All_Person_Button;
        private System.Windows.Forms.Button ExcellentStudents;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView StudentsReport;
    }
}