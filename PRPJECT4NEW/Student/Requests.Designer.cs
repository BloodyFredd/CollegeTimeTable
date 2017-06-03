namespace PRPJECT4NEW.Student
{
    partial class Requests
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
            this.requestsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sendRequestBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.requestsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // requestsGridView
            // 
            this.requestsGridView.AllowUserToAddRows = false;
            this.requestsGridView.AllowUserToDeleteRows = false;
            this.requestsGridView.AllowUserToResizeColumns = false;
            this.requestsGridView.AllowUserToResizeRows = false;
            this.requestsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsGridView.EnableHeadersVisualStyles = false;
            this.requestsGridView.Location = new System.Drawing.Point(12, 12);
            this.requestsGridView.MultiSelect = false;
            this.requestsGridView.Name = "requestsGridView";
            this.requestsGridView.ReadOnly = true;
            this.requestsGridView.RowHeadersVisible = false;
            this.requestsGridView.Size = new System.Drawing.Size(1084, 347);
            this.requestsGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject:";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(15, 383);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(1081, 20);
            this.subjectTextBox.TabIndex = 2;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(15, 426);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(1081, 138);
            this.messageTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message:";
            // 
            // sendRequestBtn
            // 
            this.sendRequestBtn.Location = new System.Drawing.Point(515, 580);
            this.sendRequestBtn.Name = "sendRequestBtn";
            this.sendRequestBtn.Size = new System.Drawing.Size(75, 23);
            this.sendRequestBtn.TabIndex = 5;
            this.sendRequestBtn.Text = "Send";
            this.sendRequestBtn.UseVisualStyleBackColor = true;
            this.sendRequestBtn.Click += new System.EventHandler(this.sendRequestBtn_Click);
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 615);
            this.Controls.Add(this.sendRequestBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requestsGridView);
            this.Name = "Requests";
            this.Text = "Requests";
            ((System.ComponentModel.ISupportInitialize)(this.requestsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView requestsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendRequestBtn;
    }
}