namespace BranchA_MazalPlus.Teaching_Assistant
{
    partial class Reports
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
            this.Load_table = new System.Windows.Forms.Button();
            this.StudentsReport = new System.Windows.Forms.DataGridView();
            this.Grades_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_table
            // 
            this.Load_table.Location = new System.Drawing.Point(15, 14);
            this.Load_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Load_table.Name = "Load_table";
            this.Load_table.Size = new System.Drawing.Size(104, 48);
            this.Load_table.TabIndex = 3;
            this.Load_table.Text = "Colleagues";
            this.Load_table.UseVisualStyleBackColor = true;
            this.Load_table.Click += new System.EventHandler(this.Load_table_Click_1);
            // 
            // StudentsReport
            // 
            this.StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsReport.Location = new System.Drawing.Point(15, 123);
            this.StudentsReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentsReport.Name = "StudentsReport";
            this.StudentsReport.RowTemplate.Height = 24;
            this.StudentsReport.Size = new System.Drawing.Size(953, 235);
            this.StudentsReport.TabIndex = 2;
            this.StudentsReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsReport_CellContentClick);
            // 
            // Grades_Button
            // 
            this.Grades_Button.Location = new System.Drawing.Point(137, 14);
            this.Grades_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Grades_Button.Name = "Grades_Button";
            this.Grades_Button.Size = new System.Drawing.Size(104, 48);
            this.Grades_Button.TabIndex = 5;
            this.Grades_Button.Text = "Grades of students";
            this.Grades_Button.UseVisualStyleBackColor = true;
            this.Grades_Button.Click += new System.EventHandler(this.Grades_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "students assigned to the course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Grades_Button);
            this.Controls.Add(this.Load_table);
            this.Controls.Add(this.StudentsReport);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load_table;
        private System.Windows.Forms.DataGridView StudentsReport;
        private System.Windows.Forms.Button Grades_Button;
        private System.Windows.Forms.Button button1;
    }
}