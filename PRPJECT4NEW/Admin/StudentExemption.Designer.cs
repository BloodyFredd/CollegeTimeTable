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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Stud_ID = new System.Windows.Forms.TextBox();
            this.Course = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Students = new System.Windows.Forms.DataGridView();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.My_Lectures = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Stud_ID
            // 
            this.Stud_ID.BackColor = System.Drawing.Color.White;
            this.Stud_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stud_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stud_ID.ForeColor = System.Drawing.Color.Black;
            this.Stud_ID.Location = new System.Drawing.Point(127, 173);
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
            this.Course.Location = new System.Drawing.Point(127, 298);
            this.Course.Margin = new System.Windows.Forms.Padding(8);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(488, 38);
            this.Course.TabIndex = 18;
            this.Course.TextChanged += new System.EventHandler(this.Course_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(287, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Student ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(306, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Course:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Students
            // 
            this.Students.AllowUserToAddRows = false;
            this.Students.AllowUserToDeleteRows = false;
            this.Students.AllowUserToResizeColumns = false;
            this.Students.AllowUserToResizeRows = false;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Students.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle49;
            this.Students.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Students.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Students.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle50;
            this.Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Students.Location = new System.Drawing.Point(0, 0);
            this.Students.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Students.MultiSelect = false;
            this.Students.Name = "Students";
            this.Students.ReadOnly = true;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Students.RowHeadersDefaultCellStyle = dataGridViewCellStyle51;
            this.Students.RowHeadersVisible = false;
            this.Students.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Students.RowsDefaultCellStyle = dataGridViewCellStyle52;
            this.Students.RowTemplate.Height = 24;
            this.Students.Size = new System.Drawing.Size(2276, 1028);
            this.Students.TabIndex = 30;
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Delete_Button.FlatAppearance.BorderSize = 0;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.Delete_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_Button.Location = new System.Drawing.Point(723, 169);
            this.Delete_Button.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(592, 167);
            this.Delete_Button.TabIndex = 2;
            this.Delete_Button.Text = "Exemption";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 8.2F);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(2081, 324);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 83);
            this.button4.TabIndex = 22;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle53;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle54;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle55.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle55;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle56;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(2276, 1028);
            this.dataGridView1.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "Buttons_place";
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.panel1.Controls.Add(this.My_Lectures);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Delete_Button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.Course);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Stud_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 592);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2276, 436);
            this.panel1.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 1407);
            this.button2.Margin = new System.Windows.Forms.Padding(13, 17, 13, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1549, 198);
            this.button2.TabIndex = 19;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // My_Lectures
            // 
            this.My_Lectures.AccessibleName = "My_Lectures";
            this.My_Lectures.BackColor = System.Drawing.SystemColors.HotTrack;
            this.My_Lectures.FlatAppearance.BorderSize = 0;
            this.My_Lectures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.My_Lectures.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.My_Lectures.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.My_Lectures.Location = new System.Drawing.Point(1344, 169);
            this.My_Lectures.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.My_Lectures.Name = "My_Lectures";
            this.My_Lectures.Size = new System.Drawing.Size(589, 167);
            this.My_Lectures.TabIndex = 24;
            this.My_Lectures.Text = "Show all the students";
            this.My_Lectures.UseVisualStyleBackColor = false;
            this.My_Lectures.Click += new System.EventHandler(this.My_Lectures_Click);
            // 
            // StudentExemption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2276, 1028);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentExemption";
            this.Text = "StudentExemption";
            ((System.ComponentModel.ISupportInitialize)(this.Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Stud_ID;
        private System.Windows.Forms.TextBox Course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Students;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button My_Lectures;
    }
}