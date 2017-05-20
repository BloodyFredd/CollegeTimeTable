namespace BranchA_MazalPlus.Lecturer
{
    partial class AddLecture
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
            this.CourseID = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.Semester = new System.Windows.Forms.Label();
            this.Apply = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CourseID
            // 
            this.CourseID.AccessibleName = "CourseID";
            this.CourseID.AutoSize = true;
            this.CourseID.Location = new System.Drawing.Point(12, 9);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(57, 13);
            this.CourseID.TabIndex = 0;
            this.CourseID.Text = "Course ID:";
            // 
            // StartTime
            // 
            this.StartTime.AccessibleName = "StartTime";
            this.StartTime.AutoSize = true;
            this.StartTime.Location = new System.Drawing.Point(95, 9);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(58, 13);
            this.StartTime.TabIndex = 1;
            this.StartTime.Text = "Start Time:";
            // 
            // Day
            // 
            this.Day.AccessibleName = "Day";
            this.Day.AutoSize = true;
            this.Day.Location = new System.Drawing.Point(12, 49);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(29, 13);
            this.Day.TabIndex = 2;
            this.Day.Text = "Day:";
            // 
            // Semester
            // 
            this.Semester.AccessibleName = "Semester";
            this.Semester.AutoSize = true;
            this.Semester.Location = new System.Drawing.Point(99, 49);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(54, 13);
            this.Semester.TabIndex = 3;
            this.Semester.Text = "Semester:";
            // 
            // Apply
            // 
            this.Apply.AccessibleName = "Apply";
            this.Apply.Location = new System.Drawing.Point(69, 96);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(57, 22);
            this.Apply.TabIndex = 4;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(12, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.comboBox2.Location = new System.Drawing.Point(98, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(76, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.comboBox3.Location = new System.Drawing.Point(12, 65);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(67, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "A",
            "B"});
            this.comboBox4.Location = new System.Drawing.Point(98, 65);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(76, 21);
            this.comboBox4.TabIndex = 8;
            // 
            // AddLecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 136);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.CourseID);
            this.Name = "AddLecture";
            this.Text = "AddLecture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseID;
        private System.Windows.Forms.Label StartTime;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}