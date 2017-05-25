namespace PRPJECT4NEW.Student
{
    partial class UpdateCalendar
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
            this.calendarGridView = new System.Windows.Forms.DataGridView();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarGridView
            // 
            this.calendarGridView.AllowUserToDeleteRows = false;
            this.calendarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarGridView.EnableHeadersVisualStyles = false;
            this.calendarGridView.Location = new System.Drawing.Point(12, 12);
            this.calendarGridView.Name = "calendarGridView";
            this.calendarGridView.ReadOnly = true;
            this.calendarGridView.RowHeadersVisible = false;
            this.calendarGridView.Size = new System.Drawing.Size(706, 448);
            this.calendarGridView.TabIndex = 0;
            this.calendarGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calendarGridView_CellContentClick);
            this.calendarGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.calendarGridView_CellFormatting);
            this.calendarGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.calendarGridView_CellPainting);
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(742, 12);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(158, 21);
            this.courseComboBox.TabIndex = 1;
            // 
            // UpdateCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 502);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.calendarGridView);
            this.Name = "UpdateCalendar";
            this.Text = "UpdateCalendar";
            this.Load += new System.EventHandler(this.UpdateCalendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView calendarGridView;
        private System.Windows.Forms.ComboBox courseComboBox;
    }
}