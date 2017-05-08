namespace PRPJECT4NEW.Dean_of_Faculty
{
    partial class Special_date
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.special_date_combobox = new System.Windows.Forms.ComboBox();
            this.Status_lable = new System.Windows.Forms.Label();
            this.studentspecialExamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentspecialExamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(789, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // special_date_combobox
            // 
            this.special_date_combobox.FormattingEnabled = true;
            this.special_date_combobox.Location = new System.Drawing.Point(228, 25);
            this.special_date_combobox.Name = "special_date_combobox";
            this.special_date_combobox.Size = new System.Drawing.Size(121, 24);
            this.special_date_combobox.TabIndex = 1;
            this.special_date_combobox.SelectedIndexChanged += new System.EventHandler(this.special_date_combobox_SelectedIndexChanged);
            // 
            // Status_lable
            // 
            this.Status_lable.AutoSize = true;
            this.Status_lable.Location = new System.Drawing.Point(152, 32);
            this.Status_lable.Name = "Status_lable";
            this.Status_lable.Size = new System.Drawing.Size(48, 17);
            this.Status_lable.TabIndex = 2;
            this.Status_lable.Text = "Status";
            // 
            // studentspecialExamBindingSource
            // 
            this.studentspecialExamBindingSource.DataSource = typeof(PRPJECT4NEW.Student_special_Exam);
            // 
            // Special_date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 536);
            this.Controls.Add(this.Status_lable);
            this.Controls.Add(this.special_date_combobox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Special_date";
            this.Text = "Special_date";
            this.Load += new System.EventHandler(this.Special_date_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentspecialExamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentspecialExamBindingSource;
        private System.Windows.Forms.ComboBox special_date_combobox;
        private System.Windows.Forms.Label Status_lable;
    }
}