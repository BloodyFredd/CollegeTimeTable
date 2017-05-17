namespace BranchA_MazalPlus.Teaching_Assistant
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
            this.Load_table = new System.Windows.Forms.Button();
            this.StudentsReport = new System.Windows.Forms.DataGridView();
            this.Grades_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EmptyClasses = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.semesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.My_Lectures = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Load_table
            // 
            this.Load_table.Location = new System.Drawing.Point(29, 26);
            this.Load_table.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Load_table.Name = "Load_table";
            this.Load_table.Size = new System.Drawing.Size(243, 52);
            this.Load_table.TabIndex = 3;
            this.Load_table.Text = "My Colleagues";
            this.Load_table.UseVisualStyleBackColor = true;
            this.Load_table.Click += new System.EventHandler(this.Load_table_Click_1);
            // 
            // StudentsReport
            // 
            this.StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsReport.Location = new System.Drawing.Point(29, 238);
            this.StudentsReport.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.StudentsReport.Name = "StudentsReport";
            this.StudentsReport.RowTemplate.Height = 24;
            this.StudentsReport.Size = new System.Drawing.Size(1907, 455);
            this.StudentsReport.TabIndex = 2;
            this.StudentsReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsReport_CellContentClick);
            // 
            // Grades_Button
            // 
            this.Grades_Button.Location = new System.Drawing.Point(285, 29);
            this.Grades_Button.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Grades_Button.Name = "Grades_Button";
            this.Grades_Button.Size = new System.Drawing.Size(307, 52);
            this.Grades_Button.TabIndex = 5;
            this.Grades_Button.Text = "Grades of Students";
            this.Grades_Button.UseVisualStyleBackColor = true;
            this.Grades_Button.Click += new System.EventHandler(this.Grades_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 136);
            this.button1.TabIndex = 6;
            this.button1.Text = "Students Assigned to my Courses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // EmptyClasses
            // 
            this.EmptyClasses.AccessibleName = "EmptyClasses";
            this.EmptyClasses.Location = new System.Drawing.Point(288, 95);
            this.EmptyClasses.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EmptyClasses.Name = "EmptyClasses";
            this.EmptyClasses.Size = new System.Drawing.Size(237, 50);
            this.EmptyClasses.TabIndex = 7;
            this.EmptyClasses.Text = "Empty Classes";
            this.EmptyClasses.UseVisualStyleBackColor = true;
            this.EmptyClasses.Click += new System.EventHandler(this.EmptyClasses_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleName = "Semester";
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.semesterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(291, 162);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(171, 55);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // semesterToolStripMenuItem
            // 
            this.semesterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem});
            this.semesterToolStripMenuItem.Name = "semesterToolStripMenuItem";
            this.semesterToolStripMenuItem.Size = new System.Drawing.Size(153, 45);
            this.semesterToolStripMenuItem.Text = "Semester";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(152, 46);
            this.aToolStripMenuItem.Text = "A";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
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
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 49);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(152, 46);
            this.bToolStripMenuItem.Text = "B";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Items.AddRange(new object[] {
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
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 49);
            // 
            // My_Lectures
            // 
            this.My_Lectures.AccessibleName = "My_Lectures";
            this.My_Lectures.Location = new System.Drawing.Point(611, 29);
            this.My_Lectures.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.My_Lectures.Name = "My_Lectures";
            this.My_Lectures.Size = new System.Drawing.Size(200, 48);
            this.My_Lectures.TabIndex = 9;
            this.My_Lectures.Text = "My Lectures";
            this.My_Lectures.UseVisualStyleBackColor = true;
            this.My_Lectures.Click += new System.EventHandler(this.My_Lectures_Click);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(611, 115);
            this.Print.Margin = new System.Windows.Forms.Padding(6);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(302, 56);
            this.Print.TabIndex = 15;
            this.Print.Text = "Export to Excel";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1960, 718);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.My_Lectures);
            this.Controls.Add(this.EmptyClasses);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Grades_Button);
            this.Controls.Add(this.Load_table);
            this.Controls.Add(this.StudentsReport);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_table;
        private System.Windows.Forms.DataGridView StudentsReport;
        private System.Windows.Forms.Button Grades_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EmptyClasses;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem semesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.Button My_Lectures;
        private System.Windows.Forms.Button Print;
    }
}