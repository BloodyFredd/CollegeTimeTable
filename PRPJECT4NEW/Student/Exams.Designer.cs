namespace PRPJECT4NEW.Student
{
    partial class Exams
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
            this.specialExamGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.examsComboBox = new System.Windows.Forms.ComboBox();
            this.sendRequestBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.specialExamGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // specialExamGridView
            // 
            this.specialExamGridView.AllowUserToAddRows = false;
            this.specialExamGridView.AllowUserToDeleteRows = false;
            this.specialExamGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialExamGridView.EnableHeadersVisualStyles = false;
            this.specialExamGridView.Location = new System.Drawing.Point(12, 12);
            this.specialExamGridView.Name = "specialExamGridView";
            this.specialExamGridView.ReadOnly = true;
            this.specialExamGridView.RowHeadersVisible = false;
            this.specialExamGridView.Size = new System.Drawing.Size(835, 321);
            this.specialExamGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request special exam for:";
            // 
            // examsComboBox
            // 
            this.examsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.examsComboBox.FormattingEnabled = true;
            this.examsComboBox.Location = new System.Drawing.Point(147, 340);
            this.examsComboBox.Name = "examsComboBox";
            this.examsComboBox.Size = new System.Drawing.Size(121, 21);
            this.examsComboBox.TabIndex = 2;
            // 
            // sendRequestBtn
            // 
            this.sendRequestBtn.Location = new System.Drawing.Point(274, 339);
            this.sendRequestBtn.Name = "sendRequestBtn";
            this.sendRequestBtn.Size = new System.Drawing.Size(90, 23);
            this.sendRequestBtn.TabIndex = 3;
            this.sendRequestBtn.Text = "Send Request";
            this.sendRequestBtn.UseVisualStyleBackColor = true;
            this.sendRequestBtn.Click += new System.EventHandler(this.sendRequestBtn_Click);
            // 
            // Exams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 460);
            this.Controls.Add(this.sendRequestBtn);
            this.Controls.Add(this.examsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.specialExamGridView);
            this.Name = "Exams";
            this.Text = "Exams";
            ((System.ComponentModel.ISupportInitialize)(this.specialExamGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView specialExamGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox examsComboBox;
        private System.Windows.Forms.Button sendRequestBtn;
    }
}