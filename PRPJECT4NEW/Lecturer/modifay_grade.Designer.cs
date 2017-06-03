namespace PRPJECT4NEW.Lecturer
{
    partial class modifay_grade
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
            this.button1 = new System.Windows.Forms.Button();
            this.course_id = new System.Windows.Forms.ComboBox();
            this.stud_id = new System.Windows.Forms.TextBox();
            this.stud_grade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modifay grade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // course_id
            // 
            this.course_id.FormattingEnabled = true;
            this.course_id.Items.AddRange(new object[] {
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
            this.course_id.Location = new System.Drawing.Point(325, 84);
            this.course_id.Name = "course_id";
            this.course_id.Size = new System.Drawing.Size(121, 24);
            this.course_id.TabIndex = 1;
            this.course_id.Text = "Choose Course ID";
            // 
            // stud_id
            // 
            this.stud_id.Location = new System.Drawing.Point(561, 84);
            this.stud_id.Name = "stud_id";
            this.stud_id.Size = new System.Drawing.Size(116, 22);
            this.stud_id.TabIndex = 2;
            this.stud_id.Text = "insert student ID";
            // 
            // stud_grade
            // 
            this.stud_grade.Location = new System.Drawing.Point(769, 85);
            this.stud_grade.Name = "stud_grade";
            this.stud_grade.Size = new System.Drawing.Size(114, 22);
            this.stud_grade.TabIndex = 3;
            this.stud_grade.Text = "Enter new grade";
            // 
            // modifay_grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 312);
            this.Controls.Add(this.stud_grade);
            this.Controls.Add(this.stud_id);
            this.Controls.Add(this.course_id);
            this.Controls.Add(this.button1);
            this.Name = "modifay_grade";
            this.Text = "modifay_grade";
            this.Load += new System.EventHandler(this.modifay_grade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox course_id;
        private System.Windows.Forms.TextBox stud_id;
        private System.Windows.Forms.TextBox stud_grade;
    }
}