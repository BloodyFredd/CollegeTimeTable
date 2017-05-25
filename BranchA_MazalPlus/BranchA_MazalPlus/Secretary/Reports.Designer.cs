namespace BranchA_MazalPlus.Secretary
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
            this.Load_table = new System.Windows.Forms.Button();
            this.StudentsReport = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CourseID = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Print = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Report = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Load_table
            // 
            this.Load_table.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Load_table.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Load_table.Location = new System.Drawing.Point(0, 222);
            this.Load_table.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Load_table.Name = "Load_table";
            this.Load_table.Size = new System.Drawing.Size(582, 89);
            this.Load_table.TabIndex = 3;
            this.Load_table.Text = "Show Students only!";
            this.Load_table.UseVisualStyleBackColor = false;
            this.Load_table.Click += new System.EventHandler(this.Load_table_Click_1);
            // 
            // StudentsReport
            // 
            this.StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsReport.Location = new System.Drawing.Point(585, 124);
            this.StudentsReport.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.StudentsReport.Name = "StudentsReport";
            this.StudentsReport.RowTemplate.Height = 24;
            this.StudentsReport.Size = new System.Drawing.Size(2920, 1824);
            this.StudentsReport.TabIndex = 2;
            this.StudentsReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsReport_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 451);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(582, 89);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show Teaching Staff only!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 346);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(582, 110);
            this.button2.TabIndex = 5;
            this.button2.Text = "Failing Students";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CourseID
            // 
            this.CourseID.BackColor = System.Drawing.SystemColors.HotTrack;
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
            this.CourseID.Location = new System.Drawing.Point(0, 310);
            this.CourseID.Margin = new System.Windows.Forms.Padding(6);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(582, 39);
            this.CourseID.TabIndex = 6;
            this.CourseID.Text = "                       Course ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(24, 202);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Print.Location = new System.Drawing.Point(0, 536);
            this.Print.Margin = new System.Windows.Forms.Padding(6);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(582, 78);
            this.Print.TabIndex = 15;
            this.Print.Text = "Export to Excel";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(0, 124);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(582, 102);
            this.button3.TabIndex = 16;
            this.button3.Text = "General average grades of all students in specific course";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // panel2
            // 
            this.panel2.AccessibleName = "Buttons_place";
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.Load_table);
            this.panel2.Controls.Add(this.CourseID);
            this.panel2.Controls.Add(this.Print);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 17, 0, 0);
            this.panel2.Size = new System.Drawing.Size(582, 1050);
            this.panel2.TabIndex = 18;
            // 
            // Report
            // 
            this.Report.AccessibleName = "Reports";
            this.Report.AutoSize = true;
            this.Report.Dock = System.Windows.Forms.DockStyle.Left;
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.ForeColor = System.Drawing.Color.White;
            this.Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Report.Location = new System.Drawing.Point(582, 0);
            this.Report.Margin = new System.Windows.Forms.Padding(6, 21, 10, 0);
            this.Report.Name = "Report";
            this.Report.Padding = new System.Windows.Forms.Padding(26, 39, 0, 0);
            this.Report.Size = new System.Drawing.Size(186, 85);
            this.Report.TabIndex = 4;
            this.Report.Text = "Reports";
            this.Report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "Header";
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Report);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-816, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4350, 122);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AccessibleName = "Reports";
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(768, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 21, 10, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(26, 39, 0, 0);
            this.label1.Size = new System.Drawing.Size(186, 85);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4238, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 2, 24, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 31, 90, 0);
            this.pictureBox1.Size = new System.Drawing.Size(112, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 122);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.flowLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(534, 122);
            this.panel4.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(262, 83);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(784, 234);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AccessibleName = "Reports";
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(582, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 21, 10, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(26, 39, 0, 0);
            this.label2.Size = new System.Drawing.Size(186, 85);
            this.label2.TabIndex = 19;
            this.label2.Text = "Reports";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1878, 1050);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StudentsReport);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_table;
        private System.Windows.Forms.DataGridView StudentsReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CourseID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label Report;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}