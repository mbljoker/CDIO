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
            this.groupBox1_Camera = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.groupBoxPass = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbxPassWord = new System.Windows.Forms.TextBox();
            this.picCamera = new Emgu.CV.UI.ImageBox();
            this.groupBox1_Camera.SuspendLayout();
            this.groupBoxPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1_Camera
            // 
            this.groupBox1_Camera.Controls.Add(this.picCamera);
            this.groupBox1_Camera.Location = new System.Drawing.Point(12, 12);
            this.groupBox1_Camera.Name = "groupBox1_Camera";
            this.groupBox1_Camera.Size = new System.Drawing.Size(480, 360);
            this.groupBox1_Camera.TabIndex = 3;
            this.groupBox1_Camera.TabStop = false;
            this.groupBox1_Camera.Text = "Camera";
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
            // picCamera
            // 
            this.picCamera.Location = new System.Drawing.Point(6, 19);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(468, 335);
            this.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCamera.TabIndex = 2;
            this.picCamera.TabStop = false;
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(521, 481);
            this.MinimumSize = new System.Drawing.Size(521, 481);
            this.Name = "identifyFolder";
            this.Text = "identifyFolder";
            this.Load += new System.EventHandler(this.identifyFolder_Load);
            this.groupBox1_Camera.ResumeLayout(false);
            this.groupBoxPass.ResumeLayout(false);
            this.groupBoxPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox picCamera;
        private System.Windows.Forms.GroupBox groupBox1_Camera;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.GroupBox groupBoxPass;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbxPassWord;
    }
}