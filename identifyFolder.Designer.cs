namespace TestEmgCV
{
    partial class identifyFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(identifyFolder));
            this.groupBox1_Camera = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.groupBoxPass = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbxPassWord = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1_Camera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1_Camera
            // 
            this.groupBox1_Camera.Controls.Add(this.pictureBox1);
            this.groupBox1_Camera.Location = new System.Drawing.Point(12, 12);
            this.groupBox1_Camera.Name = "groupBox1_Camera";
            this.groupBox1_Camera.Size = new System.Drawing.Size(480, 360);
            this.groupBox1_Camera.TabIndex = 3;
            this.groupBox1_Camera.TabStop = false;
            this.groupBox1_Camera.Text = "Camera";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(219, 379);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 4;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(260, 379);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(0, 13);
            this.lblIndex.TabIndex = 5;
            // 
            // groupBoxPass
            // 
            this.groupBoxPass.Controls.Add(this.btnEnter);
            this.groupBoxPass.Controls.Add(this.tbxPassWord);
            this.groupBoxPass.Location = new System.Drawing.Point(18, 379);
            this.groupBoxPass.Name = "groupBoxPass";
            this.groupBoxPass.Size = new System.Drawing.Size(181, 48);
            this.groupBoxPass.TabIndex = 6;
            this.groupBoxPass.TabStop = false;
            this.groupBoxPass.Text = "Mật Khẩu :";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(113, 19);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(62, 20);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbxPassWord
            // 
            this.tbxPassWord.Location = new System.Drawing.Point(6, 19);
            this.tbxPassWord.Name = "tbxPassWord";
            this.tbxPassWord.Size = new System.Drawing.Size(100, 20);
            this.tbxPassWord.TabIndex = 0;
            this.tbxPassWord.UseSystemPasswordChar = true;
            this.tbxPassWord.TextChanged += new System.EventHandler(this.tbxPassWord_TextChanged);
            this.tbxPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPassWord_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // identifyFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(505, 442);
            this.Controls.Add(this.groupBoxPass);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBox1_Camera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(521, 481);
            this.MinimumSize = new System.Drawing.Size(521, 481);
            this.Name = "identifyFolder";
            this.Text = "FolderLock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.identifyFolder_FormClosing);
            this.Load += new System.EventHandler(this.identifyFolder_Load);
            this.groupBox1_Camera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxPass.ResumeLayout(false);
            this.groupBoxPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1_Camera;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.GroupBox groupBoxPass;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbxPassWord;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}