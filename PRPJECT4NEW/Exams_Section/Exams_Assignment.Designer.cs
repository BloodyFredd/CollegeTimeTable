namespace PRPJECT4NEW.Exams_Section
{
    partial class Exams_Assignment
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Exams_Grid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newScholarshipBtn = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.Combo_Class_ID = new System.Windows.Forms.ComboBox();
            this.Combo_Course_name = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.End_Time_Box = new System.Windows.Forms.NumericUpDown();
            this.Start_Time_Box = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Super1_box = new System.Windows.Forms.ComboBox();
            this.Super2_box = new System.Windows.Forms.ComboBox();
            this.classesSM1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Exams_Grid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.End_Time_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_Time_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesSM1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Exams_Grid
            // 
            this.Exams_Grid.AllowUserToAddRows = false;
            this.Exams_Grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Exams_Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Exams_Grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Exams_Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Exams_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Exams_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Exams_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Exams_Grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Exams_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exams_Grid.Location = new System.Drawing.Point(0, 100);
            this.Exams_Grid.Name = "Exams_Grid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Exams_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Exams_Grid.RowHeadersVisible = false;
            this.Exams_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Exams_Grid.RowTemplate.Height = 37;
            this.Exams_Grid.Size = new System.Drawing.Size(3051, 592);
            this.Exams_Grid.TabIndex = 3;
            this.Exams_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Exams_Grid_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3051, 100);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.panel2.Controls.Add(this.Super2_box);
            this.panel2.Controls.Add(this.Super1_box);
            this.panel2.Controls.Add(this.newScholarshipBtn);
            this.panel2.Controls.Add(this.datePicker);
            this.panel2.Controls.Add(this.Combo_Class_ID);
            this.panel2.Controls.Add(this.Combo_Course_name);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.End_Time_Box);
            this.panel2.Controls.Add(this.Start_Time_Box);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 692);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3051, 472);
            this.panel2.TabIndex = 5;
            // 
            // newScholarshipBtn
            // 
            this.newScholarshipBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newScholarshipBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.newScholarshipBtn.FlatAppearance.BorderSize = 0;
            this.newScholarshipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newScholarshipBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newScholarshipBtn.ForeColor = System.Drawing.Color.White;
            this.newScholarshipBtn.Location = new System.Drawing.Point(656, 324);
            this.newScholarshipBtn.Margin = new System.Windows.Forms.Padding(7);
            this.newScholarshipBtn.Name = "newScholarshipBtn";
            this.newScholarshipBtn.Size = new System.Drawing.Size(1689, 66);
            this.newScholarshipBtn.TabIndex = 24;
            this.newScholarshipBtn.Text = "Add Exam";
            this.newScholarshipBtn.UseVisualStyleBackColor = false;
            this.newScholarshipBtn.Click += new System.EventHandler(this.newScholarshipBtn_Click);
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.CalendarForeColor = System.Drawing.Color.White;
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.datePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.datePicker.CalendarTitleForeColor = System.Drawing.Color.White;
            this.datePicker.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.datePicker.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(1960, 159);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(338, 44);
            this.datePicker.TabIndex = 34;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // Combo_Class_ID
            // 
            this.Combo_Class_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Combo_Class_ID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.classesSM1BindingSource, "Class_Id", true));
            this.Combo_Class_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Combo_Class_ID.ForeColor = System.Drawing.Color.White;
            this.Combo_Class_ID.FormattingEnabled = true;
            this.Combo_Class_ID.Location = new System.Drawing.Point(1960, 71);
            this.Combo_Class_ID.Margin = new System.Windows.Forms.Padding(5);
            this.Combo_Class_ID.Name = "Combo_Class_ID";
            this.Combo_Class_ID.Size = new System.Drawing.Size(338, 37);
            this.Combo_Class_ID.TabIndex = 32;
            this.Combo_Class_ID.SelectedIndexChanged += new System.EventHandler(this.Combo_Class_ID_SelectedIndexChanged);
            // 
            // Combo_Course_name
            // 
            this.Combo_Course_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Combo_Course_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Combo_Course_name.ForeColor = System.Drawing.Color.White;
            this.Combo_Course_name.FormattingEnabled = true;
            this.Combo_Course_name.Location = new System.Drawing.Point(1170, 68);
            this.Combo_Course_name.Margin = new System.Windows.Forms.Padding(5);
            this.Combo_Course_name.Name = "Combo_Course_name";
            this.Combo_Course_name.Size = new System.Drawing.Size(523, 37);
            this.Combo_Course_name.TabIndex = 31;
            this.Combo_Course_name.SelectedIndexChanged += new System.EventHandler(this.Combo_Course_name_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(933, 247);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 37);
            this.label7.TabIndex = 27;
            this.label7.Text = "First Supervisor:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1631, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 37);
            this.label8.TabIndex = 28;
            this.label8.Text = "Second Supervisor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1826, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 37);
            this.label6.TabIndex = 25;
            this.label6.Text = "Date:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1812, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 37);
            this.label5.TabIndex = 18;
            this.label5.Text = "Class:";
            // 
            // End_Time_Box
            // 
            this.End_Time_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.End_Time_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.End_Time_Box.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_Time_Box.ForeColor = System.Drawing.Color.White;
            this.End_Time_Box.Location = new System.Drawing.Point(1598, 157);
            this.End_Time_Box.Margin = new System.Windows.Forms.Padding(7);
            this.End_Time_Box.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.End_Time_Box.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.End_Time_Box.Name = "End_Time_Box";
            this.End_Time_Box.Size = new System.Drawing.Size(177, 40);
            this.End_Time_Box.TabIndex = 23;
            this.End_Time_Box.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // Start_Time_Box
            // 
            this.Start_Time_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Start_Time_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Start_Time_Box.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Time_Box.ForeColor = System.Drawing.Color.White;
            this.Start_Time_Box.Location = new System.Drawing.Point(1167, 159);
            this.Start_Time_Box.Margin = new System.Windows.Forms.Padding(7);
            this.Start_Time_Box.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Start_Time_Box.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Start_Time_Box.Name = "Start_Time_Box";
            this.Start_Time_Box.Size = new System.Drawing.Size(193, 40);
            this.Start_Time_Box.TabIndex = 22;
            this.Start_Time_Box.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(931, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Start Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(933, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "Course:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1394, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 37);
            this.label4.TabIndex = 17;
            this.label4.Text = "End Time:";
            // 
            // Super1_box
            // 
            this.Super1_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Super1_box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Super1_box.ForeColor = System.Drawing.Color.White;
            this.Super1_box.FormattingEnabled = true;
            this.Super1_box.Location = new System.Drawing.Point(1198, 248);
            this.Super1_box.Margin = new System.Windows.Forms.Padding(5);
            this.Super1_box.Name = "Super1_box";
            this.Super1_box.Size = new System.Drawing.Size(364, 37);
            this.Super1_box.TabIndex = 35;
            // 
            // Super2_box
            // 
            this.Super2_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Super2_box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Super2_box.ForeColor = System.Drawing.Color.White;
            this.Super2_box.FormattingEnabled = true;
            this.Super2_box.Location = new System.Drawing.Point(1960, 248);
            this.Super2_box.Margin = new System.Windows.Forms.Padding(5);
            this.Super2_box.Name = "Super2_box";
            this.Super2_box.Size = new System.Drawing.Size(364, 37);
            this.Super2_box.TabIndex = 36;
            this.Super2_box.SelectedIndexChanged += new System.EventHandler(this.Super2_box_SelectedIndexChanged);
            // 
            // classesSM1BindingSource
            // 
            this.classesSM1BindingSource.DataSource = typeof(PRPJECT4NEW.Classes_SM1);
            // 
            // Exams_Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3051, 1164);
            this.Controls.Add(this.Exams_Grid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Exams_Assignment";
            this.Text = "Exams_Assignment";
            ((System.ComponentModel.ISupportInitialize)(this.Exams_Grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.End_Time_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_Time_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesSM1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Exams_Grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown End_Time_Box;
        private System.Windows.Forms.NumericUpDown Start_Time_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Combo_Class_ID;
        private System.Windows.Forms.ComboBox Combo_Course_name;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button newScholarshipBtn;
        private System.Windows.Forms.BindingSource classesSM1BindingSource;
        private System.Windows.Forms.ComboBox Super2_box;
        private System.Windows.Forms.ComboBox Super1_box;
    }
}