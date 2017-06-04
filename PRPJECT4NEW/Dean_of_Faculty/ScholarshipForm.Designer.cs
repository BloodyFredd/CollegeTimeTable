namespace PRPJECT4NEW.Dean_of_Faculty
{
    partial class ScholarshipForm
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
            this.scholarshipGridView = new System.Windows.Forms.DataGridView();
            this.delScholarshipBtn = new System.Windows.Forms.Button();
            this.newScholarshipBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.forTextBox = new System.Windows.Forms.TextBox();
            this.grantNumeric = new System.Windows.Forms.NumericUpDown();
            this.durationNumeric = new System.Windows.Forms.NumericUpDown();
            this.hoursNumeric = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.scholarshipGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grantNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumeric)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // scholarshipGridView
            // 
            this.scholarshipGridView.AllowUserToAddRows = false;
            this.scholarshipGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.scholarshipGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.scholarshipGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scholarshipGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scholarshipGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.scholarshipGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scholarshipGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.scholarshipGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scholarshipGridView.EnableHeadersVisualStyles = false;
            this.scholarshipGridView.Location = new System.Drawing.Point(0, 181);
            this.scholarshipGridView.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.scholarshipGridView.Name = "scholarshipGridView";
            this.scholarshipGridView.RowHeadersVisible = false;
            this.scholarshipGridView.Size = new System.Drawing.Size(1867, 477);
            this.scholarshipGridView.TabIndex = 0;
            this.scholarshipGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scholarshipGridView_CellContentClick);
            // 
            // delScholarshipBtn
            // 
            this.delScholarshipBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.delScholarshipBtn.FlatAppearance.BorderSize = 0;
            this.delScholarshipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delScholarshipBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delScholarshipBtn.ForeColor = System.Drawing.Color.White;
            this.delScholarshipBtn.Location = new System.Drawing.Point(1573, 230);
            this.delScholarshipBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.delScholarshipBtn.Name = "delScholarshipBtn";
            this.delScholarshipBtn.Size = new System.Drawing.Size(278, 103);
            this.delScholarshipBtn.TabIndex = 1;
            this.delScholarshipBtn.Text = "Remove Scholarship";
            this.delScholarshipBtn.UseVisualStyleBackColor = false;
            this.delScholarshipBtn.Click += new System.EventHandler(this.delScholarshipBtn_Click);
            // 
            // newScholarshipBtn
            // 
            this.newScholarshipBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.newScholarshipBtn.FlatAppearance.BorderSize = 0;
            this.newScholarshipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newScholarshipBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newScholarshipBtn.ForeColor = System.Drawing.Color.White;
            this.newScholarshipBtn.Location = new System.Drawing.Point(1251, 230);
            this.newScholarshipBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.newScholarshipBtn.Name = "newScholarshipBtn";
            this.newScholarshipBtn.Size = new System.Drawing.Size(308, 103);
            this.newScholarshipBtn.TabIndex = 13;
            this.newScholarshipBtn.Text = "Add Scholarship";
            this.newScholarshipBtn.UseVisualStyleBackColor = false;
            this.newScholarshipBtn.Click += new System.EventHandler(this.newScholarshipBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scholarship Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grant Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Intended For:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Duration (Years):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(635, 293);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Volunteer Hours:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(966, 167);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(228, 45);
            this.nameTextBox.TabIndex = 8;
            // 
            // forTextBox
            // 
            this.forTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forTextBox.Location = new System.Drawing.Point(359, 56);
            this.forTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.forTextBox.Name = "forTextBox";
            this.forTextBox.Size = new System.Drawing.Size(228, 45);
            this.forTextBox.TabIndex = 9;
            // 
            // grantNumeric
            // 
            this.grantNumeric.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantNumeric.Location = new System.Drawing.Point(359, 165);
            this.grantNumeric.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grantNumeric.Name = "grantNumeric";
            this.grantNumeric.Size = new System.Drawing.Size(233, 45);
            this.grantNumeric.TabIndex = 11;
            // 
            // durationNumeric
            // 
            this.durationNumeric.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationNumeric.Location = new System.Drawing.Point(359, 288);
            this.durationNumeric.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.durationNumeric.Name = "durationNumeric";
            this.durationNumeric.Size = new System.Drawing.Size(233, 45);
            this.durationNumeric.TabIndex = 12;
            // 
            // hoursNumeric
            // 
            this.hoursNumeric.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursNumeric.Location = new System.Drawing.Point(966, 280);
            this.hoursNumeric.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.hoursNumeric.Name = "hoursNumeric";
            this.hoursNumeric.Size = new System.Drawing.Size(231, 45);
            this.hoursNumeric.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1867, 181);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.panel2.Controls.Add(this.delScholarshipBtn);
            this.panel2.Controls.Add(this.newScholarshipBtn);
            this.panel2.Controls.Add(this.hoursNumeric);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.durationNumeric);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.grantNumeric);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.forTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 658);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1867, 466);
            this.panel2.TabIndex = 15;
            // 
            // ScholarshipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1124);
            this.Controls.Add(this.scholarshipGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "ScholarshipForm";
            this.Text = "ScholarshipForm";
            ((System.ComponentModel.ISupportInitialize)(this.scholarshipGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grantNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumeric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView scholarshipGridView;
        private System.Windows.Forms.Button delScholarshipBtn;
        private System.Windows.Forms.Button newScholarshipBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox forTextBox;
        private System.Windows.Forms.NumericUpDown grantNumeric;
        private System.Windows.Forms.NumericUpDown durationNumeric;
        private System.Windows.Forms.NumericUpDown hoursNumeric;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}