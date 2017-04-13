namespace BranchA_MazalPlus.Admin
{
    partial class RemoveStudent
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
            this.ID_Button = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_Button
            // 
            this.ID_Button.Location = new System.Drawing.Point(109, 9);
            this.ID_Button.Name = "ID_Button";
            this.ID_Button.Size = new System.Drawing.Size(100, 20);
            this.ID_Button.TabIndex = 0;
            this.ID_Button.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(12, 12);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(91, 13);
            this.Id.TabIndex = 1;
            this.Id.Text = "ID of the Student:";
            this.Id.Click += new System.EventHandler(this.Id_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(180, 35);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 2;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 70);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.ID_Button);
            this.Name = "RemoveStudent";
            this.Text = "Remove a Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_Button;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Button Delete_Button;
    }
}