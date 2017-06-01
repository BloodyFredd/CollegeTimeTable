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
            ((System.ComponentModel.ISupportInitialize)(this.scholarshipGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grantNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // scholarshipGridView
            // 
            this.scholarshipGridView.AllowUserToAddRows = false;
            this.scholarshipGridView.AllowUserToDeleteRows = false;
            this.scholarshipGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scholarshipGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scholarshipGridView.EnableHeadersVisualStyles = false;
            this.scholarshipGridView.Location = new System.Drawing.Point(28, 27);
            this.scholarshipGridView.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.scholarshipGridView.Name = "scholarshipGridView";
            this.scholarshipGridView.RowHeadersVisible = false;
            this.scholarshipGridView.Size = new System.Drawing.Size(1489, 473);
            this.scholarshipGridView.TabIndex = 0;
            this.scholarshipGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scholarshipGridView_CellContentClick);
            // 
            // delScholarshipBtn
            // 
            this.delScholarshipBtn.Location = new System.Drawing.Point(42, 513);
            this.delScholarshipBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.delScholarshipBtn.Name = "delScholarshipBtn";
            this.delScholarshipBtn.Size = new System.Drawing.Size(278, 51);
            this.delScholarshipBtn.TabIndex = 1;
            this.delScholarshipBtn.Text = "Remove Scholarship";
            this.delScholarshipBtn.UseVisualStyleBackColor = true;
            this.delScholarshipBtn.Click += new System.EventHandler(this.delScholarshipBtn_Click);
            // 
            // newScholarshipBtn
            // 
            this.newScholarshipBtn.Location = new System.Drawing.Point(1078, 656);
            this.newScholarshipBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.newScholarshipBtn.Name = "newScholarshipBtn";
            this.newScholarshipBtn.Size = new System.Drawing.Size(441, 51);
            this.newScholarshipBtn.TabIndex = 13;
            this.newScholarshipBtn.Text = "Add Scholarship";
            this.newScholarshipBtn.UseVisualStyleBackColor = true;
            this.newScholarshipBtn.Click += new System.EventHandler(this.newScholarshipBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 605);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scholarship Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 663);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grant Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 605);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Intended For:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 663);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Duration (Years):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1071, 605);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Volunteer Hours:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(273, 598);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(228, 35);
            this.nameTextBox.TabIndex = 8;
            // 
            // forTextBox
            // 
            this.forTextBox.Location = new System.Drawing.Point(784, 598);
            this.forTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.forTextBox.Name = "forTextBox";
            this.forTextBox.Size = new System.Drawing.Size(228, 35);
            this.forTextBox.TabIndex = 9;
            // 
            // grantNumeric
            // 
            this.grantNumeric.Location = new System.Drawing.Point(273, 656);
            this.grantNumeric.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grantNumeric.Name = "grantNumeric";
            this.grantNumeric.Size = new System.Drawing.Size(233, 35);
            this.grantNumeric.TabIndex = 11;
            // 
            // durationNumeric
            // 
            this.durationNumeric.Location = new System.Drawing.Point(784, 656);
            this.durationNumeric.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.durationNumeric.Name = "durationNumeric";
            this.durationNumeric.Size = new System.Drawing.Size(233, 35);
            this.durationNumeric.TabIndex = 12;
            // 
            // hoursNumeric
            // 
            this.hoursNumeric.Location = new System.Drawing.Point(1286, 598);
            this.hoursNumeric.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.hoursNumeric.Name = "hoursNumeric";
            this.hoursNumeric.Size = new System.Drawing.Size(231, 35);
            this.hoursNumeric.TabIndex = 10;
            // 
            // ScholarshipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 756);
            this.Controls.Add(this.hoursNumeric);
            this.Controls.Add(this.durationNumeric);
            this.Controls.Add(this.grantNumeric);
            this.Controls.Add(this.forTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newScholarshipBtn);
            this.Controls.Add(this.delScholarshipBtn);
            this.Controls.Add(this.scholarshipGridView);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "ScholarshipForm";
            this.Text = "ScholarshipForm";
            ((System.ComponentModel.ISupportInitialize)(this.scholarshipGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grantNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}