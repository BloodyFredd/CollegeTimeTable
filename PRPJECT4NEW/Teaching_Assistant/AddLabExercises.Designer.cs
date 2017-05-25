namespace PRPJECT4NEW.Teaching_Assistant
{
    partial class AddLabExercises
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
            this.CourseIDLabel = new System.Windows.Forms.Label();
            this.CourseIDButton = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartTimeButton = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.Label();
            this.DayButton = new System.Windows.Forms.ComboBox();
            this.Apply_Button = new System.Windows.Forms.Button();
            this.Semester = new System.Windows.Forms.Label();
            this.SemesterButton = new System.Windows.Forms.ComboBox();
            this.Class = new System.Windows.Forms.Label();
            this.ClassButton = new System.Windows.Forms.ComboBox();
            this.Lab_Exercise = new System.Windows.Forms.Label();
            this.LabExercise = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CourseIDLabel
            // 
            this.CourseIDLabel.AccessibleName = "CourseLabel";
            this.CourseIDLabel.AutoSize = true;
            this.CourseIDLabel.Location = new System.Drawing.Point(16, 11);
            this.CourseIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseIDLabel.Name = "CourseIDLabel";
            this.CourseIDLabel.Size = new System.Drawing.Size(74, 17);
            this.CourseIDLabel.TabIndex = 0;
            this.CourseIDLabel.Text = "Course ID:";
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
            this.CourseIDButton.Size = new System.Drawing.Size(105, 24);
            this.CourseIDButton.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AccessibleName = "StartTime";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Time:";
            // 
            // StartTimeButton
            // 
            this.StartTimeButton.AccessibleName = "StartTime";
            this.StartTimeButton.FormattingEnabled = true;
            this.StartTimeButton.Items.AddRange(new object[] {
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
            "18",
            "19"});
            this.StartTimeButton.Location = new System.Drawing.Point(131, 31);
            this.StartTimeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartTimeButton.Name = "StartTimeButton";
            this.StartTimeButton.Size = new System.Drawing.Size(97, 24);
            this.StartTimeButton.TabIndex = 3;
            // 
            // Day
            // 
            this.Day.AccessibleName = "Day";
            this.Day.AutoSize = true;
            this.Day.Location = new System.Drawing.Point(16, 70);
            this.Day.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(37, 17);
            this.Day.TabIndex = 4;
            this.Day.Text = "Day:";
            // 
            // DayButton
            // 
            this.DayButton.AccessibleName = "DayButton";
            this.DayButton.FormattingEnabled = true;
            this.DayButton.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.DayButton.Location = new System.Drawing.Point(16, 90);
            this.DayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DayButton.Name = "DayButton";
            this.DayButton.Size = new System.Drawing.Size(105, 24);
            this.DayButton.TabIndex = 5;
            // 
            // Apply_Button
            // 
            this.Apply_Button.AccessibleName = "Apply_Button";
            this.Apply_Button.Location = new System.Drawing.Point(131, 196);
            this.Apply_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Apply_Button.Name = "Apply_Button";
            this.Apply_Button.Size = new System.Drawing.Size(92, 31);
            this.Apply_Button.TabIndex = 6;
            this.Apply_Button.Text = "Apply";
            this.Apply_Button.UseVisualStyleBackColor = true;
            this.Apply_Button.Click += new System.EventHandler(this.Apply_Button_Click);
            // 
            // Semester
            // 
            this.Semester.AccessibleName = "Semester";
            this.Semester.AutoSize = true;
            this.Semester.Location = new System.Drawing.Point(132, 70);
            this.Semester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(72, 17);
            this.Semester.TabIndex = 7;
            this.Semester.Text = "Semester:";
            // 
            // SemesterButton
            // 
            this.SemesterButton.AccessibleName = "SemesterButton";
            this.SemesterButton.FormattingEnabled = true;
            this.SemesterButton.Items.AddRange(new object[] {
            "a",
            "b"});
            this.SemesterButton.Location = new System.Drawing.Point(131, 90);
            this.SemesterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SemesterButton.Name = "SemesterButton";
            this.SemesterButton.Size = new System.Drawing.Size(97, 24);
            this.SemesterButton.TabIndex = 8;
            // 
            // Class
            // 
            this.Class.AccessibleName = "Class";
            this.Class.AutoSize = true;
            this.Class.Location = new System.Drawing.Point(16, 132);
            this.Class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(46, 17);
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
            this.ClassButton.Location = new System.Drawing.Point(16, 151);
            this.ClassButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClassButton.Name = "ClassButton";
            this.ClassButton.Size = new System.Drawing.Size(105, 24);
            this.ClassButton.TabIndex = 10;
            // 
            // Lab_Exercise
            // 
            this.Lab_Exercise.AccessibleName = "Lab/Exercise";
            this.Lab_Exercise.AutoSize = true;
            this.Lab_Exercise.Location = new System.Drawing.Point(132, 132);
            this.Lab_Exercise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Exercise.Name = "Lab_Exercise";
            this.Lab_Exercise.Size = new System.Drawing.Size(93, 17);
            this.Lab_Exercise.TabIndex = 11;
            this.Lab_Exercise.Text = "Lab/Exercise:";
            // 
            // LabExercise
            // 
            this.LabExercise.AccessibleName = "LabExerciseButton";
            this.LabExercise.FormattingEnabled = true;
            this.LabExercise.Items.AddRange(new object[] {
            "Lab",
            "Exercise"});
            this.LabExercise.Location = new System.Drawing.Point(131, 151);
            this.LabExercise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExercise.Name = "LabExercise";
            this.LabExercise.Size = new System.Drawing.Size(97, 24);
            this.LabExercise.TabIndex = 12;
            // 
            // AddLabExercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 241);
            this.Controls.Add(this.LabExercise);
            this.Controls.Add(this.Lab_Exercise);
            this.Controls.Add(this.ClassButton);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.SemesterButton);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.Apply_Button);
            this.Controls.Add(this.DayButton);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.StartTimeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CourseIDButton);
            this.Controls.Add(this.CourseIDLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddLabExercises";
            this.Text = "AddLabExercises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseIDLabel;
        private System.Windows.Forms.ComboBox CourseIDButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StartTimeButton;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.ComboBox DayButton;
        private System.Windows.Forms.Button Apply_Button;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.ComboBox SemesterButton;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.ComboBox ClassButton;
        private System.Windows.Forms.Label Lab_Exercise;
        private System.Windows.Forms.ComboBox LabExercise;
    }
}