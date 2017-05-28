namespace PRPJECT4NEW.Dean_of_Faculty
{
    partial class Tech_support
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
            this.new_Request_btn = new System.Windows.Forms.Button();
            this.Subject_lbl = new System.Windows.Forms.Label();
            this.massage_lbl = new System.Windows.Forms.Label();
            this.message_textbox = new System.Windows.Forms.TextBox();
            this.subject_txtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // new_Request_btn
            // 
            this.new_Request_btn.Location = new System.Drawing.Point(47, 504);
            this.new_Request_btn.Name = "new_Request_btn";
            this.new_Request_btn.Size = new System.Drawing.Size(103, 81);
            this.new_Request_btn.TabIndex = 1;
            this.new_Request_btn.Text = "Add new Request";
            this.new_Request_btn.UseVisualStyleBackColor = true;
            this.new_Request_btn.Click += new System.EventHandler(this.new_Request_btn_Click);
            // 
            // Subject_lbl
            // 
            this.Subject_lbl.AutoSize = true;
            this.Subject_lbl.Location = new System.Drawing.Point(210, 504);
            this.Subject_lbl.Name = "Subject_lbl";
            this.Subject_lbl.Size = new System.Drawing.Size(55, 17);
            this.Subject_lbl.TabIndex = 3;
            this.Subject_lbl.Text = "Subject";
            // 
            // massage_lbl
            // 
            this.massage_lbl.AutoSize = true;
            this.massage_lbl.Location = new System.Drawing.Point(210, 551);
            this.massage_lbl.Name = "massage_lbl";
            this.massage_lbl.Size = new System.Drawing.Size(65, 17);
            this.massage_lbl.TabIndex = 4;
            this.massage_lbl.Text = "Message";
            // 
            // message_textbox
            // 
            this.message_textbox.Location = new System.Drawing.Point(293, 551);
            this.message_textbox.Name = "message_textbox";
            this.message_textbox.Size = new System.Drawing.Size(628, 22);
            this.message_textbox.TabIndex = 5;
            // 
            // subject_txtbox
            // 
            this.subject_txtbox.Location = new System.Drawing.Point(293, 504);
            this.subject_txtbox.Name = "subject_txtbox";
            this.subject_txtbox.Size = new System.Drawing.Size(100, 22);
            this.subject_txtbox.TabIndex = 6;
            // 
            // Tech_support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 598);
            this.Controls.Add(this.subject_txtbox);
            this.Controls.Add(this.message_textbox);
            this.Controls.Add(this.massage_lbl);
            this.Controls.Add(this.Subject_lbl);
            this.Controls.Add(this.new_Request_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tech_support";
            this.Text = "Tech_support";
            this.Load += new System.EventHandler(this.Tech_support_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button new_Request_btn;
        private System.Windows.Forms.Label Subject_lbl;
        private System.Windows.Forms.Label massage_lbl;
        private System.Windows.Forms.TextBox message_textbox;
        private System.Windows.Forms.TextBox subject_txtbox;
    }
}