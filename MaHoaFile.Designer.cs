namespace TestEmgCV
{
    partial class MaHoaFile
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đổiMãPinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMãPinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiẢnhĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AddFile = new System.Windows.Forms.Button();
            this.btn_AddFolder = new System.Windows.Forms.Button();
            this.TenFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenFile,
            this.TrangThai});
            this.dataGridView1.Location = new System.Drawing.Point(12, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMãPinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // đổiMãPinToolStripMenuItem
            // 
            this.đổiMãPinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMãPinToolStripMenuItem1,
            this.đổiẢnhĐăngNhậpToolStripMenuItem});
            this.đổiMãPinToolStripMenuItem.Name = "đổiMãPinToolStripMenuItem";
            this.đổiMãPinToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.đổiMãPinToolStripMenuItem.Text = "Mật Khẩu";
            this.đổiMãPinToolStripMenuItem.Click += new System.EventHandler(this.đổiMãPinToolStripMenuItem_Click);
            // 
            // đổiMãPinToolStripMenuItem1
            // 
            this.đổiMãPinToolStripMenuItem1.Name = "đổiMãPinToolStripMenuItem1";
            this.đổiMãPinToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.đổiMãPinToolStripMenuItem1.Text = "Đổi Mật Khẩu";
            this.đổiMãPinToolStripMenuItem1.Click += new System.EventHandler(this.đổiMãPinToolStripMenuItem1_Click);
            // 
            // đổiẢnhĐăngNhậpToolStripMenuItem
            // 
            this.đổiẢnhĐăngNhậpToolStripMenuItem.Name = "đổiẢnhĐăngNhậpToolStripMenuItem";
            this.đổiẢnhĐăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đổiẢnhĐăngNhậpToolStripMenuItem.Text = "Đổi Ảnh Đăng Nhập";
            this.đổiẢnhĐăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đổiẢnhĐăngNhậpToolStripMenuItem_Click);
            // 
            // btn_AddFile
            // 
            this.btn_AddFile.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_AddFile.Location = new System.Drawing.Point(12, 27);
            this.btn_AddFile.Name = "btn_AddFile";
            this.btn_AddFile.Size = new System.Drawing.Size(68, 72);
            this.btn_AddFile.TabIndex = 2;
            this.btn_AddFile.Text = "Thêm File";
            this.btn_AddFile.UseVisualStyleBackColor = true;
            // 
            // btn_AddFolder
            // 
            this.btn_AddFolder.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_AddFolder.Location = new System.Drawing.Point(86, 27);
            this.btn_AddFolder.Name = "btn_AddFolder";
            this.btn_AddFolder.Size = new System.Drawing.Size(68, 72);
            this.btn_AddFolder.TabIndex = 3;
            this.btn_AddFolder.Text = "Thêm Folder";
            this.btn_AddFolder.UseVisualStyleBackColor = true;
            this.btn_AddFolder.Click += new System.EventHandler(this.btn_AddFolder_Click);
            // 
            // TenFile
            // 
            this.TenFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenFile.DataPropertyName = "Tên File";
            this.TenFile.HeaderText = "Tên File";
            this.TenFile.Name = "TenFile";
            this.TenFile.Width = 70;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TrangThai.DataPropertyName = "Trạng Thái";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 84;
            // 
            // MaHoaFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 368);
            this.Controls.Add(this.btn_AddFolder);
            this.Controls.Add(this.btn_AddFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MaHoaFile";
            this.Text = "Mã Hóa File";
            this.Load += new System.EventHandler(this.MaHoaFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiMãPinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMãPinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đổiẢnhĐăngNhậpToolStripMenuItem;
        private System.Windows.Forms.Button btn_AddFile;
        private System.Windows.Forms.Button btn_AddFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}