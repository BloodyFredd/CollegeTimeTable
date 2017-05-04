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
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_table
            // 
            this.Load_table.Location = new System.Drawing.Point(11, 11);
            this.Load_table.Margin = new System.Windows.Forms.Padding(2);
            this.Load_table.Name = "Load_table";
            this.Load_table.Size = new System.Drawing.Size(78, 39);
            this.Load_table.TabIndex = 3;
            this.Load_table.Text = "Colleagues";
            this.Load_table.UseVisualStyleBackColor = true;
            this.Load_table.Click += new System.EventHandler(this.Load_table_Click_1);
            // 
            // StudentsReport
            // 
            this.StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsReport.Location = new System.Drawing.Point(11, 100);
            this.StudentsReport.Margin = new System.Windows.Forms.Padding(2);
            this.StudentsReport.Name = "StudentsReport";
            this.StudentsReport.RowTemplate.Height = 24;
            this.StudentsReport.Size = new System.Drawing.Size(500, 191);
            this.StudentsReport.TabIndex = 2;
            this.StudentsReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsReport_CellContentClick);
            // 
            // Grades_Button
            // 
            this.Grades_Button.Location = new System.Drawing.Point(103, 11);
            this.Grades_Button.Name = "Grades_Button";
            this.Grades_Button.Size = new System.Drawing.Size(78, 39);
            this.Grades_Button.TabIndex = 5;
            this.Grades_Button.Text = "Grades of students";
            this.Grades_Button.UseVisualStyleBackColor = true;
            this.Grades_Button.Click += new System.EventHandler(this.Grades_Button_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 301);
            this.Controls.Add(this.Grades_Button);
            this.Controls.Add(this.Load_table);
            this.Controls.Add(this.StudentsReport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load_table;
        private System.Windows.Forms.DataGridView StudentsReport;
        private System.Windows.Forms.Button Grades_Button;
    }
}