﻿namespace BranchA_MazalPlus.Lecturer
{
    partial class NewLecture
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Semester = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.Lecture = new System.Windows.Forms.DataGridView();
            this.Available_Classes = new System.Windows.Forms.Button();
            this.NewLec = new System.Windows.Forms.Button();
            this.Hour = new System.Windows.Forms.ComboBox();
            this.Class = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lecture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Semester});
            this.menuStrip1.Location = new System.Drawing.Point(488, 95);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(92, 30);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Semester
            // 
            this.Semester.CheckOnClick = true;
            this.Semester.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem});
            this.Semester.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(117, 24);
            this.Semester.Text = "Semester";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aToolStripMenuItem.Text = "A";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.toolStripComboBox2.Click += new System.EventHandler(this.toolStripComboBox2_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.bToolStripMenuItem.Text = "B";
            // 
            // toolStripComboBox1
            // 
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
            // 
            // Lecture
            // 
            this.Lecture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lecture.Location = new System.Drawing.Point(26, 164);
            this.Lecture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Lecture.Name = "Lecture";
            this.Lecture.RowTemplate.Height = 24;
            this.Lecture.Size = new System.Drawing.Size(830, 314);
            this.Lecture.TabIndex = 11;
            this.Lecture.Visible = false;
            this.Lecture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lecture_CellContentClick);
            // 
            // Available_Classes
            // 
            this.Available_Classes.AccessibleDescription = "Available_Classes";
            this.Available_Classes.Location = new System.Drawing.Point(488, 17);
            this.Available_Classes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Available_Classes.Name = "Available_Classes";
            this.Available_Classes.Size = new System.Drawing.Size(103, 63);
            this.Available_Classes.TabIndex = 12;
            this.Available_Classes.Text = "Available Classes";
            this.Available_Classes.UseVisualStyleBackColor = true;
            this.Available_Classes.Click += new System.EventHandler(this.Available_Classes_Click);
            // 
            // NewLec
            // 
            this.NewLec.Location = new System.Drawing.Point(26, 16);
            this.NewLec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewLec.Name = "NewLec";
            this.NewLec.Size = new System.Drawing.Size(103, 64);
            this.NewLec.TabIndex = 13;
            this.NewLec.Text = "NewLec";
            this.NewLec.UseVisualStyleBackColor = true;
            this.NewLec.Click += new System.EventHandler(this.NewLec_Click);
            // 
            // Hour
            // 
            this.Hour.FormattingEnabled = true;
            this.Hour.Items.AddRange(new object[] {
            "08-09",
            "09-10",
            "10-11",
            "11-12",
            "12-13",
            "13-14",
            "14-15",
            "15-16",
            "16-17",
            "17-18",
            "18-19",
            "19-20",
            "20-21"});
            this.Hour.Location = new System.Drawing.Point(142, 17);
            this.Hour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(142, 24);
            this.Hour.TabIndex = 14;
            this.Hour.SelectedIndexChanged += new System.EventHandler(this.Hour_SelectedIndexChanged);
            // 
            // Class
            // 
            this.Class.FormattingEnabled = true;
            this.Class.Items.AddRange(new object[] {
            "f101",
            "f102",
            "f103",
            "f104",
            "s101",
            "s102",
            "s103",
            "s104",
            "a101",
            "a102"});
            this.Class.Location = new System.Drawing.Point(142, 56);
            this.Class.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(142, 24);
            this.Class.TabIndex = 15;
            // 
            // NewLecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 515);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Hour);
            this.Controls.Add(this.NewLec);
            this.Controls.Add(this.Available_Classes);
            this.Controls.Add(this.Lecture);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewLecture";
            this.Text = "NewLecture";
            this.Load += new System.EventHandler(this.NewLecture_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lecture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Semester;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.DataGridView Lecture;
        private System.Windows.Forms.Button Available_Classes;
        private System.Windows.Forms.Button NewLec;
        private System.Windows.Forms.ComboBox Hour;
        private System.Windows.Forms.ComboBox Class;
    }
}