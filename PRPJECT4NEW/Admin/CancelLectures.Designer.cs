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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Class = new System.Windows.Forms.ComboBox();
            this.Lecture = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.My_Lectures = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Lecture)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Class
            // 
            this.Class.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Class.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.Class.Location = new System.Drawing.Point(59, 188);
            this.Class.Margin = new System.Windows.Forms.Padding(5);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(337, 39);
            this.Class.TabIndex = 21;
            this.Class.Text = "Choose class";
            // 
            // Lecture
            // 
            this.Lecture.AllowUserToAddRows = false;
            this.Lecture.AllowUserToDeleteRows = false;
            this.Lecture.AllowUserToResizeColumns = false;
            this.Lecture.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lecture.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Lecture.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Lecture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lecture.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lecture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Lecture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lecture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lecture.Location = new System.Drawing.Point(0, 0);
            this.Lecture.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Lecture.MultiSelect = false;
            this.Lecture.Name = "Lecture";
            this.Lecture.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lecture.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Lecture.RowHeadersVisible = false;
            this.Lecture.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Lecture.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Lecture.RowTemplate.Height = 24;
            this.Lecture.Size = new System.Drawing.Size(2221, 368);
            this.Lecture.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "Buttons_place";
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Controls.Add(this.Class);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.My_Lectures);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 368);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2221, 436);
            this.panel1.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(2036, 316);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 83);
            this.button4.TabIndex = 22;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(1821, 186);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip2.Size = new System.Drawing.Size(177, 46);
            this.menuStrip2.TabIndex = 15;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 44);
            this.toolStripMenuItem1.Text = "Semester";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 46);
            this.toolStripMenuItem2.Text = "A";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.AccessibleName = "";
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
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 49);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(154, 46);
            this.toolStripMenuItem3.Text = "B";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AccessibleName = "toolStripComboBox2";
            this.toolStripComboBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripComboBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 49);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 1407);
            this.button1.Margin = new System.Windows.Forms.Padding(13, 17, 13, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1549, 198);
            this.button1.TabIndex = 19;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(1091, 141);
            this.button3.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(624, 167);
            this.button3.TabIndex = 6;
            this.button3.Text = "Available Classes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // My_Lectures
            // 
            this.My_Lectures.AccessibleName = "My_Lectures";
            this.My_Lectures.BackColor = System.Drawing.SystemColors.HotTrack;
            this.My_Lectures.FlatAppearance.BorderSize = 0;
            this.My_Lectures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.My_Lectures.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.My_Lectures.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.My_Lectures.Location = new System.Drawing.Point(475, 141);
            this.My_Lectures.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.My_Lectures.Name = "My_Lectures";
            this.My_Lectures.Size = new System.Drawing.Size(589, 167);
            this.My_Lectures.TabIndex = 9;
            this.My_Lectures.Text = "Cancel Lecture";
            this.My_Lectures.UseVisualStyleBackColor = false;
            this.My_Lectures.Click += new System.EventHandler(this.My_Lectures_Click);
            // 
            // CancelLectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2221, 804);
            this.Controls.Add(this.Lecture);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CancelLectures";
            this.Text = "CancelLectures";
            ((System.ComponentModel.ISupportInitialize)(this.Lecture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.DataGridView Lecture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button My_Lectures;
        private System.Windows.Forms.Button button4;
    }
}