namespace PRPJECT4NEW.Tech_Team
{
    partial class Recorded_lectures
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.date_cmb = new System.Windows.Forms.ComboBox();
            this.date_lbl = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern2;
            this.panel1.Controls.Add(this.refresh_btn);
            this.panel1.Controls.Add(this.save_btn);
            this.panel1.Controls.Add(this.date_cmb);
            this.panel1.Controls.Add(this.date_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1979, 163);
            this.panel1.TabIndex = 0;
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.refresh_btn.FlatAppearance.BorderSize = 0;
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Location = new System.Drawing.Point(425, 56);
            this.refresh_btn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(289, 78);
            this.refresh_btn.TabIndex = 6;
            this.refresh_btn.Text = "&Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(866, 56);
            this.save_btn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(289, 78);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "save to file";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // date_cmb
            // 
            this.date_cmb.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_cmb.FormattingEnabled = true;
            this.date_cmb.Location = new System.Drawing.Point(40, 76);
            this.date_cmb.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.date_cmb.Name = "date_cmb";
            this.date_cmb.Size = new System.Drawing.Size(277, 38);
            this.date_cmb.TabIndex = 2;
            this.date_cmb.Text = "choose date";
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(30, 16);
            this.date_lbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(123, 51);
            this.date_lbl.TabIndex = 1;
            this.date_lbl.Text = "Date";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 163);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(1979, 555);
            this.dataGridView.TabIndex = 1;
            // 
            // Recorded_lectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1979, 718);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Recorded_lectures";
            this.Text = "Available_Classes";
            this.Load += new System.EventHandler(this.Available_Classes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.ComboBox date_cmb;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button refresh_btn;
    }
}