namespace BranchA_MazalPlus.Lecturer
{
    partial class ReceptionHours
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
            this.Office_Button = new System.Windows.Forms.ComboBox();
            this.CourseID_Button = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Office_Button
            // 
            this.Office_Button.FormattingEnabled = true;
            this.Office_Button.Items.AddRange(new object[] {
            "TG100",
            "TG101",
            "TG102",
            "TG103",
            "TG104",
            "TG105",
            "TG106",
            "TG107",
            "TG108",
            "TG109"});
            this.Office_Button.Location = new System.Drawing.Point(4, 25);
            this.Office_Button.Name = "Office_Button";
            this.Office_Button.Size = new System.Drawing.Size(71, 21);
            this.Office_Button.TabIndex = 0;
            this.Office_Button.Text = "Offices";
            // 
            // CourseID_Button
            // 
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
            this.CourseID_Button.Location = new System.Drawing.Point(90, 25);
            this.CourseID_Button.Name = "CourseID_Button";
            this.CourseID_Button.Size = new System.Drawing.Size(71, 21);
            this.CourseID_Button.TabIndex = 1;
            this.CourseID_Button.Text = "Course ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose an office and course ID that you teach";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReceptionHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 97);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CourseID_Button);
            this.Controls.Add(this.Office_Button);
            this.Name = "ReceptionHours";
            this.Text = "ReceptionHours";
            this.Load += new System.EventHandler(this.ReceptionHours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Office_Button;
        private System.Windows.Forms.ComboBox CourseID_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}