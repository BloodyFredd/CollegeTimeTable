namespace PRPJECT4NEW.Teaching_Assistant
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
            this.My_Lectures = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Load_table
            // 
            this.Load_table.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Load_table.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Load_table.Location = new System.Drawing.Point(0, 143);
            this.Load_table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Load_table.Name = "Load_table";
            this.Load_table.Size = new System.Drawing.Size(218, 37);
            this.Load_table.TabIndex = 3;
            this.Load_table.Text = "My Colleagues";
            this.Load_table.UseVisualStyleBackColor = false;
            this.Load_table.Click += new System.EventHandler(this.Load_table_Click_1);
            // 
            // StudentsReport
            // 
            this.StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsReport.Location = new System.Drawing.Point(218, 0);
            this.StudentsReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentsReport.Name = "StudentsReport";
            this.StudentsReport.RowTemplate.Height = 24;
            this.StudentsReport.Size = new System.Drawing.Size(299, 327);
            this.StudentsReport.TabIndex = 2;
            this.StudentsReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsReport_CellContentClick);
            // 
            // Grades_Button
            // 
            this.Grades_Button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Grades_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grades_Button.Location = new System.Drawing.Point(0, 178);
            this.Grades_Button.Name = "Grades_Button";
            this.Grades_Button.Size = new System.Drawing.Size(218, 35);
            this.Grades_Button.TabIndex = 5;
            this.Grades_Button.Text = "Grades of Students";
            this.Grades_Button.UseVisualStyleBackColor = false;
            this.Grades_Button.Click += new System.EventHandler(this.Grades_Button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Students Assigned to my Courses";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // EmptyClasses
            // 
            this.EmptyClasses.AccessibleName = "EmptyClasses";
            this.EmptyClasses.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EmptyClasses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmptyClasses.Location = new System.Drawing.Point(0, 246);
            this.EmptyClasses.Name = "EmptyClasses";
            this.EmptyClasses.Size = new System.Drawing.Size(218, 34);
            this.EmptyClasses.TabIndex = 7;
            this.EmptyClasses.Text = "Empty Classes";
            this.EmptyClasses.UseVisualStyleBackColor = false;
            this.EmptyClasses.Click += new System.EventHandler(this.EmptyClasses_Click);
            // 
            // My_Lectures
            // 
            this.My_Lectures.AccessibleName = "My_Lectures";
            this.My_Lectures.BackColor = System.Drawing.SystemColors.HotTrack;
            this.My_Lectures.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.My_Lectures.Location = new System.Drawing.Point(0, 212);
            this.My_Lectures.Name = "My_Lectures";
            this.My_Lectures.Size = new System.Drawing.Size(218, 36);
            this.My_Lectures.TabIndex = 9;
            this.My_Lectures.Text = "My Lectures";
            this.My_Lectures.UseVisualStyleBackColor = false;
            this.My_Lectures.Click += new System.EventHandler(this.My_Lectures_Click);
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Print.Location = new System.Drawing.Point(0, 279);
            this.Print.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(218, 35);
            this.Print.TabIndex = 15;
            this.Print.Text = "Export to Excel";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // panel2
            // 
            this.panel2.AccessibleName = "Buttons_place";
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Print);
            this.panel2.Controls.Add(this.Load_table);
            this.panel2.Controls.Add(this.My_Lectures);
            this.panel2.Controls.Add(this.Grades_Button);
            this.panel2.Controls.Add(this.EmptyClasses);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.panel2.Size = new System.Drawing.Size(218, 327);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 310);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(46, 94);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(32, 14, 0, 14);
            this.menuStrip2.Size = new System.Drawing.Size(99, 49);
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 19);
            this.toolStripMenuItem1.Text = "Semester";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "A";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AccessibleName = "toolStripComboBox1";
            this.toolStripComboBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripComboBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "B";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.AccessibleName = "toolStripComboBox2";
            this.toolStripComboBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripComboBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "03/12/2017",
            "03/13/2017",
            "03/14/2017",
            "03/15/2017",
            "03/16/2017",
            "03/17/2017",
            "03/19/2017",
            "03/20/2017",
            "03/21/2017",
            "03/22/2017",
            "03/23/2017",
            "03/24/2017",
            "03/26/2017",
            "03/27/2017",
            "03/28/2017",
            "03/29/2017",
            "03/30/2017",
            "03/31/2017",
            "04/02/2017",
            "04/03/2017",
            "04/04/2017",
            "04/05/2017",
            "04/06/2017",
            "04/07/2017",
            "04/09/2017",
            "04/10/2017",
            "04/11/2017",
            "04/12/2017",
            "04/13/2017",
            "04/14/2017",
            "04/16/2017",
            "04/17/2017",
            "04/18/2017",
            "04/19/2017",
            "04/20/2017",
            "04/21/2017",
            "04/23/2017",
            "04/24/2017",
            "04/25/2017",
            "04/26/2017",
            "04/27/2017",
            "04/28/2017",
            "04/30/2017",
            "05/01/2017",
            "05/02/2017",
            "05/03/2017",
            "05/04/2017",
            "05/05/2017",
            "05/07/2017",
            "05/08/2017",
            "05/09/2017",
            "05/10/2017",
            "05/11/2017",
            "05/12/2017",
            "05/14/2017",
            "05/15/2017",
            "05/16/2017",
            "05/17/2017",
            "05/18/2017",
            "05/19/2017",
            "05/21/2017",
            "05/22/2017",
            "05/23/2017",
            "05/24/2017",
            "05/25/2017",
            "05/26/2017",
            "05/28/2017",
            "05/29/2017",
            "05/30/2017",
            "05/31/2017"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 23);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 327);
            this.Controls.Add(this.StudentsReport);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load_table;
        private System.Windows.Forms.DataGridView StudentsReport;
        private System.Windows.Forms.Button Grades_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EmptyClasses;
        private System.Windows.Forms.Button My_Lectures;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.Button button2;
    }
}