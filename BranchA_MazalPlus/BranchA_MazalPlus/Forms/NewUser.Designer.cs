namespace BranchA_MazalPlus
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
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create new user";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(111, 99);
            this.Fname.Margin = new System.Windows.Forms.Padding(2);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(133, 20);
            this.Fname.TabIndex = 1;
            this.Fname.TextChanged += new System.EventHandler(this.Fname_TextChanged);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "person";
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(111, 131);
            this.Lname.Margin = new System.Windows.Forms.Padding(2);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(133, 20);
            this.Lname.TabIndex = 2;
            this.Lname.TextChanged += new System.EventHandler(this.Lname_TextChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(111, 162);
            this.ID.Margin = new System.Windows.Forms.Padding(2);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(133, 20);
            this.ID.TabIndex = 3;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(111, 193);
            this.Phone.Margin = new System.Windows.Forms.Padding(2);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(133, 20);
            this.Phone.TabIndex = 4;
            this.Phone.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "First name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(50, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "User Name:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(327, 99);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(133, 20);
            this.Email.TabIndex = 5;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Permission
            // 
            this.Permission.AutoSize = true;
            this.Permission.Location = new System.Drawing.Point(263, 131);
            this.Permission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Permission.Name = "Permission";
            this.Permission.Size = new System.Drawing.Size(60, 13);
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
            "Teaching_Assistant"});
            this.perm1.Location = new System.Drawing.Point(327, 131);
            this.perm1.Margin = new System.Windows.Forms.Padding(2);
            this.perm1.Name = "perm1";
            this.perm1.Size = new System.Drawing.Size(133, 21);
            this.perm1.TabIndex = 16;
            this.perm1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 438);
            this.Controls.Add(this.perm1);
            this.Controls.Add(this.Permission);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        // private MazalDataSetTableAdapters.personTableAdapter personTableAdapter;
    }
}