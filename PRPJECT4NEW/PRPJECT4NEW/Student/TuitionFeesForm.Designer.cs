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
            this.tuitionGridView = new System.Windows.Forms.DataGridView();
            this.totalFeeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tuitionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tuitionGridView
            // 
            this.tuitionGridView.AllowUserToAddRows = false;
            this.tuitionGridView.AllowUserToDeleteRows = false;
            this.tuitionGridView.AllowUserToResizeColumns = false;
            this.tuitionGridView.AllowUserToResizeRows = false;
            this.tuitionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tuitionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tuitionGridView.EnableHeadersVisualStyles = false;
            this.tuitionGridView.Location = new System.Drawing.Point(12, 128);
            this.tuitionGridView.Name = "tuitionGridView";
            this.tuitionGridView.RowHeadersVisible = false;
            this.tuitionGridView.Size = new System.Drawing.Size(854, 206);
            this.tuitionGridView.TabIndex = 0;
            // 
            // totalFeeLabel
            // 
            this.totalFeeLabel.AutoSize = true;
            this.totalFeeLabel.Location = new System.Drawing.Point(12, 351);
            this.totalFeeLabel.Name = "totalFeeLabel";
            this.totalFeeLabel.Size = new System.Drawing.Size(222, 13);
            this.totalFeeLabel.TabIndex = 1;
            this.totalFeeLabel.Text = "Approximate total tuition Fee for this semester:";
            // 
            // TuitionFeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 595);
            this.Controls.Add(this.totalFeeLabel);
            this.Controls.Add(this.tuitionGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TuitionFeesForm";
            this.Text = "TuitionFeesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tuitionGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tuitionGridView;
        private System.Windows.Forms.Label totalFeeLabel;
    }
}