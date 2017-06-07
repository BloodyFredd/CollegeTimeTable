namespace PRPJECT4NEW.Teaching_Assistant
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
            this.Office_Button.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.Office_Button.FormattingEnabled = true;
            this.Office_Button.Items.AddRange(new object[] {
            "T100",
            "T101",
            "T102",
            "T103",
            "T104"});
            this.Office_Button.Location = new System.Drawing.Point(12, 45);
            this.Office_Button.Name = "Office_Button";
            this.Office_Button.Size = new System.Drawing.Size(71, 23);
            this.Office_Button.TabIndex = 0;
            this.Office_Button.Text = "Offices";
            // 
            // CourseID_Button
            // 
            this.CourseID_Button.Font = new System.Drawing.Font("Century Gothic", 7.8F);
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
            this.CourseID_Button.Location = new System.Drawing.Point(12, 80);
            this.CourseID_Button.Name = "CourseID_Button";
            this.CourseID_Button.Size = new System.Drawing.Size(71, 23);
            this.CourseID_Button.TabIndex = 1;
            this.CourseID_Button.Text = "Course ID";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose an office and course ID that you teach";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(124, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReceptionHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.ClientSize = new System.Drawing.Size(236, 118);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CourseID_Button);
            this.Controls.Add(this.Office_Button);
            this.Name = "ReceptionHours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceptionHours";
            this.Load += new System.EventHandler(this.ReceptionHours_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Office_Button;
        private System.Windows.Forms.ComboBox CourseID_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}