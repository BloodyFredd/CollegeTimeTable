namespace BranchA_MazalPlus.Lecturer
{
    partial class Factor
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
            this.class_num = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // class_num
            // 
            this.class_num.FormattingEnabled = true;
            this.class_num.Items.AddRange(new object[] {
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "300",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "400",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406"});
            this.class_num.Location = new System.Drawing.Point(40, 40);
            this.class_num.Name = "class_num";
            this.class_num.Size = new System.Drawing.Size(135, 24);
            this.class_num.TabIndex = 0;
            this.class_num.Text = "Choose class";
            this.class_num.SelectedIndexChanged += new System.EventHandler(this.class_num_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "Factor this class";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Factor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.class_num);
            this.Name = "Factor";
            this.Text = "Factor";
            this.Load += new System.EventHandler(this.Factor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox class_num;
        private System.Windows.Forms.Button button1;
    }
}