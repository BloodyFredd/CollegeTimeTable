namespace PRPJECT4NEW.Secretary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Load_table = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CourseID = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Print = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.StudentsReport = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StudentReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentReport)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_table
            // 
            this.Load_table.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Load_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Load_table.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Load_table.Location = new System.Drawing.Point(687, 19);
            this.Load_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Load_table.Name = "Load_table";
            this.Load_table.Size = new System.Drawing.Size(291, 53);
            this.Load_table.TabIndex = 3;
            this.Load_table.Text = "Show Students only!";
            this.Load_table.UseVisualStyleBackColor = false;
            this.Load_table.Click += new System.EventHandler(this.Load_table_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(687, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show Teaching Staff only!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(302, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "Failing Students";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CourseID
            // 
            this.CourseID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CourseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.CourseID.Location = new System.Drawing.Point(61, 92);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(223, 24);
            this.CourseID.TabIndex = 6;
            this.CourseID.SelectedIndexChanged += new System.EventHandler(this.CourseID_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(12, 104);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Print.Location = new System.Drawing.Point(1048, 78);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(291, 51);
            this.Print.TabIndex = 15;
            this.Print.Text = "Export to Excel";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(302, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(291, 53);
            this.button3.TabIndex = 16;
            this.button3.Text = "General average grades of all students in specific course";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(1359, 172);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(290, 48);
            this.button4.TabIndex = 20;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // StudentsReport
            // 
            this.StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsReport.Location = new System.Drawing.Point(0, 0);
            this.StudentsReport.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.StudentsReport.Name = "StudentsReport";
            this.StudentsReport.RowTemplate.Height = 24;
            this.StudentsReport.Size = new System.Drawing.Size(1932, 602);
            this.StudentsReport.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(0, 555);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(581, 78);
            this.button5.TabIndex = 19;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(67, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Course ID:";
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "Buttons_place";
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.Load_table);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Print);
            this.panel1.Controls.Add(this.CourseID);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 369);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1932, 233);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // StudentReport
            // 
            this.StudentReport.AllowUserToAddRows = false;
            this.StudentReport.AllowUserToDeleteRows = false;
            this.StudentReport.AllowUserToResizeColumns = false;
            this.StudentReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.StudentReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.StudentReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.StudentReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.StudentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentReport.Location = new System.Drawing.Point(0, 0);
            this.StudentReport.Margin = new System.Windows.Forms.Padding(6);
            this.StudentReport.MultiSelect = false;
            this.StudentReport.Name = "StudentReport";
            this.StudentReport.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.StudentReport.RowHeadersVisible = false;
            this.StudentReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.StudentReport.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.StudentReport.RowTemplate.Height = 24;
            this.StudentReport.Size = new System.Drawing.Size(1932, 602);
            this.StudentReport.TabIndex = 27;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1932, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StudentReport);
            this.Controls.Add(this.StudentsReport);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CourseID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView StudentsReport;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView StudentReport;
    }
}