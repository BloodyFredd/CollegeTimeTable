namespace BranchA_MazalPlus.Teaching_Assistant
{
    partial class Grade56
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
            this.CourseIdLabel = new System.Windows.Forms.Label();
            this.CourseIDLbel = new System.Windows.Forms.Label();
            this.CourseID = new System.Windows.Forms.ComboBox();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.Apply_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseIdLabel
            // 
            this.CourseIdLabel.AutoSize = true;
            this.CourseIdLabel.Location = new System.Drawing.Point(12, 9);
            this.CourseIdLabel.Name = "CourseIdLabel";
            this.CourseIdLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CourseIdLabel.Size = new System.Drawing.Size(91, 13);
            this.CourseIdLabel.TabIndex = 0;
            this.CourseIdLabel.Text = "ID of the Student:";
            // 
            // CourseIDLbel
            // 
            this.CourseIDLbel.AutoSize = true;
            this.CourseIDLbel.Location = new System.Drawing.Point(122, 9);
            this.CourseIDLbel.Name = "CourseIDLbel";
            this.CourseIDLbel.Size = new System.Drawing.Size(57, 13);
            this.CourseIDLbel.TabIndex = 1;
            this.CourseIDLbel.Text = "Course ID:";
            // 
            // CourseID
            // 
            this.CourseID.AccessibleName = "CourseID";
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
            this.CourseID.Location = new System.Drawing.Point(125, 24);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(54, 21);
            this.CourseID.TabIndex = 2;
            // 
            // StudentID
            // 
            this.StudentID.AccessibleName = "StudentID";
            this.StudentID.Location = new System.Drawing.Point(15, 25);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(88, 20);
            this.StudentID.TabIndex = 3;
            // 
            // Apply_Button
            // 
            this.Apply_Button.AccessibleName = "Apply_Button";
            this.Apply_Button.Location = new System.Drawing.Point(89, 62);
            this.Apply_Button.Name = "Apply_Button";
            this.Apply_Button.Size = new System.Drawing.Size(57, 24);
            this.Apply_Button.TabIndex = 4;
            this.Apply_Button.Text = "Apply";
            this.Apply_Button.UseVisualStyleBackColor = true;
            this.Apply_Button.Click += new System.EventHandler(this.Apply_Button_Click);
            // 
            // Grade56
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 98);
            this.Controls.Add(this.Apply_Button);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.CourseID);
            this.Controls.Add(this.CourseIDLbel);
            this.Controls.Add(this.CourseIdLabel);
            this.Name = "Grade56";
            this.Text = "_56";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseIdLabel;
        private System.Windows.Forms.Label CourseIDLbel;
        private System.Windows.Forms.ComboBox CourseID;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.Button Apply_Button;
    }
}