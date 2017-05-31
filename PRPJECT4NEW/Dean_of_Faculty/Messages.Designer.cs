namespace PRPJECT4NEW.Dean_of_Faculty
{
    partial class Messages
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
            this.Add_New_Message_btn = new System.Windows.Forms.Button();
            this.Delete_Message_btn = new System.Windows.Forms.Button();
            this.Intended_to_combo = new System.Windows.Forms.ComboBox();
            this.Intended_to_lbl = new System.Windows.Forms.Label();
            this.Subject_lbl = new System.Windows.Forms.Label();
            this.Message_lbl = new System.Windows.Forms.Label();
            this.Subject_textbox = new System.Windows.Forms.TextBox();
            this.Message_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // Add_New_Message_btn
            // 
            this.Add_New_Message_btn.Location = new System.Drawing.Point(12, 411);
            this.Add_New_Message_btn.Name = "Add_New_Message_btn";
            this.Add_New_Message_btn.Size = new System.Drawing.Size(176, 33);
            this.Add_New_Message_btn.TabIndex = 1;
            this.Add_New_Message_btn.Text = "Add New Message";
            this.Add_New_Message_btn.UseVisualStyleBackColor = true;
            this.Add_New_Message_btn.Click += new System.EventHandler(this.Add_New_Message_btn_Click);
            // 
            // Delete_Message_btn
            // 
            this.Delete_Message_btn.Location = new System.Drawing.Point(793, 411);
            this.Delete_Message_btn.Name = "Delete_Message_btn";
            this.Delete_Message_btn.Size = new System.Drawing.Size(176, 50);
            this.Delete_Message_btn.TabIndex = 2;
            this.Delete_Message_btn.Text = "Delete Message";
            this.Delete_Message_btn.UseVisualStyleBackColor = true;
            this.Delete_Message_btn.Click += new System.EventHandler(this.Delete_Message_btn_Click);
            // 
            // Intended_to_combo
            // 
            this.Intended_to_combo.FormattingEnabled = true;
            this.Intended_to_combo.Location = new System.Drawing.Point(133, 470);
            this.Intended_to_combo.Name = "Intended_to_combo";
            this.Intended_to_combo.Size = new System.Drawing.Size(121, 24);
            this.Intended_to_combo.TabIndex = 3;
            // 
            // Intended_to_lbl
            // 
            this.Intended_to_lbl.AutoSize = true;
            this.Intended_to_lbl.Location = new System.Drawing.Point(44, 473);
            this.Intended_to_lbl.Name = "Intended_to_lbl";
            this.Intended_to_lbl.Size = new System.Drawing.Size(83, 17);
            this.Intended_to_lbl.TabIndex = 4;
            this.Intended_to_lbl.Text = "Intended to:";
            // 
            // Subject_lbl
            // 
            this.Subject_lbl.AutoSize = true;
            this.Subject_lbl.Location = new System.Drawing.Point(332, 473);
            this.Subject_lbl.Name = "Subject_lbl";
            this.Subject_lbl.Size = new System.Drawing.Size(55, 17);
            this.Subject_lbl.TabIndex = 5;
            this.Subject_lbl.Text = "Subject";
            // 
            // Message_lbl
            // 
            this.Message_lbl.AutoSize = true;
            this.Message_lbl.Location = new System.Drawing.Point(21, 518);
            this.Message_lbl.Name = "Message_lbl";
            this.Message_lbl.Size = new System.Drawing.Size(69, 17);
            this.Message_lbl.TabIndex = 6;
            this.Message_lbl.Text = "Message:";
            // 
            // Subject_textbox
            // 
            this.Subject_textbox.Location = new System.Drawing.Point(393, 470);
            this.Subject_textbox.Name = "Subject_textbox";
            this.Subject_textbox.Size = new System.Drawing.Size(100, 22);
            this.Subject_textbox.TabIndex = 8;
            // 
            // Message_textbox
            // 
            this.Message_textbox.Location = new System.Drawing.Point(110, 515);
            this.Message_textbox.Name = "Message_textbox";
            this.Message_textbox.Size = new System.Drawing.Size(383, 22);
            this.Message_textbox.TabIndex = 9;
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 556);
            this.Controls.Add(this.Message_textbox);
            this.Controls.Add(this.Subject_textbox);
            this.Controls.Add(this.Message_lbl);
            this.Controls.Add(this.Subject_lbl);
            this.Controls.Add(this.Intended_to_lbl);
            this.Controls.Add(this.Intended_to_combo);
            this.Controls.Add(this.Delete_Message_btn);
            this.Controls.Add(this.Add_New_Message_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Messages";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.Messages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add_New_Message_btn;
        private System.Windows.Forms.Button Delete_Message_btn;
        private System.Windows.Forms.ComboBox Intended_to_combo;
        private System.Windows.Forms.Label Intended_to_lbl;
        private System.Windows.Forms.Label Subject_lbl;
        private System.Windows.Forms.Label Message_lbl;
        private System.Windows.Forms.TextBox Subject_textbox;
        private System.Windows.Forms.TextBox Message_textbox;
    }
}