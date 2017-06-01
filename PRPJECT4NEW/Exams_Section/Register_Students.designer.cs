namespace PRPJECT4NEW.Exams_Section
{
    partial class Register_Students
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Exams_Grid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newScholarshipBtn = new System.Windows.Forms.Button();
            this.Combo_Stud_Type = new System.Windows.Forms.ComboBox();
            this.classesSM1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Combo_Course_name = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Students_List = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Exams_Grid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesSM1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Students_List)).BeginInit();
            this.SuspendLayout();
            // 
            // Exams_Grid
            // 
            this.Exams_Grid.AllowUserToAddRows = false;
            this.Exams_Grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Exams_Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Exams_Grid.BackgroundColor = System.Drawing.Color.White;
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
            this.Exams_Grid.Size = new System.Drawing.Size(1888, 592);
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
            this.panel2.Controls.Add(this.newScholarshipBtn);
            this.panel2.Controls.Add(this.Combo_Stud_Type);
            this.panel2.Controls.Add(this.Combo_Course_name);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
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
            this.newScholarshipBtn.Text = "Register Students";
            this.newScholarshipBtn.UseVisualStyleBackColor = false;
            this.newScholarshipBtn.Click += new System.EventHandler(this.newScholarshipBtn_Click);
            // 
            // Combo_Stud_Type
            // 
            this.Combo_Stud_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Combo_Stud_Type.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.classesSM1BindingSource, "Class_Id", true));
            this.Combo_Stud_Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Combo_Stud_Type.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Stud_Type.ForeColor = System.Drawing.Color.White;
            this.Combo_Stud_Type.FormattingEnabled = true;
            this.Combo_Stud_Type.Items.AddRange(new object[] {
            "All Students",
            "Have easement",
            "Without easement"});
            this.Combo_Stud_Type.Location = new System.Drawing.Point(2195, 160);
            this.Combo_Stud_Type.Margin = new System.Windows.Forms.Padding(5);
            this.Combo_Stud_Type.Name = "Combo_Stud_Type";
            this.Combo_Stud_Type.Size = new System.Drawing.Size(338, 48);
            this.Combo_Stud_Type.TabIndex = 32;
            this.Combo_Stud_Type.SelectedIndexChanged += new System.EventHandler(this.Combo_Class_ID_SelectedIndexChanged);
            // 
            // classesSM1BindingSource
            // 
            this.classesSM1BindingSource.DataSource = typeof(PRPJECT4NEW.Classes_SM1);
            // 
            // Combo_Course_name
            // 
            this.Combo_Course_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Combo_Course_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Combo_Course_name.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Course_name.ForeColor = System.Drawing.Color.White;
            this.Combo_Course_name.FormattingEnabled = true;
            this.Combo_Course_name.Location = new System.Drawing.Point(948, 157);
            this.Combo_Course_name.Margin = new System.Windows.Forms.Padding(5);
            this.Combo_Course_name.Name = "Combo_Course_name";
            this.Combo_Course_name.Size = new System.Drawing.Size(523, 48);
            this.Combo_Course_name.TabIndex = 31;
            this.Combo_Course_name.SelectedIndexChanged += new System.EventHandler(this.Combo_Course_name_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1707, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 40);
            this.label5.TabIndex = 18;
            this.label5.Text = "Student easement type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(713, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 40);
            this.label3.TabIndex = 16;
            this.label3.Text = "Course:";
            // 
            // Students_List
            // 
            this.Students_List.AllowUserToAddRows = false;
            this.Students_List.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Students_List.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Students_List.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Students_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Students_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Students_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Students_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Students_List.DefaultCellStyle = dataGridViewCellStyle7;
            this.Students_List.Dock = System.Windows.Forms.DockStyle.Right;
            this.Students_List.GridColor = System.Drawing.Color.White;
            this.Students_List.Location = new System.Drawing.Point(1888, 100);
            this.Students_List.Name = "Students_List";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Students_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Students_List.RowHeadersVisible = false;
            this.Students_List.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Students_List.RowTemplate.Height = 37;
            this.Students_List.Size = new System.Drawing.Size(1163, 592);
            this.Students_List.TabIndex = 6;
            this.Students_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Register_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3051, 1164);
            this.Controls.Add(this.Exams_Grid);
            this.Controls.Add(this.Students_List);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Register_Students";
            this.Text = "Exams_Assignment";
            ((System.ComponentModel.ISupportInitialize)(this.Exams_Grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesSM1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Students_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Exams_Grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Combo_Stud_Type;
        private System.Windows.Forms.ComboBox Combo_Course_name;
        private System.Windows.Forms.Button newScholarshipBtn;
        private System.Windows.Forms.BindingSource classesSM1BindingSource;
        private System.Windows.Forms.DataGridView Students_List;
    }
}