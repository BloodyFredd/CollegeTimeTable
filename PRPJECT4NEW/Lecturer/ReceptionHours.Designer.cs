namespace PRPJECT4NEW.Lecturer
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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Office_Button
            // 
            this.Office_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Office_Button.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Office_Button.ForeColor = System.Drawing.Color.White;
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
            this.Office_Button.Location = new System.Drawing.Point(5, 31);
            this.Office_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Office_Button.Name = "Office_Button";
            this.Office_Button.Size = new System.Drawing.Size(93, 25);
            this.Office_Button.TabIndex = 0;
            this.Office_Button.Text = "Offices";
            // 
            // CourseID_Button
            // 
            this.CourseID_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.CourseID_Button.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseID_Button.ForeColor = System.Drawing.Color.White;
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
            this.CourseID_Button.Location = new System.Drawing.Point(120, 31);
            this.CourseID_Button.Margin = new System.Windows.Forms.Padding(4);
            this.CourseID_Button.Name = "CourseID_Button";
            this.CourseID_Button.Size = new System.Drawing.Size(93, 25);
            this.CourseID_Button.TabIndex = 1;
            this.CourseID_Button.Text = "Course ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose an office and course ID that you teach";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(191, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "Apply";
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(191, 122);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReceptionHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.ClientSize = new System.Drawing.Size(388, 170);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CourseID_Button);
            this.Controls.Add(this.Office_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button button2;
    }
}