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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đổiMãPinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMãPinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiẢnhĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AddFile = new System.Windows.Forms.Button();
            this.btn_AddFolder = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởKhóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenFile,
            this.TrangThai});
            this.dataGridView1.Location = new System.Drawing.Point(12, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(451, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseMove);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            // 
            // TenFile
            // 
            this.TenFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenFile.DataPropertyName = "Tên File";
            this.TenFile.HeaderText = "Tên File";
            this.TenFile.Name = "TenFile";
            this.TenFile.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThai.DataPropertyName = "Trạng Thái";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.đổiẢnhĐăngNhậpToolStripMenuItem,
            this.thoátToolStripMenuItem});
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
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
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
            this.btn_AddFile.Click += new System.EventHandler(this.btn_AddFile_Click);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.mởKhóaToolStripMenuItem,
            this.khóaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 114);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::TestEmgCV.Properties.Resources.Xoa;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // khóaToolStripMenuItem
            // 
            this.khóaToolStripMenuItem.Image = global::TestEmgCV.Properties.Resources.Khoa;
            this.khóaToolStripMenuItem.Name = "khóaToolStripMenuItem";
            this.khóaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.khóaToolStripMenuItem.Text = "Khóa";
            this.khóaToolStripMenuItem.Click += new System.EventHandler(this.khóaToolStripMenuItem_Click);
            // 
            // mởKhóaToolStripMenuItem
            // 
            this.mởKhóaToolStripMenuItem.Image = global::TestEmgCV.Properties.Resources.MoKhoa;
            this.mởKhóaToolStripMenuItem.Name = "mởKhóaToolStripMenuItem";
            this.mởKhóaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.mởKhóaToolStripMenuItem.Text = "Mở Khóa";
            this.mởKhóaToolStripMenuItem.Click += new System.EventHandler(this.mởKhóaToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.openToolStripMenuItem.Text = "Open";
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
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.ToolStripMenuItem khóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởKhóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}