namespace PRPJECT4NEW.Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Stud_ID = new System.Windows.Forms.TextBox();
            this.serial = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.TextBox();
            this.Students = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.My_Lectures = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Students)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Image = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.label1.Location = new System.Drawing.Point(135, 125);
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
            this.Stud_ID.Location = new System.Drawing.Point(47, 180);
            this.Stud_ID.Margin = new System.Windows.Forms.Padding(8);
            this.Stud_ID.Name = "Stud_ID";
            this.Stud_ID.Size = new System.Drawing.Size(331, 38);
            this.Stud_ID.TabIndex = 22;
            // 
            // serial
            // 
            this.serial.BackColor = System.Drawing.SystemColors.HotTrack;
            this.serial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serial.FormattingEnabled = true;
            this.serial.Items.AddRange(new object[] {
            "1003",
            "1004",
            "1005",
            "1006",
            "1007"});
            this.serial.Location = new System.Drawing.Point(47, 66);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(331, 39);
            this.serial.TabIndex = 26;
            this.serial.Text = "Course serial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Image = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.label3.Location = new System.Drawing.Point(146, 254);
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
            this.Course.Location = new System.Drawing.Point(47, 312);
            this.Course.Margin = new System.Windows.Forms.Padding(8);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(331, 38);
            this.Course.TabIndex = 27;
            // 
            // Students
            // 
            this.Students.AllowUserToAddRows = false;
            this.Students.AllowUserToDeleteRows = false;
            this.Students.AllowUserToResizeColumns = false;
            this.Students.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Students.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Students.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Students.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Students.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Students.Location = new System.Drawing.Point(0, 0);
            this.Students.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Students.MultiSelect = false;
            this.Students.Name = "Students";
            this.Students.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Students.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Students.RowHeadersVisible = false;
            this.Students.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Students.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Students.RowTemplate.Height = 24;
            this.Students.Size = new System.Drawing.Size(2031, 593);
            this.Students.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "Buttons_place";
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.Course);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Stud_ID);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.serial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.My_Lectures);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 593);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2031, 436);
            this.panel1.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(1832, 327);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 83);
            this.button4.TabIndex = 29;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 1407);
            this.button1.Margin = new System.Windows.Forms.Padding(13, 17, 13, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1549, 198);
            this.button1.TabIndex = 19;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(1091, 141);
            this.button3.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(624, 167);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sign student";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // My_Lectures
            // 
            this.My_Lectures.AccessibleName = "My_Lectures";
            this.My_Lectures.BackColor = System.Drawing.SystemColors.HotTrack;
            this.My_Lectures.FlatAppearance.BorderSize = 0;
            this.My_Lectures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.My_Lectures.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.My_Lectures.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.My_Lectures.Location = new System.Drawing.Point(475, 141);
            this.My_Lectures.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.My_Lectures.Name = "My_Lectures";
            this.My_Lectures.Size = new System.Drawing.Size(589, 167);
            this.My_Lectures.TabIndex = 9;
            this.My_Lectures.Text = "Show all the students";
            this.My_Lectures.UseVisualStyleBackColor = false;
            this.My_Lectures.Click += new System.EventHandler(this.My_Lectures_Click);
            // 
            // SignStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2031, 1029);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.panel1);
            this.Name = "SignStudent";
            this.Text = "SignStudent";
            ((System.ComponentModel.ISupportInitialize)(this.Students)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Stud_ID;
        private System.Windows.Forms.ComboBox serial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Course;
        private System.Windows.Forms.DataGridView Students;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button My_Lectures;
        private System.Windows.Forms.Button button4;
    }
}