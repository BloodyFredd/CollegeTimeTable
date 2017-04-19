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
            this.Load_table = new System.Windows.Forms.Button();
            this.StudentsReport = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CourseID = new System.Windows.Forms.ComboBox();
            this.Class_Num = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_table
            // 
            this.Load_table.Location = new System.Drawing.Point(29, 401);
            this.Load_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Load_table.Name = "Load_table";
            this.Load_table.Size = new System.Drawing.Size(197, 46);
            this.Load_table.TabIndex = 3;
            this.Load_table.Text = "Show Students only!";
            this.Load_table.UseVisualStyleBackColor = true;
            this.Load_table.Click += new System.EventHandler(this.Load_table_Click_1);
            // 
            // StudentsReport
            // 
            this.StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsReport.Location = new System.Drawing.Point(29, 12);
            this.StudentsReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentsReport.Name = "StudentsReport";
            this.StudentsReport.RowTemplate.Height = 24;
            this.StudentsReport.Size = new System.Drawing.Size(467, 385);
            this.StudentsReport.TabIndex = 2;
            this.StudentsReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsReport_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 401);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show Teaching Staff only!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 99);
            this.button2.TabIndex = 5;
            this.button2.Text = "Report of students that need to repeat on course ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CourseID
            // 
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
            "400",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406"});
            this.CourseID.Location = new System.Drawing.Point(590, 22);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(95, 24);
            this.CourseID.TabIndex = 6;
            this.CourseID.Text = "Course ID";
            // 
            // Class_Num
            // 
            this.Class_Num.FormattingEnabled = true;
            this.Class_Num.Items.AddRange(new object[] {
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
            this.Class_Num.Location = new System.Drawing.Point(564, 235);
            this.Class_Num.Name = "Class_Num";
            this.Class_Num.Size = new System.Drawing.Size(121, 24);
            this.Class_Num.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 66);
            this.button3.TabIndex = 8;
            this.button3.Text = "modify between 2 classrooms lecture ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 473);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Class_Num);
            this.Controls.Add(this.CourseID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Load_table);
            this.Controls.Add(this.StudentsReport);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load_table;
        private System.Windows.Forms.DataGridView StudentsReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CourseID;
        private System.Windows.Forms.ComboBox Class_Num;
        private System.Windows.Forms.Button button3;
    }
}