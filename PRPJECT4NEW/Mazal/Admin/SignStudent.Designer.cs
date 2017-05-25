namespace BranchA_MazalPlus.Admin
{
    partial class SignStudent
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
            this.ShowStudents = new System.Windows.Forms.Button();
            this.Students = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Stud_ID = new System.Windows.Forms.TextBox();
            this.Sign_student = new System.Windows.Forms.Button();
            this.serial = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Students)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowStudents
            // 
            this.ShowStudents.Location = new System.Drawing.Point(185, 88);
            this.ShowStudents.Margin = new System.Windows.Forms.Padding(4);
            this.ShowStudents.Name = "ShowStudents";
            this.ShowStudents.Size = new System.Drawing.Size(206, 124);
            this.ShowStudents.TabIndex = 16;
            this.ShowStudents.Text = "Show all the students";
            this.ShowStudents.UseVisualStyleBackColor = true;
            this.ShowStudents.Click += new System.EventHandler(this.ShowStudents_Click);
            // 
            // Students
            // 
            this.Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Students.Location = new System.Drawing.Point(185, 332);
            this.Students.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Students.Name = "Students";
            this.Students.RowTemplate.Height = 24;
            this.Students.Size = new System.Drawing.Size(1660, 608);
            this.Students.TabIndex = 15;
            this.Students.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(759, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Course serial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(759, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Student ID:";
            // 
            // Stud_ID
            // 
            this.Stud_ID.BackColor = System.Drawing.Color.White;
            this.Stud_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stud_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stud_ID.ForeColor = System.Drawing.Color.Black;
            this.Stud_ID.Location = new System.Drawing.Point(966, 88);
            this.Stud_ID.Margin = new System.Windows.Forms.Padding(8);
            this.Stud_ID.Name = "Stud_ID";
            this.Stud_ID.Size = new System.Drawing.Size(331, 38);
            this.Stud_ID.TabIndex = 22;
            // 
            // Sign_student
            // 
            this.Sign_student.Location = new System.Drawing.Point(511, 88);
            this.Sign_student.Margin = new System.Windows.Forms.Padding(4);
            this.Sign_student.Name = "Sign_student";
            this.Sign_student.Size = new System.Drawing.Size(206, 124);
            this.Sign_student.TabIndex = 21;
            this.Sign_student.Text = "Sign student";
            this.Sign_student.UseVisualStyleBackColor = true;
            this.Sign_student.Click += new System.EventHandler(this.Sign_student_Click);
            // 
            // serial
            // 
            this.serial.FormattingEnabled = true;
            this.serial.Items.AddRange(new object[] {
            "1003",
            "1004",
            "1005",
            "1006",
            "1007"});
            this.serial.Location = new System.Drawing.Point(966, 161);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(331, 39);
            this.serial.TabIndex = 26;
            this.serial.Text = "Course serial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(759, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 32);
            this.label3.TabIndex = 28;
            this.label3.Text = "Course:";
            // 
            // Course
            // 
            this.Course.BackColor = System.Drawing.Color.White;
            this.Course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.ForeColor = System.Drawing.Color.Black;
            this.Course.Location = new System.Drawing.Point(966, 226);
            this.Course.Margin = new System.Windows.Forms.Padding(8);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(331, 38);
            this.Course.TabIndex = 27;
            // 
            // SignStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2031, 1029);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.serial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stud_ID);
            this.Controls.Add(this.Sign_student);
            this.Controls.Add(this.ShowStudents);
            this.Controls.Add(this.Students);
            this.Name = "SignStudent";
            this.Text = "SignStudent";
            ((System.ComponentModel.ISupportInitialize)(this.Students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowStudents;
        private System.Windows.Forms.DataGridView Students;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Stud_ID;
        private System.Windows.Forms.Button Sign_student;
        private System.Windows.Forms.ComboBox serial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Course;
    }
}