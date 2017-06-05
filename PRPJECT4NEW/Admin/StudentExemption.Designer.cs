namespace PRPJECT4NEW.Admin
{
    partial class StudentExemption
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
            this.Students = new System.Windows.Forms.DataGridView();
            this.ShowStudents = new System.Windows.Forms.Button();
            this.Exemption = new System.Windows.Forms.Button();
            this.Stud_ID = new System.Windows.Forms.TextBox();
            this.Course = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Students)).BeginInit();
            this.SuspendLayout();
            // 
            // Students
            // 
            this.Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Students.Location = new System.Drawing.Point(53, 284);
            this.Students.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Students.Name = "Students";
            this.Students.RowTemplate.Height = 24;
            this.Students.Size = new System.Drawing.Size(1660, 608);
            this.Students.TabIndex = 12;
            this.Students.Visible = false;
            this.Students.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Students_CellContentClick);
            // 
            // ShowStudents
            // 
            this.ShowStudents.Location = new System.Drawing.Point(53, 40);
            this.ShowStudents.Margin = new System.Windows.Forms.Padding(4);
            this.ShowStudents.Name = "ShowStudents";
            this.ShowStudents.Size = new System.Drawing.Size(206, 124);
            this.ShowStudents.TabIndex = 14;
            this.ShowStudents.Text = "Show all the students";
            this.ShowStudents.UseVisualStyleBackColor = true;
            this.ShowStudents.Click += new System.EventHandler(this.ShowStudents_Click);
            // 
            // Exemption
            // 
            this.Exemption.Location = new System.Drawing.Point(364, 40);
            this.Exemption.Margin = new System.Windows.Forms.Padding(4);
            this.Exemption.Name = "Exemption";
            this.Exemption.Size = new System.Drawing.Size(206, 124);
            this.Exemption.TabIndex = 15;
            this.Exemption.Text = "Exemption";
            this.Exemption.UseVisualStyleBackColor = true;
            this.Exemption.Click += new System.EventHandler(this.Exemption_Click);
            // 
            // Stud_ID
            // 
            this.Stud_ID.BackColor = System.Drawing.Color.White;
            this.Stud_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stud_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stud_ID.ForeColor = System.Drawing.Color.Black;
            this.Stud_ID.Location = new System.Drawing.Point(775, 40);
            this.Stud_ID.Margin = new System.Windows.Forms.Padding(8);
            this.Stud_ID.Name = "Stud_ID";
            this.Stud_ID.Size = new System.Drawing.Size(488, 38);
            this.Stud_ID.TabIndex = 17;
            // 
            // Course
            // 
            this.Course.BackColor = System.Drawing.Color.White;
            this.Course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.ForeColor = System.Drawing.Color.Black;
            this.Course.Location = new System.Drawing.Point(773, 113);
            this.Course.Margin = new System.Windows.Forms.Padding(8);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(488, 38);
            this.Course.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Course:";
            // 
            // StudentExemption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1775, 1028);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.Stud_ID);
            this.Controls.Add(this.Exemption);
            this.Controls.Add(this.ShowStudents);
            this.Controls.Add(this.Students);
            this.Name = "StudentExemption";
            this.Text = "StudentExemption";
            ((System.ComponentModel.ISupportInitialize)(this.Students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Students;
        private System.Windows.Forms.Button ShowStudents;
        private System.Windows.Forms.Button Exemption;
        private System.Windows.Forms.TextBox Stud_ID;
        private System.Windows.Forms.TextBox Course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}