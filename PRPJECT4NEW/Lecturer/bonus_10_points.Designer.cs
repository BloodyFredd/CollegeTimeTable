namespace PRPJECT4NEW.Lecturer
{
    partial class bonus_10_points
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
            this.course_id = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stud_id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // course_id
            // 
            this.course_id.BackColor = System.Drawing.SystemColors.HotTrack;
            this.course_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.course_id.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.course_id.Location = new System.Drawing.Point(37, 86);
            this.course_id.Name = "course_id";
            this.course_id.Size = new System.Drawing.Size(161, 25);
            this.course_id.TabIndex = 0;
            this.course_id.Text = "Choose course ID";
            this.course_id.SelectedIndexChanged += new System.EventHandler(this.class_num_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(37, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Give Bonus 10 Points";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stud_id
            // 
            this.stud_id.BackColor = System.Drawing.SystemColors.HotTrack;
            this.stud_id.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stud_id.Location = new System.Drawing.Point(37, 34);
            this.stud_id.Name = "stud_id";
            this.stud_id.Size = new System.Drawing.Size(161, 23);
            this.stud_id.TabIndex = 2;
            this.stud_id.Text = "Student ID";
            // 
            // button2
            // 
            this.button2.AccessibleName = "Apply";
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(55, 264);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bonus_10_points
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.ClientSize = new System.Drawing.Size(1146, 495);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.stud_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.course_id);
            this.Name = "bonus_10_points";
            this.Text = "Factor";
            this.Load += new System.EventHandler(this.Factor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox course_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox stud_id;
        private System.Windows.Forms.Button button2;
    }
}