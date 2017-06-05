namespace PRPJECT4NEW
{
    partial class NewUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Fname = new System.Windows.Forms.TextBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Lname = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Permission = new System.Windows.Forms.Label();
            this.perm1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.facebook_btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 97);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create new user";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(316, 916);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(228, 512);
            this.Fname.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(348, 38);
            this.Fname.TabIndex = 1;
            this.Fname.TextChanged += new System.EventHandler(this.Fname_TextChanged);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "person";
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(228, 628);
            this.Lname.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(348, 38);
            this.Lname.TabIndex = 2;
            this.Lname.TextChanged += new System.EventHandler(this.Lname_TextChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(228, 732);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(348, 38);
            this.ID.TabIndex = 3;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(228, 841);
            this.Phone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(348, 38);
            this.Phone.TabIndex = 4;
            this.Phone.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(312, 457);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "First name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(312, 583);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(362, 684);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(330, 789);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(312, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "User Name:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(228, 279);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(348, 38);
            this.Email.TabIndex = 5;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Permission
            // 
            this.Permission.AutoSize = true;
            this.Permission.BackColor = System.Drawing.Color.Transparent;
            this.Permission.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Permission.Location = new System.Drawing.Point(312, 343);
            this.Permission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Permission.Name = "Permission";
            this.Permission.Size = new System.Drawing.Size(164, 32);
            this.Permission.TabIndex = 15;
            this.Permission.Text = "Permission:";
            this.Permission.Click += new System.EventHandler(this.Permission_Click);
            // 
            // perm1
            // 
            this.perm1.FormattingEnabled = true;
            this.perm1.Items.AddRange(new object[] {
            "Lecturer",
            "Student",
            "Teaching_Assistant",
            "Tech_Team",
            "Exam_Section"});
            this.perm1.Location = new System.Drawing.Point(228, 399);
            this.perm1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.perm1.Name = "perm1";
            this.perm1.Size = new System.Drawing.Size(348, 39);
            this.perm1.TabIndex = 16;
            this.perm1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.AccessibleName = "Buttons_place";
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.panel2.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.bg_pattern;
            this.panel2.Controls.Add(this.facebook_btnLogin);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.perm1);
            this.panel2.Controls.Add(this.Fname);
            this.panel2.Controls.Add(this.Permission);
            this.panel2.Controls.Add(this.Lname);
            this.panel2.Controls.Add(this.ID);
            this.panel2.Controls.Add(this.Email);
            this.panel2.Controls.Add(this.Phone);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.panel2.Size = new System.Drawing.Size(804, 1348);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // facebook_btnLogin
            // 
            this.facebook_btnLogin.AccessibleName = "facebook_btnLogin";
            this.facebook_btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(99)))), ((int)(((byte)(159)))));
            this.facebook_btnLogin.BackgroundImage = global::PRPJECT4NEW.Properties.Resources.facebook_btn;
            this.facebook_btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.facebook_btnLogin.FlatAppearance.BorderSize = 0;
            this.facebook_btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facebook_btnLogin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebook_btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.facebook_btnLogin.Location = new System.Drawing.Point(124, 1058);
            this.facebook_btnLogin.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.facebook_btnLogin.Name = "facebook_btnLogin";
            this.facebook_btnLogin.Size = new System.Drawing.Size(536, 89);
            this.facebook_btnLogin.TabIndex = 20;
            this.facebook_btnLogin.UseVisualStyleBackColor = false;
            this.facebook_btnLogin.Click += new System.EventHandler(this.facebook_btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(674, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 24, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 31, 90, 0);
            this.pictureBox1.Size = new System.Drawing.Size(76, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1348);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Email;
     //   private MazalDataSet mazalDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Label Permission;
        private System.Windows.Forms.ComboBox perm1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button facebook_btnLogin;
        // private MazalDataSetTableAdapters.personTableAdapter personTableAdapter;
    }
}