namespace BranchA_MazalPlus.Teaching_Assistant
{
    partial class Zero
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
            this.ID_Student = new System.Windows.Forms.TextBox();
            this.Student_ID = new System.Windows.Forms.Label();
            this.Apply = new System.Windows.Forms.Button();
            this.CourseID_Button = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ID_Student
            // 
            this.ID_Student.AccessibleName = "ID_Student";
            this.ID_Student.Location = new System.Drawing.Point(19, 25);
            this.ID_Student.Name = "ID_Student";
            this.ID_Student.Size = new System.Drawing.Size(84, 20);
            this.ID_Student.TabIndex = 0;
            // 
            // Student_ID
            // 
            this.Student_ID.AccessibleName = "Student_ID";
            this.Student_ID.AutoSize = true;
            this.Student_ID.Location = new System.Drawing.Point(16, 9);
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.Size = new System.Drawing.Size(91, 13);
            this.Student_ID.TabIndex = 1;
            this.Student_ID.Text = "ID of the Student:";
            // 
            // Apply
            // 
            this.Apply.AccessibleName = "Apply";
            this.Apply.Location = new System.Drawing.Point(157, 67);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(84, 24);
            this.Apply.TabIndex = 2;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // CourseID_Button
            // 
            this.CourseID_Button.AccessibleName = "Course_ID";
            this.CourseID_Button.FormattingEnabled = true;
            this.CourseID_Button.Items.AddRange(new object[] {
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
            this.CourseID_Button.Location = new System.Drawing.Point(126, 24);
            this.CourseID_Button.Name = "CourseID_Button";
            this.CourseID_Button.Size = new System.Drawing.Size(82, 21);
            this.CourseID_Button.TabIndex = 3;
            // 
            // Zero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 103);
            this.Controls.Add(this.CourseID_Button);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Student_ID);
            this.Controls.Add(this.ID_Student);
            this.Name = "Zero";
            this.Text = "Zero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_Student;
        private System.Windows.Forms.Label Student_ID;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.ComboBox CourseID_Button;
    }
}