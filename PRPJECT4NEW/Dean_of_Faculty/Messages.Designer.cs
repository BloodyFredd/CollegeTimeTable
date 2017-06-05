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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add_New_Message_btn = new System.Windows.Forms.Button();
            this.Delete_Message_btn = new System.Windows.Forms.Button();
            this.Intended_to_combo = new System.Windows.Forms.ComboBox();
            this.Intended_to_lbl = new System.Windows.Forms.Label();
            this.Subject_lbl = new System.Windows.Forms.Label();
            this.Message_lbl = new System.Windows.Forms.Label();
            this.Subject_textbox = new System.Windows.Forms.TextBox();
            this.Message_textbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1157, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // Add_New_Message_btn
            // 
            this.Add_New_Message_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Add_New_Message_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_New_Message_btn.ForeColor = System.Drawing.Color.White;
            this.Add_New_Message_btn.Location = new System.Drawing.Point(599, 86);
            this.Add_New_Message_btn.Name = "Add_New_Message_btn";
            this.Add_New_Message_btn.Size = new System.Drawing.Size(195, 71);
            this.Add_New_Message_btn.TabIndex = 1;
            this.Add_New_Message_btn.Text = "Add New Message";
            this.Add_New_Message_btn.UseVisualStyleBackColor = false;
            this.Add_New_Message_btn.Click += new System.EventHandler(this.Add_New_Message_btn_Click);
            // 
            // Delete_Message_btn
            // 
            this.Delete_Message_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.Delete_Message_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Message_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_Message_btn.Location = new System.Drawing.Point(856, 86);
            this.Delete_Message_btn.Name = "Delete_Message_btn";
            this.Delete_Message_btn.Size = new System.Drawing.Size(176, 71);
            this.Delete_Message_btn.TabIndex = 2;
            this.Delete_Message_btn.Text = "Delete Message";
            this.Delete_Message_btn.UseVisualStyleBackColor = false;
            this.Delete_Message_btn.Click += new System.EventHandler(this.Delete_Message_btn_Click);
            // 
            // Intended_to_combo
            // 
            this.Intended_to_combo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intended_to_combo.FormattingEnabled = true;
            this.Intended_to_combo.Location = new System.Drawing.Point(145, 34);
            this.Intended_to_combo.Name = "Intended_to_combo";
            this.Intended_to_combo.Size = new System.Drawing.Size(121, 29);
            this.Intended_to_combo.TabIndex = 3;
            // 
            // Intended_to_lbl
            // 
            this.Intended_to_lbl.AutoSize = true;
            this.Intended_to_lbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intended_to_lbl.Location = new System.Drawing.Point(23, 34);
            this.Intended_to_lbl.Name = "Intended_to_lbl";
            this.Intended_to_lbl.Size = new System.Drawing.Size(116, 21);
            this.Intended_to_lbl.TabIndex = 4;
            this.Intended_to_lbl.Text = "Intended to:";
            // 
            // Subject_lbl
            // 
            this.Subject_lbl.AutoSize = true;
            this.Subject_lbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_lbl.Location = new System.Drawing.Point(282, 37);
            this.Subject_lbl.Name = "Subject_lbl";
            this.Subject_lbl.Size = new System.Drawing.Size(77, 21);
            this.Subject_lbl.TabIndex = 5;
            this.Subject_lbl.Text = "Subject:";
            // 
            // Message_lbl
            // 
            this.Message_lbl.AutoSize = true;
            this.Message_lbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_lbl.Location = new System.Drawing.Point(23, 86);
            this.Message_lbl.Name = "Message_lbl";
            this.Message_lbl.Size = new System.Drawing.Size(91, 21);
            this.Message_lbl.TabIndex = 6;
            this.Message_lbl.Text = "Message:";
            // 
            // Subject_textbox
            // 
            this.Subject_textbox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_textbox.Location = new System.Drawing.Point(369, 35);
            this.Subject_textbox.Name = "Subject_textbox";
            this.Subject_textbox.Size = new System.Drawing.Size(154, 28);
            this.Subject_textbox.TabIndex = 8;
            // 
            // Message_textbox
            // 
            this.Message_textbox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_textbox.Location = new System.Drawing.Point(137, 86);
            this.Message_textbox.Multiline = true;
            this.Message_textbox.Name = "Message_textbox";
            this.Message_textbox.Size = new System.Drawing.Size(386, 161);
            this.Message_textbox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 61);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.panel2.Controls.Add(this.Message_textbox);
            this.panel2.Controls.Add(this.Delete_Message_btn);
            this.panel2.Controls.Add(this.Subject_textbox);
            this.panel2.Controls.Add(this.Add_New_Message_btn);
            this.panel2.Controls.Add(this.Message_lbl);
            this.panel2.Controls.Add(this.Intended_to_combo);
            this.panel2.Controls.Add(this.Subject_lbl);
            this.panel2.Controls.Add(this.Intended_to_lbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 259);
            this.panel2.TabIndex = 11;
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 670);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Messages";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.Messages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}