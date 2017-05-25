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
            this.CourseIDButton = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.ComboBox();
            this.DayButton = new System.Windows.Forms.ComboBox();
            this.SemesterButton = new System.Windows.Forms.ComboBox();
            this.Class = new System.Windows.Forms.Label();
            this.ClassButton = new System.Windows.Forms.ComboBox();
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
            this.Apply.Location = new System.Drawing.Point(98, 105);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(76, 21);
            this.Apply.TabIndex = 4;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // CourseIDButton
            // 
            this.CourseIDButton.AccessibleName = "CourseID";
            this.CourseIDButton.FormattingEnabled = true;
            this.CourseIDButton.Items.AddRange(new object[] {
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
            this.CourseIDButton.Location = new System.Drawing.Point(12, 25);
            this.CourseIDButton.Name = "CourseIDButton";
            this.CourseIDButton.Size = new System.Drawing.Size(67, 21);
            this.CourseIDButton.TabIndex = 5;
            // 
            // StartButton
            // 
            this.StartButton.AccessibleName = "StartButton";
            this.StartButton.FormattingEnabled = true;
            this.StartButton.Items.AddRange(new object[] {
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
            this.StartButton.Location = new System.Drawing.Point(98, 25);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(76, 21);
            this.StartButton.TabIndex = 6;
            // 
            // DayButton
            // 
            this.DayButton.AccessibleName = "Day";
            this.DayButton.FormattingEnabled = true;
            this.DayButton.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.DayButton.Location = new System.Drawing.Point(12, 65);
            this.DayButton.Name = "DayButton";
            this.DayButton.Size = new System.Drawing.Size(67, 21);
            this.DayButton.TabIndex = 7;
            // 
            // SemesterButton
            // 
            this.SemesterButton.AccessibleName = "SemesterButton";
            this.SemesterButton.FormattingEnabled = true;
            this.SemesterButton.Items.AddRange(new object[] {
            "a",
            "b"});
            this.SemesterButton.Location = new System.Drawing.Point(98, 65);
            this.SemesterButton.Name = "SemesterButton";
            this.SemesterButton.Size = new System.Drawing.Size(76, 21);
            this.SemesterButton.TabIndex = 8;
            // 
            // Class
            // 
            this.Class.AccessibleName = "Class";
            this.Class.AutoSize = true;
            this.Class.Location = new System.Drawing.Point(12, 89);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(35, 13);
            this.Class.TabIndex = 9;
            this.Class.Text = "Class:";
            // 
            // ClassButton
            // 
            this.ClassButton.AccessibleName = "ClassID";
            this.ClassButton.FormattingEnabled = true;
            this.ClassButton.Items.AddRange(new object[] {
            "a101",
            "a102",
            "f101",
            "f102",
            "f103",
            "f104",
            "s101",
            "s102",
            "s103",
            "s104"});
            this.ClassButton.Location = new System.Drawing.Point(12, 105);
            this.ClassButton.Name = "ClassButton";
            this.ClassButton.Size = new System.Drawing.Size(67, 21);
            this.ClassButton.TabIndex = 10;
            // 
            // AddLecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 147);
            this.Controls.Add(this.ClassButton);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.SemesterButton);
            this.Controls.Add(this.DayButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CourseIDButton);
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
        private System.Windows.Forms.ComboBox CourseIDButton;
        private System.Windows.Forms.ComboBox StartButton;
        private System.Windows.Forms.ComboBox DayButton;
        private System.Windows.Forms.ComboBox SemesterButton;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.ComboBox ClassButton;
    }
}