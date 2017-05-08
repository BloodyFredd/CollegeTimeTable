namespace PRPJECT4NEW.Exams_Section
{
    partial class Special_Test
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
            this.studentspecialExamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Combo_Course_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentspecialExamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(902, 324);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentspecialExamBindingSource
            // 
            this.studentspecialExamBindingSource.DataSource = typeof(PRPJECT4NEW.Student_special_Exam);
            // 
            // Combo_Course_name
            // 
            this.Combo_Course_name.FormattingEnabled = true;
            this.Combo_Course_name.Location = new System.Drawing.Point(192, 38);
            this.Combo_Course_name.Name = "Combo_Course_name";
            this.Combo_Course_name.Size = new System.Drawing.Size(121, 24);
            this.Combo_Course_name.TabIndex = 2;
            this.Combo_Course_name.SelectedIndexChanged += new System.EventHandler(this.Combo_Course_name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course";
            // 
            // Special_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Combo_Course_name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Special_Test";
            this.Text = "Special_Test";
            this.Load += new System.EventHandler(this.Special_Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentspecialExamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentspecialExamBindingSource;
        private System.Windows.Forms.ComboBox Combo_Course_name;
        private System.Windows.Forms.Label label1;
    }
}