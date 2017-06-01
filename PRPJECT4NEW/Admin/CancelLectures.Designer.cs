namespace PRPJECT4NEW.Admin
{
    partial class CancelLectures
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
            this.Class = new System.Windows.Forms.ComboBox();
            this.Cancel_Lecture = new System.Windows.Forms.Button();
            this.Available_Classes = new System.Windows.Forms.Button();
            this.Lecture = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Semester = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lecture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.Class.Location = new System.Drawing.Point(105, 20);
            this.Class.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(108, 21);
            this.Class.TabIndex = 21;
            this.Class.Text = "Choose class";
            // 
            // Cancel_Lecture
            // 
            this.Cancel_Lecture.Location = new System.Drawing.Point(19, 20);
            this.Cancel_Lecture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancel_Lecture.Name = "Cancel_Lecture";
            this.Cancel_Lecture.Size = new System.Drawing.Size(77, 52);
            this.Cancel_Lecture.TabIndex = 19;
            this.Cancel_Lecture.Text = "Cancel Lecture";
            this.Cancel_Lecture.UseVisualStyleBackColor = true;
            this.Cancel_Lecture.Click += new System.EventHandler(this.Cancel_Lecture_Click);
            // 
            // Available_Classes
            // 
            this.Available_Classes.AccessibleDescription = "Available_Classes";
            this.Available_Classes.Location = new System.Drawing.Point(259, 19);
            this.Available_Classes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Available_Classes.Name = "Available_Classes";
            this.Available_Classes.Size = new System.Drawing.Size(77, 51);
            this.Available_Classes.TabIndex = 18;
            this.Available_Classes.Text = "Available Classes";
            this.Available_Classes.UseVisualStyleBackColor = true;
            this.Available_Classes.Click += new System.EventHandler(this.Available_Classes_Click);
            // 
            // Lecture
            // 
            this.Lecture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lecture.Location = new System.Drawing.Point(14, 119);
            this.Lecture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Lecture.Name = "Lecture";
            this.Lecture.RowTemplate.Height = 24;
            this.Lecture.Size = new System.Drawing.Size(622, 255);
            this.Lecture.TabIndex = 17;
            this.Lecture.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Semester});
            this.menuStrip1.Location = new System.Drawing.Point(105, 47);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(167, 25);
            this.menuStrip1.TabIndex = 16;
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
            this.Semester.Size = new System.Drawing.Size(67, 19);
            this.Semester.Text = "Semester";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 23);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bToolStripMenuItem.Text = "B";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
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
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // CancelLectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 311);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Cancel_Lecture);
            this.Controls.Add(this.Available_Classes);
            this.Controls.Add(this.Lecture);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "CancelLectures";
            this.Text = "CancelLectures";
            ((System.ComponentModel.ISupportInitialize)(this.Lecture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.Button Cancel_Lecture;
        private System.Windows.Forms.Button Available_Classes;
        private System.Windows.Forms.DataGridView Lecture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Semester;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}