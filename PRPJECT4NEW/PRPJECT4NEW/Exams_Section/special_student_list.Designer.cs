namespace PRPJECT4NEW.Exams_Section
{
    partial class special_student_list
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
            this.Type_of_easements_comboBox = new System.Windows.Forms.ComboBox();
            this.Type_of_easements_label = new System.Windows.Forms.Label();
            this.Sview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Sview)).BeginInit();
            this.SuspendLayout();
            // 
            // Type_of_easements_comboBox
            // 
            this.Type_of_easements_comboBox.AccessibleName = "Type_of_easements_comboBox";
            this.Type_of_easements_comboBox.FormattingEnabled = true;
            this.Type_of_easements_comboBox.Location = new System.Drawing.Point(131, 9);
            this.Type_of_easements_comboBox.Name = "Type_of_easements_comboBox";
            this.Type_of_easements_comboBox.Size = new System.Drawing.Size(95, 21);
            this.Type_of_easements_comboBox.TabIndex = 0;
            this.Type_of_easements_comboBox.Text = "Type";
            this.Type_of_easements_comboBox.SelectedIndexChanged += new System.EventHandler(this.Type_of_easements_comboBox_SelectedIndexChanged);
            // 
            // Type_of_easements_label
            // 
            this.Type_of_easements_label.AccessibleName = "Type_of_easements_label";
            this.Type_of_easements_label.AutoSize = true;
            this.Type_of_easements_label.Location = new System.Drawing.Point(12, 9);
            this.Type_of_easements_label.Name = "Type_of_easements_label";
            this.Type_of_easements_label.Size = new System.Drawing.Size(97, 13);
            this.Type_of_easements_label.TabIndex = 1;
            this.Type_of_easements_label.Text = "Type of easements";
            this.Type_of_easements_label.Click += new System.EventHandler(this.Type_of_easements_label_Click);
            // 
            // Sview
            // 
            this.Sview.AccessibleName = "Sview";
            this.Sview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sview.Location = new System.Drawing.Point(-2, 52);
            this.Sview.Name = "Sview";
            this.Sview.Size = new System.Drawing.Size(660, 299);
            this.Sview.TabIndex = 2;
            // 
            // special_student_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 352);
            this.Controls.Add(this.Sview);
            this.Controls.Add(this.Type_of_easements_label);
            this.Controls.Add(this.Type_of_easements_comboBox);
            this.Name = "special_student_list";
            this.Text = "special_student_list";
            this.Load += new System.EventHandler(this.special_student_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Type_of_easements_comboBox;
        private System.Windows.Forms.Label Type_of_easements_label;
        private System.Windows.Forms.DataGridView Sview;
    }
}