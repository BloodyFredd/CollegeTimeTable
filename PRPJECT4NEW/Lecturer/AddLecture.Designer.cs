namespace PRPJECT4NEW.Lecturer
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
            this.CourseID.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseID.Location = new System.Drawing.Point(16, 11);
            this.CourseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(77, 19);
            this.CourseID.TabIndex = 0;
            this.CourseID.Text = "Course ID:";
            // 
            // StartTime
            // 
            this.StartTime.AccessibleName = "StartTime";
            this.StartTime.AutoSize = true;
            this.StartTime.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTime.Location = new System.Drawing.Point(127, 11);
            this.StartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(78, 19);
            this.StartTime.TabIndex = 1;
            this.StartTime.Text = "Start Time:";
            // 
            // Day
            // 
            this.Day.AccessibleName = "Day";
            this.Day.AutoSize = true;
            this.Day.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.Location = new System.Drawing.Point(16, 60);
            this.Day.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(41, 19);
            this.Day.TabIndex = 2;
            this.Day.Text = "Day:";
            // 
            // Semester
            // 
            this.Semester.AccessibleName = "Semester";
            this.Semester.AutoSize = true;
            this.Semester.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Semester.Location = new System.Drawing.Point(132, 60);
            this.Semester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(74, 19);
            this.Semester.TabIndex = 3;
            this.Semester.Text = "Semester:";
            // 
            // Apply
            // 
            this.Apply.AccessibleName = "Apply";
            this.Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Apply.FlatAppearance.BorderSize = 0;
            this.Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apply.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply.ForeColor = System.Drawing.Color.White;
            this.Apply.Location = new System.Drawing.Point(131, 129);
            this.Apply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(101, 26);
            this.Apply.TabIndex = 4;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = false;
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
            this.CourseIDButton.Location = new System.Drawing.Point(16, 31);
            this.CourseIDButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseIDButton.Name = "CourseIDButton";
            this.CourseIDButton.Size = new System.Drawing.Size(88, 24);
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
            this.StartButton.Location = new System.Drawing.Point(131, 31);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 24);
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
            this.DayButton.Location = new System.Drawing.Point(16, 80);
            this.DayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DayButton.Name = "DayButton";
            this.DayButton.Size = new System.Drawing.Size(88, 24);
            this.DayButton.TabIndex = 7;
            // 
            // SemesterButton
            // 
            this.SemesterButton.AccessibleName = "SemesterButton";
            this.SemesterButton.FormattingEnabled = true;
            this.SemesterButton.Items.AddRange(new object[] {
            "a",
            "b"});
            this.SemesterButton.Location = new System.Drawing.Point(131, 80);
            this.SemesterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SemesterButton.Name = "SemesterButton";
            this.SemesterButton.Size = new System.Drawing.Size(100, 24);
            this.SemesterButton.TabIndex = 8;
            // 
            // Class
            // 
            this.Class.AccessibleName = "Class";
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(16, 110);
            this.Class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(47, 19);
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
            this.ClassButton.Location = new System.Drawing.Point(16, 129);
            this.ClassButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClassButton.Name = "ClassButton";
            this.ClassButton.Size = new System.Drawing.Size(88, 24);
            this.ClassButton.TabIndex = 10;
            // 
            // AddLecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.ClientSize = new System.Drawing.Size(261, 181);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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