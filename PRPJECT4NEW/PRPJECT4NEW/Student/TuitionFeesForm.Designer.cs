namespace PRPJECT4NEW.Student
{
    partial class TuitionFeesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tuitionGridView = new System.Windows.Forms.DataGridView();
            this.totalFeeLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tuitionGridView
            // 
            this.tuitionGridView.AllowUserToAddRows = false;
            this.tuitionGridView.AllowUserToDeleteRows = false;
            this.tuitionGridView.AllowUserToResizeColumns = false;
            this.tuitionGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuitionGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tuitionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tuitionGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tuitionGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tuitionGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tuitionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tuitionGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.tuitionGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tuitionGridView.EnableHeadersVisualStyles = false;
            this.tuitionGridView.Location = new System.Drawing.Point(0, 100);
            this.tuitionGridView.Margin = new System.Windows.Forms.Padding(7, 120, 7, 7);
            this.tuitionGridView.Name = "tuitionGridView";
            this.tuitionGridView.RowHeadersVisible = false;
            this.tuitionGridView.Size = new System.Drawing.Size(1929, 676);
            this.tuitionGridView.TabIndex = 0;
            this.tuitionGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tuitionGridView_CellContentClick);
            // 
            // totalFeeLabel
            // 
            this.totalFeeLabel.AutoSize = true;
            this.totalFeeLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFeeLabel.ForeColor = System.Drawing.Color.Red;
            this.totalFeeLabel.Location = new System.Drawing.Point(849, 65);
            this.totalFeeLabel.Margin = new System.Windows.Forms.Padding(7, 65, 120, 0);
            this.totalFeeLabel.Name = "totalFeeLabel";
            this.totalFeeLabel.Size = new System.Drawing.Size(960, 49);
            this.totalFeeLabel.TabIndex = 1;
            this.totalFeeLabel.Text = "Approximate total tuition Fee for this semester:";
            this.totalFeeLabel.Click += new System.EventHandler(this.totalFeeLabel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.totalFeeLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 776);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1929, 163);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1929, 100);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // TuitionFeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1929, 939);
            this.Controls.Add(this.tuitionGridView);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "TuitionFeesForm";
            this.Text = "TuitionFeesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tuitionGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tuitionGridView;
        private System.Windows.Forms.Label totalFeeLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}