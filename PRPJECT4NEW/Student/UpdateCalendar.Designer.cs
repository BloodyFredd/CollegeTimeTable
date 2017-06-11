namespace PRPJECT4NEW.Student
{
    partial class UpdateCalendar
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
            this.calendarGridView = new System.Windows.Forms.DataGridView();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lecturesListBox = new System.Windows.Forms.ListBox();
            this.practicesListBox = new System.Windows.Forms.ListBox();
            this.labsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SignBtn = new System.Windows.Forms.Button();
            this.UnsignBtn = new System.Windows.Forms.Button();
            this.courseGridView = new System.Windows.Forms.DataGridView();
            this.lectureGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarGridView
            // 
            this.calendarGridView.AllowUserToAddRows = false;
            this.calendarGridView.AllowUserToDeleteRows = false;
            this.calendarGridView.AllowUserToResizeColumns = false;
            this.calendarGridView.AllowUserToResizeRows = false;
            this.calendarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarGridView.EnableHeadersVisualStyles = false;
            this.calendarGridView.Location = new System.Drawing.Point(12, 12);
            this.calendarGridView.Name = "calendarGridView";
            this.calendarGridView.ReadOnly = true;
            this.calendarGridView.RowHeadersVisible = false;
            this.calendarGridView.Size = new System.Drawing.Size(706, 426);
            this.calendarGridView.TabIndex = 0;
            // 
            // courseComboBox
            // 
            this.courseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(817, 12);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(158, 21);
            this.courseComboBox.TabIndex = 1;
            this.courseComboBox.SelectedIndexChanged += new System.EventHandler(this.courseComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(729, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Open Courses:";
            // 
            // lecturesListBox
            // 
            this.lecturesListBox.FormattingEnabled = true;
            this.lecturesListBox.Location = new System.Drawing.Point(731, 70);
            this.lecturesListBox.Name = "lecturesListBox";
            this.lecturesListBox.Size = new System.Drawing.Size(130, 95);
            this.lecturesListBox.TabIndex = 3;
            this.lecturesListBox.SelectedIndexChanged += new System.EventHandler(this.lecturesListBox_SelectedIndexChanged);
            // 
            // practicesListBox
            // 
            this.practicesListBox.FormattingEnabled = true;
            this.practicesListBox.Location = new System.Drawing.Point(867, 70);
            this.practicesListBox.Name = "practicesListBox";
            this.practicesListBox.Size = new System.Drawing.Size(146, 95);
            this.practicesListBox.TabIndex = 4;
            this.practicesListBox.SelectedIndexChanged += new System.EventHandler(this.practicesListBox_SelectedIndexChanged);
            // 
            // labsListBox
            // 
            this.labsListBox.FormattingEnabled = true;
            this.labsListBox.Location = new System.Drawing.Point(1019, 70);
            this.labsListBox.Name = "labsListBox";
            this.labsListBox.Size = new System.Drawing.Size(130, 95);
            this.labsListBox.TabIndex = 5;
            this.labsListBox.SelectedIndexChanged += new System.EventHandler(this.labsListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(728, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lectures:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(864, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Practices:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1016, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lab:";
            // 
            // SignBtn
            // 
            this.SignBtn.Enabled = false;
            this.SignBtn.Location = new System.Drawing.Point(731, 171);
            this.SignBtn.Name = "SignBtn";
            this.SignBtn.Size = new System.Drawing.Size(75, 23);
            this.SignBtn.TabIndex = 9;
            this.SignBtn.Text = "Sign";
            this.SignBtn.UseVisualStyleBackColor = true;
            this.SignBtn.Click += new System.EventHandler(this.SignBtn_Click);
            // 
            // UnsignBtn
            // 
            this.UnsignBtn.Enabled = false;
            this.UnsignBtn.Location = new System.Drawing.Point(1006, 10);
            this.UnsignBtn.Name = "UnsignBtn";
            this.UnsignBtn.Size = new System.Drawing.Size(75, 23);
            this.UnsignBtn.TabIndex = 10;
            this.UnsignBtn.Text = "Unsign";
            this.UnsignBtn.UseVisualStyleBackColor = true;
            this.UnsignBtn.Click += new System.EventHandler(this.UnsignBtn_Click);
            // 
            // courseGridView
            // 
            this.courseGridView.AllowUserToAddRows = false;
            this.courseGridView.AllowUserToDeleteRows = false;
            this.courseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGridView.EnableHeadersVisualStyles = false;
            this.courseGridView.Location = new System.Drawing.Point(943, 243);
            this.courseGridView.MultiSelect = false;
            this.courseGridView.Name = "courseGridView";
            this.courseGridView.ReadOnly = true;
            this.courseGridView.RowHeadersVisible = false;
            this.courseGridView.Size = new System.Drawing.Size(206, 126);
            this.courseGridView.TabIndex = 11;
            // 
            // lectureGridView
            // 
            this.lectureGridView.AllowUserToAddRows = false;
            this.lectureGridView.AllowUserToDeleteRows = false;
            this.lectureGridView.AllowUserToResizeColumns = false;
            this.lectureGridView.AllowUserToResizeRows = false;
            this.lectureGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectureGridView.EnableHeadersVisualStyles = false;
            this.lectureGridView.Location = new System.Drawing.Point(731, 243);
            this.lectureGridView.Name = "lectureGridView";
            this.lectureGridView.ReadOnly = true;
            this.lectureGridView.RowHeadersVisible = false;
            this.lectureGridView.Size = new System.Drawing.Size(206, 126);
            this.lectureGridView.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(943, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Course Info:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(729, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lecture Info:";
            // 
            // UpdateCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 502);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lectureGridView);
            this.Controls.Add(this.courseGridView);
            this.Controls.Add(this.UnsignBtn);
            this.Controls.Add(this.SignBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labsListBox);
            this.Controls.Add(this.practicesListBox);
            this.Controls.Add(this.lecturesListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.calendarGridView);
            this.Name = "UpdateCalendar";
            this.Text = "UpdateCalendar";
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView calendarGridView;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lecturesListBox;
        private System.Windows.Forms.ListBox practicesListBox;
        private System.Windows.Forms.ListBox labsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SignBtn;
        private System.Windows.Forms.Button UnsignBtn;
        private System.Windows.Forms.DataGridView courseGridView;
        private System.Windows.Forms.DataGridView lectureGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}