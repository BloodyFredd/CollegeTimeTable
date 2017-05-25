namespace PRPJECT4NEW.Secretary
{
    partial class StudentDetails
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IDbutton = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.StudentInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(799, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(799, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "First name:";
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(962, 188);
            this.Lname.Margin = new System.Windows.Forms.Padding(5);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(348, 38);
            this.Lname.TabIndex = 10;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(962, 112);
            this.Fname.Margin = new System.Windows.Forms.Padding(5);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(348, 38);
            this.Fname.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(847, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Phone:";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(962, 261);
            this.Phone.Margin = new System.Windows.Forms.Padding(5);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(348, 38);
            this.Phone.TabIndex = 14;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(1017, 374);
            this.Save.Margin = new System.Windows.Forms.Padding(5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(149, 69);
            this.Save.TabIndex = 19;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID of the Student:";
            // 
            // IDbutton
            // 
            this.IDbutton.Location = new System.Drawing.Point(311, 200);
            this.IDbutton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.IDbutton.Name = "IDbutton";
            this.IDbutton.Size = new System.Drawing.Size(260, 38);
            this.IDbutton.TabIndex = 20;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(250, 266);
            this.Search.Margin = new System.Windows.Forms.Padding(5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(149, 69);
            this.Search.TabIndex = 22;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // StudentInfo
            // 
            this.StudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentInfo.Location = new System.Drawing.Point(22, 466);
            this.StudentInfo.Name = "StudentInfo";
            this.StudentInfo.RowTemplate.Height = 40;
            this.StudentInfo.Size = new System.Drawing.Size(1316, 465);
            this.StudentInfo.TabIndex = 23;
            this.StudentInfo.Visible = false;
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 1014);
            this.Controls.Add(this.StudentInfo);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDbutton);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Name = "StudentDetails";
            this.Text = "StudentDetails";
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDbutton;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView StudentInfo;
    }
}