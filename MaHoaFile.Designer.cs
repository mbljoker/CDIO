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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đổiMãPinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMãPinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiẢnhĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AddFolder = new System.Windows.Forms.Button();
            this.btn_AddFile = new System.Windows.Forms.Button();
            this.mởKhóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMãPinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.mởKhóaToolStripMenuItem,
            this.khóaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 92);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.openToolStripMenuItem.Text = "Mở";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // btn_AddFolder
            // 
            this.btn_AddFolder.BackgroundImage = global::TestEmgCV.Properties.Resources.Folder_Blue_Add;
            this.btn_AddFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddFolder.Location = new System.Drawing.Point(63, 36);
            this.btn_AddFolder.Name = "btn_AddFolder";
            this.btn_AddFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_AddFolder.Size = new System.Drawing.Size(43, 39);
            this.btn_AddFolder.TabIndex = 3;
            this.btn_AddFolder.UseVisualStyleBackColor = true;
            this.btn_AddFolder.Click += new System.EventHandler(this.btn_AddFolder_Click);
            // 
            // btn_AddFile
            // 
            this.btn_AddFile.BackgroundImage = global::TestEmgCV.Properties.Resources.Creative_Freedom_Shimmer_Document_Add1;
            this.btn_AddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddFile.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_AddFile.Location = new System.Drawing.Point(12, 36);
            this.btn_AddFile.Name = "btn_AddFile";
            this.btn_AddFile.Size = new System.Drawing.Size(45, 39);
            this.btn_AddFile.TabIndex = 2;
            this.btn_AddFile.UseVisualStyleBackColor = true;
            this.btn_AddFile.Click += new System.EventHandler(this.btn_AddFile_Click);
            // 
            // mởKhóaToolStripMenuItem
            // 
            this.mởKhóaToolStripMenuItem.Image = global::TestEmgCV.Properties.Resources.MoKhoa;
            this.mởKhóaToolStripMenuItem.Name = "mởKhóaToolStripMenuItem";
            this.mởKhóaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.mởKhóaToolStripMenuItem.Text = "Mở Khóa";
            this.mởKhóaToolStripMenuItem.Click += new System.EventHandler(this.mởKhóaToolStripMenuItem_Click);
            // 
            // khóaToolStripMenuItem
            // 
            this.khóaToolStripMenuItem.Image = global::TestEmgCV.Properties.Resources.Khoa;
            this.khóaToolStripMenuItem.Name = "khóaToolStripMenuItem";
            this.khóaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.khóaToolStripMenuItem.Text = "Khóa";
            this.khóaToolStripMenuItem.Click += new System.EventHandler(this.khóaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::TestEmgCV.Properties.Resources.Xoa;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(165, 175);
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
            // TenFile
            // 
            this.TenFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenFile.DataPropertyName = "Tên File";
            this.TenFile.HeaderText = "Tên File";
            this.TenFile.Name = "TenFile";
            this.TenFile.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenFile,
            this.TrangThai});
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(451, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseMove);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            // 
            // MaHoaFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(475, 341);
            this.Controls.Add(this.btn_AddFolder);
            this.Controls.Add(this.btn_AddFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(491, 380);
            this.MinimumSize = new System.Drawing.Size(491, 380);
            this.Name = "MaHoaFile";
            this.Text = "Mã Hóa File";
            this.Load += new System.EventHandler(this.MaHoaFile_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiMãPinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMãPinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đổiẢnhĐăngNhậpToolStripMenuItem;
        private System.Windows.Forms.Button btn_AddFile;
        private System.Windows.Forms.Button btn_AddFolder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởKhóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
    }
}