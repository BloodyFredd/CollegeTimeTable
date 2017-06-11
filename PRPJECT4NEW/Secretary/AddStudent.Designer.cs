namespace PRPJECT4NEW.Secretary
{
    partial class AddStudent
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
            this.Add = new System.Windows.Forms.Button();
            this.CourseID = new System.Windows.Forms.ComboBox();
            this.CourseSerial = new System.Windows.Forms.ComboBox();
            this.Class = new System.Windows.Forms.ComboBox();
            this.Semester = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add.Location = new System.Drawing.Point(274, 422);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(180, 36);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // CourseID
            // 
            this.CourseID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CourseID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            "308",
            "400",
            "401",
            "402",
            "403",
            "404"});
            this.CourseID.Location = new System.Drawing.Point(26, 361);
            this.CourseID.Margin = new System.Windows.Forms.Padding(2);
            this.CourseID.Name = "CourseID";
            this.CourseID.Size = new System.Drawing.Size(135, 21);
            this.CourseID.TabIndex = 1;
            this.CourseID.Text = "course ID";
            // 
            // CourseSerial
            // 
            this.CourseSerial.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CourseSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CourseSerial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CourseSerial.FormattingEnabled = true;
            this.CourseSerial.Items.AddRange(new object[] {
            "1001",
            "1011",
            "1021",
            "1031",
            "1041",
            "1051",
            "1061",
            "1071",
            "1081",
            "2001",
            "2011",
            "2021",
            "2031",
            "2041",
            "2051",
            "2061",
            "2071",
            "2081",
            "2091",
            "3001",
            "3011",
            "3021",
            "3031",
            "3041",
            "3051",
            "3061",
            "3071",
            "3081",
            "4001",
            "4011",
            "4021",
            "4031",
            "4041"});
            this.CourseSerial.Location = new System.Drawing.Point(202, 361);
            this.CourseSerial.Margin = new System.Windows.Forms.Padding(2);
            this.CourseSerial.Name = "CourseSerial";
            this.CourseSerial.Size = new System.Drawing.Size(142, 21);
            this.CourseSerial.TabIndex = 2;
            this.CourseSerial.Text = "course serial";
            // 
            // Class
            // 
            this.Class.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Class.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Class.FormattingEnabled = true;
            this.Class.Items.AddRange(new object[] {
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
            this.Class.Location = new System.Drawing.Point(390, 361);
            this.Class.Margin = new System.Windows.Forms.Padding(2);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(142, 21);
            this.Class.TabIndex = 3;
            this.Class.Text = "class";
            // 
            // Semester
            // 
            this.Semester.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Semester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Semester.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Semester.FormattingEnabled = true;
            this.Semester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Semester.Location = new System.Drawing.Point(573, 361);
            this.Semester.Margin = new System.Windows.Forms.Padding(2);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(142, 21);
            this.Semester.TabIndex = 4;
            this.Semester.Text = "Semester";
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "Buttons_place";
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.CourseID);
            this.panel1.Controls.Add(this.Semester);
            this.panel1.Controls.Add(this.CourseSerial);
            this.panel1.Controls.Add(this.Class);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 602);
            this.panel1.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(667, 458);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 40);
            this.button4.TabIndex = 22;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 602);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox CourseID;
        private System.Windows.Forms.ComboBox CourseSerial;
        private System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.ComboBox Semester;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
    }
}