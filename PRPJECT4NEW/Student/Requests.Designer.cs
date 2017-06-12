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
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.examsComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.specialExamGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.requestsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialExamGridView)).BeginInit();
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
            this.requestsGridView.Location = new System.Drawing.Point(11, 35);
            this.requestsGridView.MultiSelect = false;
            this.requestsGridView.Name = "requestsGridView";
            this.requestsGridView.ReadOnly = true;
            this.requestsGridView.RowHeadersVisible = false;
            this.requestsGridView.Size = new System.Drawing.Size(1084, 145);
            this.requestsGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject:";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(11, 199);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(1084, 20);
            this.subjectTextBox.TabIndex = 2;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(9, 242);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(1086, 84);
            this.messageTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message:";
            // 
            // sendRequestBtn
            // 
            this.sendRequestBtn.Location = new System.Drawing.Point(10, 332);
            this.sendRequestBtn.Name = "sendRequestBtn";
            this.sendRequestBtn.Size = new System.Drawing.Size(89, 23);
            this.sendRequestBtn.TabIndex = 5;
            this.sendRequestBtn.Text = "Send Request";
            this.sendRequestBtn.UseVisualStyleBackColor = true;
            this.sendRequestBtn.Click += new System.EventHandler(this.sendRequestBtn_Click);
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Location = new System.Drawing.Point(9, 652);
            this.reasonTextBox.Multiline = true;
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(834, 65);
            this.reasonTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 635);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Reason:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 731);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Send Request";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // examsComboBox
            // 
            this.examsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.examsComboBox.FormattingEnabled = true;
            this.examsComboBox.Location = new System.Drawing.Point(143, 609);
            this.examsComboBox.Name = "examsComboBox";
            this.examsComboBox.Size = new System.Drawing.Size(121, 21);
            this.examsComboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Request special exam for:";
            // 
            // specialExamGridView
            // 
            this.specialExamGridView.AllowUserToAddRows = false;
            this.specialExamGridView.AllowUserToDeleteRows = false;
            this.specialExamGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialExamGridView.EnableHeadersVisualStyles = false;
            this.specialExamGridView.Location = new System.Drawing.Point(9, 430);
            this.specialExamGridView.Name = "specialExamGridView";
            this.specialExamGridView.ReadOnly = true;
            this.specialExamGridView.RowHeadersVisible = false;
            this.specialExamGridView.Size = new System.Drawing.Size(1084, 171);
            this.specialExamGridView.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "General Request";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Specia Exam Request";
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 831);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.examsComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.specialExamGridView);
            this.Controls.Add(this.sendRequestBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requestsGridView);
            this.Name = "Requests";
            this.Text = "Requests";
            ((System.ComponentModel.ISupportInitialize)(this.requestsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialExamGridView)).EndInit();
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
        private System.Windows.Forms.TextBox reasonTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox examsComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView specialExamGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}