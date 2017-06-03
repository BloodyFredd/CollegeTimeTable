namespace PRPJECT4NEW.Student
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
            this.messagesGridView = new System.Windows.Forms.DataGridView();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.messagesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // messagesGridView
            // 
            this.messagesGridView.AllowUserToAddRows = false;
            this.messagesGridView.AllowUserToDeleteRows = false;
            this.messagesGridView.AllowUserToResizeColumns = false;
            this.messagesGridView.AllowUserToResizeRows = false;
            this.messagesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messagesGridView.EnableHeadersVisualStyles = false;
            this.messagesGridView.Location = new System.Drawing.Point(12, 12);
            this.messagesGridView.MultiSelect = false;
            this.messagesGridView.Name = "messagesGridView";
            this.messagesGridView.ReadOnly = true;
            this.messagesGridView.RowHeadersVisible = false;
            this.messagesGridView.Size = new System.Drawing.Size(727, 228);
            this.messagesGridView.TabIndex = 0;
            this.messagesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.messagesGridView_CellClick);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(12, 261);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTextBox.Size = new System.Drawing.Size(727, 207);
            this.messageTextBox.TabIndex = 1;
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 504);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messagesGridView);
            this.Name = "Messages";
            this.Text = "Messages";
            ((System.ComponentModel.ISupportInitialize)(this.messagesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView messagesGridView;
        private System.Windows.Forms.TextBox messageTextBox;
    }
}