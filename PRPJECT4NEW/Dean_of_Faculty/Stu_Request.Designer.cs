namespace PRPJECT4NEW.Dean_of_Faculty
{
    partial class Stu_Request
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Approve_btn = new System.Windows.Forms.Button();
            this.Reject_btn = new System.Windows.Forms.Button();
            this.title_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Approve_btn
            // 
            this.Approve_btn.Location = new System.Drawing.Point(24, 487);
            this.Approve_btn.Name = "Approve_btn";
            this.Approve_btn.Size = new System.Drawing.Size(117, 38);
            this.Approve_btn.TabIndex = 1;
            this.Approve_btn.Text = "Approve";
            this.Approve_btn.UseVisualStyleBackColor = true;
            this.Approve_btn.Click += new System.EventHandler(this.Approve_btn_Click);
            // 
            // Reject_btn
            // 
            this.Reject_btn.Location = new System.Drawing.Point(156, 487);
            this.Reject_btn.Name = "Reject_btn";
            this.Reject_btn.Size = new System.Drawing.Size(114, 38);
            this.Reject_btn.TabIndex = 2;
            this.Reject_btn.Text = "Reject";
            this.Reject_btn.UseVisualStyleBackColor = true;
            this.Reject_btn.Click += new System.EventHandler(this.Reject_btn_Click);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Location = new System.Drawing.Point(171, 34);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(121, 17);
            this.title_lbl.TabIndex = 3;
            this.title_lbl.Text = "Student Requests";
            // 
            // Stu_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 549);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.Reject_btn);
            this.Controls.Add(this.Approve_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Stu_Request";
            this.Text = "Stu_Request";
            this.Load += new System.EventHandler(this.Stu_Request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Approve_btn;
        private System.Windows.Forms.Button Reject_btn;
        private System.Windows.Forms.Label title_lbl;
    }
}