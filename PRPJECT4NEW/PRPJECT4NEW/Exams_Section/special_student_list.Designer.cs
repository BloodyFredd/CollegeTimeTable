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
            this.components = new System.ComponentModel.Container();
            this.Type_of_easements_comboBox = new System.Windows.Forms.ComboBox();
            this.Type_of_easements_label = new System.Windows.Forms.Label();
            this.Sview = new System.Windows.Forms.DataGridView();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.save_laptop_button = new System.Windows.Forms.Button();
            this.save_formulashetts_button = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Sview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Type_of_easements_comboBox
            // 
            this.Type_of_easements_comboBox.AccessibleName = "Type_of_easements_comboBox";
            this.Type_of_easements_comboBox.FormattingEnabled = true;
            this.Type_of_easements_comboBox.Location = new System.Drawing.Point(224, 21);
            this.Type_of_easements_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Type_of_easements_comboBox.Name = "Type_of_easements_comboBox";
            this.Type_of_easements_comboBox.Size = new System.Drawing.Size(125, 24);
            this.Type_of_easements_comboBox.TabIndex = 0;
            this.Type_of_easements_comboBox.Text = "..";
            this.Type_of_easements_comboBox.SelectedIndexChanged += new System.EventHandler(this.Type_of_easements_comboBox_SelectedIndexChanged);
            // 
            // Type_of_easements_label
            // 
            this.Type_of_easements_label.AccessibleName = "Type_of_easements_label";
            this.Type_of_easements_label.AutoSize = true;
            this.Type_of_easements_label.Location = new System.Drawing.Point(16, 21);
            this.Type_of_easements_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Type_of_easements_label.Name = "Type_of_easements_label";
            this.Type_of_easements_label.Size = new System.Drawing.Size(181, 17);
            this.Type_of_easements_label.TabIndex = 1;
            this.Type_of_easements_label.Text = "Type of easements to show";
            this.Type_of_easements_label.Click += new System.EventHandler(this.Type_of_easements_label_Click);
            // 
            // Sview
            // 
            this.Sview.AccessibleName = "Sview";
            this.Sview.AllowUserToAddRows = false;
            this.Sview.AllowUserToDeleteRows = false;
            this.Sview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sview.Location = new System.Drawing.Point(-3, 64);
            this.Sview.Margin = new System.Windows.Forms.Padding(4);
            this.Sview.Name = "Sview";
            this.Sview.Size = new System.Drawing.Size(992, 291);
            this.Sview.TabIndex = 2;
            this.Sview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sview_CellContentClick);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Location = new System.Drawing.Point(410, 9);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(75, 46);
            this.Refresh_Button.TabIndex = 3;
            this.Refresh_Button.Text = "Refresh";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Save_button
            // 
            this.Save_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Save_button.Location = new System.Drawing.Point(19, 372);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(206, 49);
            this.Save_button.TabIndex = 4;
            this.Save_button.Text = "Save Extra Time student list";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // save_laptop_button
            // 
            this.save_laptop_button.Location = new System.Drawing.Point(284, 372);
            this.save_laptop_button.Name = "save_laptop_button";
            this.save_laptop_button.Size = new System.Drawing.Size(231, 48);
            this.save_laptop_button.TabIndex = 5;
            this.save_laptop_button.Text = "Save Laptop student list";
            this.save_laptop_button.UseVisualStyleBackColor = true;
            this.save_laptop_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // save_formulashetts_button
            // 
            this.save_formulashetts_button.Location = new System.Drawing.Point(562, 372);
            this.save_formulashetts_button.Name = "save_formulashetts_button";
            this.save_formulashetts_button.Size = new System.Drawing.Size(235, 48);
            this.save_formulashetts_button.TabIndex = 6;
            this.save_formulashetts_button.Text = "Save Formula Sheets student list";
            this.save_formulashetts_button.UseVisualStyleBackColor = true;
            this.save_formulashetts_button.Click += new System.EventHandler(this.save3_button_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(PRPJECT4NEW.student);
            // 
            // special_student_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 433);
            this.Controls.Add(this.save_formulashetts_button);
            this.Controls.Add(this.save_laptop_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Sview);
            this.Controls.Add(this.Type_of_easements_label);
            this.Controls.Add(this.Type_of_easements_comboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "special_student_list";
            this.Text = "special_student_list";
            this.Load += new System.EventHandler(this.special_student_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.ComboBox Type_of_easements_comboBox;
        private System.Windows.Forms.Label Type_of_easements_label;
        private System.Windows.Forms.DataGridView Sview;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button save_laptop_button;
        private System.Windows.Forms.Button save_formulashetts_button;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}