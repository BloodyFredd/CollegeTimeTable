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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_table
            // 
            this.Load_table.Location = new System.Drawing.Point(22, 326);
            this.Load_table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Load_table.Name = "Load_table";
            this.Load_table.Size = new System.Drawing.Size(148, 37);
            this.Load_table.TabIndex = 3;
            this.Load_table.Text = "Show Students only!";
            this.Load_table.UseVisualStyleBackColor = true;
            this.Load_table.Click += new System.EventHandler(this.Load_table_Click_1);
            // 
            // StudentsReport
            // 
            this.StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsReport.Location = new System.Drawing.Point(22, 76);
            this.StudentsReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentsReport.Name = "StudentsReport";
            this.StudentsReport.RowTemplate.Height = 24;
            this.StudentsReport.Size = new System.Drawing.Size(363, 164);
            this.StudentsReport.TabIndex = 2;
            this.StudentsReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsReport_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show Teaching Staff only!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Grades of Students Assigned to my Courses";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 384);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Load_table);
            this.Controls.Add(this.StudentsReport);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load_table;
        private System.Windows.Forms.DataGridView StudentsReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}