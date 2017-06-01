namespace PRPJECT4NEW.Tech_Team
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Student_Name = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.special_request_from_DF_Button = new System.Windows.Forms.Button();
            this.list_of_conferences_Button = new System.Windows.Forms.Button();
            this.Recorded_lectures_display_Button = new System.Windows.Forms.Button();
            this.classes_with_more_than_10_students_Button = new System.Windows.Forms.Button();
            this.Exams_report_button = new System.Windows.Forms.Button();
            this.Buttons_view = new System.Windows.Forms.Panel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "Header";
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Student_Name);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 46);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(506, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(0, 13, 34, 0);
            this.pictureBox2.Size = new System.Drawing.Size(29, 46);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(535, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 9, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 13, 34, 0);
            this.pictureBox1.Size = new System.Drawing.Size(56, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Student_Name
            // 
            this.Student_Name.AutoSize = true;
            this.Student_Name.Dock = System.Windows.Forms.DockStyle.Left;
            this.Student_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Name.ForeColor = System.Drawing.Color.White;
            this.Student_Name.Image = ((System.Drawing.Image)(resources.GetObject("Student_Name.Image")));
            this.Student_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Student_Name.Location = new System.Drawing.Point(306, 0);
            this.Student_Name.Margin = new System.Windows.Forms.Padding(1, 9, 4, 0);
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Padding = new System.Windows.Forms.Padding(11, 16, 0, 0);
            this.Student_Name.Size = new System.Drawing.Size(183, 37);
            this.Student_Name.TabIndex = 2;
            this.Student_Name.Text = "     Tech Team person";
            this.Student_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Student_Name.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 46);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 7);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AccessibleName = "Buttons_place";
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.panel2.Controls.Add(this.Logout_Button);
            this.panel2.Controls.Add(this.special_request_from_DF_Button);
            this.panel2.Controls.Add(this.list_of_conferences_Button);
            this.panel2.Controls.Add(this.Recorded_lectures_display_Button);
            this.panel2.Controls.Add(this.classes_with_more_than_10_students_Button);
            this.panel2.Controls.Add(this.Exams_report_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.panel2.Size = new System.Drawing.Size(307, 304);
            this.panel2.TabIndex = 1;
            // 
            // Logout_Button
            // 
            this.Logout_Button.AccessibleName = "Logout_Button";
            this.Logout_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Logout_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logout_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logout_Button.FlatAppearance.BorderSize = 0;
            this.Logout_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Logout_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_Button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_Button.ForeColor = System.Drawing.Color.White;
            this.Logout_Button.Image = ((System.Drawing.Image)(resources.GetObject("Logout_Button.Image")));
            this.Logout_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_Button.Location = new System.Drawing.Point(0, 221);
            this.Logout_Button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Logout_Button.Size = new System.Drawing.Size(307, 41);
            this.Logout_Button.TabIndex = 10;
            this.Logout_Button.Text = " Logout";
            this.Logout_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logout_Button.UseVisualStyleBackColor = false;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Click);
            // 
            // special_request_from_DF_Button
            // 
            this.special_request_from_DF_Button.AccessibleName = "special_request_from_DF_Button";
            this.special_request_from_DF_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.special_request_from_DF_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.special_request_from_DF_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.special_request_from_DF_Button.FlatAppearance.BorderSize = 0;
            this.special_request_from_DF_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.special_request_from_DF_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.special_request_from_DF_Button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.special_request_from_DF_Button.ForeColor = System.Drawing.Color.Transparent;
            this.special_request_from_DF_Button.Image = ((System.Drawing.Image)(resources.GetObject("special_request_from_DF_Button.Image")));
            this.special_request_from_DF_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.special_request_from_DF_Button.Location = new System.Drawing.Point(0, 180);
            this.special_request_from_DF_Button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.special_request_from_DF_Button.Name = "special_request_from_DF_Button";
            this.special_request_from_DF_Button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.special_request_from_DF_Button.Size = new System.Drawing.Size(307, 41);
            this.special_request_from_DF_Button.TabIndex = 5;
            this.special_request_from_DF_Button.Text = " Special requests from DOF";
            this.special_request_from_DF_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.special_request_from_DF_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.special_request_from_DF_Button.UseVisualStyleBackColor = false;
            this.special_request_from_DF_Button.Click += new System.EventHandler(this.special_request_from_DF_Button_Click);
            // 
            // list_of_conferences_Button
            // 
            this.list_of_conferences_Button.AccessibleName = "list_of_conferences_Button";
            this.list_of_conferences_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.list_of_conferences_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.list_of_conferences_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.list_of_conferences_Button.FlatAppearance.BorderSize = 0;
            this.list_of_conferences_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.list_of_conferences_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_of_conferences_Button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_of_conferences_Button.ForeColor = System.Drawing.Color.White;
            this.list_of_conferences_Button.Image = ((System.Drawing.Image)(resources.GetObject("list_of_conferences_Button.Image")));
            this.list_of_conferences_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.list_of_conferences_Button.Location = new System.Drawing.Point(0, 139);
            this.list_of_conferences_Button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.list_of_conferences_Button.Name = "list_of_conferences_Button";
            this.list_of_conferences_Button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.list_of_conferences_Button.Size = new System.Drawing.Size(307, 41);
            this.list_of_conferences_Button.TabIndex = 4;
            this.list_of_conferences_Button.Text = " List of conferences";
            this.list_of_conferences_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.list_of_conferences_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.list_of_conferences_Button.UseVisualStyleBackColor = false;
            this.list_of_conferences_Button.Click += new System.EventHandler(this.list_of_conferences_Button_Click);
            // 
            // Recorded_lectures_display_Button
            // 
            this.Recorded_lectures_display_Button.AccessibleName = "Recorded_lectures_display_Button";
            this.Recorded_lectures_display_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Recorded_lectures_display_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Recorded_lectures_display_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Recorded_lectures_display_Button.FlatAppearance.BorderSize = 0;
            this.Recorded_lectures_display_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Recorded_lectures_display_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recorded_lectures_display_Button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recorded_lectures_display_Button.ForeColor = System.Drawing.Color.White;
            this.Recorded_lectures_display_Button.Image = ((System.Drawing.Image)(resources.GetObject("Recorded_lectures_display_Button.Image")));
            this.Recorded_lectures_display_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Recorded_lectures_display_Button.Location = new System.Drawing.Point(0, 98);
            this.Recorded_lectures_display_Button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Recorded_lectures_display_Button.Name = "Recorded_lectures_display_Button";
            this.Recorded_lectures_display_Button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Recorded_lectures_display_Button.Size = new System.Drawing.Size(307, 41);
            this.Recorded_lectures_display_Button.TabIndex = 3;
            this.Recorded_lectures_display_Button.Text = " Recorded lectures display";
            this.Recorded_lectures_display_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Recorded_lectures_display_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Recorded_lectures_display_Button.UseVisualStyleBackColor = false;
            this.Recorded_lectures_display_Button.Click += new System.EventHandler(this.Recorded_lectures_display_Button_Click);
            // 
            // classes_with_more_than_10_students_Button
            // 
            this.classes_with_more_than_10_students_Button.AccessibleName = "classes_with_more_than_10_students_Button";
            this.classes_with_more_than_10_students_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.classes_with_more_than_10_students_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.classes_with_more_than_10_students_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.classes_with_more_than_10_students_Button.FlatAppearance.BorderSize = 0;
            this.classes_with_more_than_10_students_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.classes_with_more_than_10_students_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classes_with_more_than_10_students_Button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classes_with_more_than_10_students_Button.ForeColor = System.Drawing.Color.White;
            this.classes_with_more_than_10_students_Button.Image = ((System.Drawing.Image)(resources.GetObject("classes_with_more_than_10_students_Button.Image")));
            this.classes_with_more_than_10_students_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classes_with_more_than_10_students_Button.Location = new System.Drawing.Point(0, 48);
            this.classes_with_more_than_10_students_Button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.classes_with_more_than_10_students_Button.Name = "classes_with_more_than_10_students_Button";
            this.classes_with_more_than_10_students_Button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.classes_with_more_than_10_students_Button.Size = new System.Drawing.Size(307, 50);
            this.classes_with_more_than_10_students_Button.TabIndex = 2;
            this.classes_with_more_than_10_students_Button.Text = " Classes by capacity";
            this.classes_with_more_than_10_students_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classes_with_more_than_10_students_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.classes_with_more_than_10_students_Button.UseVisualStyleBackColor = false;
            this.classes_with_more_than_10_students_Button.Click += new System.EventHandler(this.classes_with_more_than_10_students_Button_Click);
            // 
            // Exams_report_button
            // 
            this.Exams_report_button.AccessibleName = "Available_Classes_button";
            this.Exams_report_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Exams_report_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exams_report_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exams_report_button.FlatAppearance.BorderSize = 0;
            this.Exams_report_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.Exams_report_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exams_report_button.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exams_report_button.ForeColor = System.Drawing.Color.White;
            this.Exams_report_button.Image = ((System.Drawing.Image)(resources.GetObject("Exams_report_button.Image")));
            this.Exams_report_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exams_report_button.Location = new System.Drawing.Point(0, 7);
            this.Exams_report_button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Exams_report_button.Name = "Exams_report_button";
            this.Exams_report_button.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.Exams_report_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Exams_report_button.Size = new System.Drawing.Size(307, 41);
            this.Exams_report_button.TabIndex = 0;
            this.Exams_report_button.Text = " Available Classes";
            this.Exams_report_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exams_report_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exams_report_button.UseVisualStyleBackColor = false;
            this.Exams_report_button.Click += new System.EventHandler(this.Available_Classes_button_Click);
            // 
            // Buttons_view
            // 
            this.Buttons_view.AccessibleName = "Buttons_view";
            this.Buttons_view.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Buttons_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Buttons_view.Location = new System.Drawing.Point(307, 46);
            this.Buttons_view.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Buttons_view.Name = "Buttons_view";
            this.Buttons_view.Size = new System.Drawing.Size(284, 304);
            this.Buttons_view.TabIndex = 2;
            this.Buttons_view.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(591, 350);
            this.Controls.Add(this.Buttons_view);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Logout_Button;
        private System.Windows.Forms.Button special_request_from_DF_Button;
        private System.Windows.Forms.Button list_of_conferences_Button;
        private System.Windows.Forms.Button Recorded_lectures_display_Button;
        private System.Windows.Forms.Button classes_with_more_than_10_students_Button;
        private System.Windows.Forms.Button Exams_report_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Buttons_view;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label Student_Name;
    }
}