namespace FB_Analyze
{
    partial class Analyze
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPostNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.dataGridViewAnalyze = new System.Windows.Forms.DataGridView();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCmtCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalyze)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPostNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAnalyze);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBoxPostNum
            // 
            this.textBoxPostNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPostNum.Location = new System.Drawing.Point(910, 23);
            this.textBoxPostNum.Name = "textBoxPostNum";
            this.textBoxPostNum.Size = new System.Drawing.Size(74, 26);
            this.textBoxPostNum.TabIndex = 2;
            this.textBoxPostNum.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(857, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "POST";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(6, 19);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(92, 30);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Text = "ANALYZE";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.dataGridViewAnalyze);
            this.groupBoxData.Location = new System.Drawing.Point(12, 81);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(984, 468);
            this.groupBoxData.TabIndex = 1;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Data";
            // 
            // dataGridViewAnalyze
            // 
            this.dataGridViewAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAnalyze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnalyze.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colPost,
            this.colLink,
            this.colPic,
            this.colCmtCnt,
            this.colLike,
            this.colShare});
            this.dataGridViewAnalyze.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewAnalyze.Name = "dataGridViewAnalyze";
            this.dataGridViewAnalyze.Size = new System.Drawing.Size(972, 443);
            this.dataGridViewAnalyze.TabIndex = 0;
            // 
            // colNum
            // 
            this.colNum.HeaderText = "SEQ";
            this.colNum.Name = "colNum";
            // 
            // colPost
            // 
            this.colPost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPost.HeaderText = "STATUS";
            this.colPost.Name = "colPost";
            this.colPost.ReadOnly = true;
            // 
            // colLink
            // 
            this.colLink.HeaderText = "LINK";
            this.colLink.Name = "colLink";
            // 
            // colPic
            // 
            this.colPic.HeaderText = "PICTURE";
            this.colPic.Name = "colPic";
            // 
            // colCmtCnt
            // 
            this.colCmtCnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCmtCnt.HeaderText = "COMMENTS";
            this.colCmtCnt.Name = "colCmtCnt";
            this.colCmtCnt.ReadOnly = true;
            // 
            // colLike
            // 
            this.colLike.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLike.HeaderText = "LIKES";
            this.colLike.Name = "colLike";
            this.colLike.ReadOnly = true;
            // 
            // colShare
            // 
            this.colShare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colShare.HeaderText = "SHARES";
            this.colShare.Name = "colShare";
            // 
            // Analyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.groupBox1);
            this.Name = "Analyze";
            this.Text = "Analyze";
            this.Load += new System.EventHandler(this.Analyze_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnalyze)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.DataGridView dataGridViewAnalyze;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.TextBox textBoxPostNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCmtCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLike;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShare;
    }
}