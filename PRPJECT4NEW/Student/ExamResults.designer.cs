namespace PRPJECT4NEW.Student
{
    partial class ExamResults
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
            this.ExamResultDataGridView = new System.Windows.Forms.DataGridView();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExamResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExamResultDataGridView
            // 
            this.ExamResultDataGridView.AllowUserToAddRows = false;
            this.ExamResultDataGridView.AllowUserToDeleteRows = false;
            this.ExamResultDataGridView.AllowUserToResizeColumns = false;
            this.ExamResultDataGridView.AllowUserToResizeRows = false;
            this.ExamResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamResultDataGridView.EnableHeadersVisualStyles = false;
            this.ExamResultDataGridView.Location = new System.Drawing.Point(3, 12);
            this.ExamResultDataGridView.MultiSelect = false;
            this.ExamResultDataGridView.Name = "ExamResultDataGridView";
            this.ExamResultDataGridView.ReadOnly = true;
            this.ExamResultDataGridView.RowHeadersVisible = false;
            this.ExamResultDataGridView.Size = new System.Drawing.Size(894, 460);
            this.ExamResultDataGridView.TabIndex = 0;
            // 
            // courseComboBox
            // 
            this.courseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(906, 25);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(205, 21);
            this.courseComboBox.TabIndex = 1;
            this.courseComboBox.SelectedIndexChanged += new System.EventHandler(this.courseComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(903, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Year:";
            // 
            // ExamResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.ExamResultDataGridView);
            this.Name = "ExamResults";
            this.Text = "ExamResults";
            ((System.ComponentModel.ISupportInitialize)(this.ExamResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ExamResultDataGridView;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.Label label1;
    }
}