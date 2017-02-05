namespace TestEmgCV
{
    partial class DoiMatKhau
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
            this.lbl_MKC = new System.Windows.Forms.Label();
            this.tbx_PasswordOld = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Password1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_MKC
            // 
            this.lbl_MKC.AutoSize = true;
            this.lbl_MKC.Location = new System.Drawing.Point(12, 26);
            this.lbl_MKC.Name = "lbl_MKC";
            this.lbl_MKC.Size = new System.Drawing.Size(75, 13);
            this.lbl_MKC.TabIndex = 0;
            this.lbl_MKC.Text = "Mật Khẩu Cũ :";
            // 
            // tbx_PasswordOld
            // 
            this.tbx_PasswordOld.Location = new System.Drawing.Point(87, 23);
            this.tbx_PasswordOld.Name = "tbx_PasswordOld";
            this.tbx_PasswordOld.Size = new System.Drawing.Size(100, 20);
            this.tbx_PasswordOld.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(8, 59);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(79, 13);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Mật Khẩu Mới :";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // lbl_Password1
            // 
            this.lbl_Password1.AutoSize = true;
            this.lbl_Password1.Location = new System.Drawing.Point(31, 93);
            this.lbl_Password1.Name = "lbl_Password1";
            this.lbl_Password1.Size = new System.Drawing.Size(56, 13);
            this.lbl_Password1.TabIndex = 4;
            this.lbl_Password1.Text = "Nhập Lại :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 188);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_Password1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.tbx_PasswordOld);
            this.Controls.Add(this.lbl_MKC);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MKC;
        private System.Windows.Forms.TextBox tbx_PasswordOld;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_Password1;
        private System.Windows.Forms.Button button1;
    }
}