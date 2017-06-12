namespace PRPJECT4NEW.Student
{
    partial class StudentExams
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
            this.examGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.examGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // examGridView
            // 
            this.examGridView.AllowUserToAddRows = false;
            this.examGridView.AllowUserToDeleteRows = false;
            this.examGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examGridView.EnableHeadersVisualStyles = false;
            this.examGridView.Location = new System.Drawing.Point(12, 12);
            this.examGridView.Name = "examGridView";
            this.examGridView.ReadOnly = true;
            this.examGridView.RowHeadersVisible = false;
            this.examGridView.Size = new System.Drawing.Size(835, 321);
            this.examGridView.TabIndex = 0;
            // 
            // Exams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 497);
            this.Controls.Add(this.examGridView);
            this.Name = "Exams";
            this.Text = "Exams";
            ((System.ComponentModel.ISupportInitialize)(this.examGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView examGridView;
    }
}