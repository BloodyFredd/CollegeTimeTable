namespace PRPJECT4NEW.Admin
{
    partial class RemoveAssistant
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
            this.IDbutton = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDbutton
            // 
            this.IDbutton.Location = new System.Drawing.Point(153, 9);
            this.IDbutton.Name = "IDbutton";
            this.IDbutton.Size = new System.Drawing.Size(117, 20);
            this.IDbutton.TabIndex = 0;
            this.IDbutton.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(3, 12);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(144, 13);
            this.Id.TabIndex = 1;
            this.Id.Text = "ID of the Teaching Assistant:";
            this.Id.Click += new System.EventHandler(this.Id_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(107, 51);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 2;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 86);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.IDbutton);
            this.Name = "RemoveAssistant";
            this.Text = "Remove a Teaching Assistant";
            this.Load += new System.EventHandler(this.RemoveAssistant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDbutton;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Button Delete_Button;
    }
}