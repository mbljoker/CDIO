using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEmgCV
{
    public partial class MaHoaFile : Form
    {
        string Path;
        List<LocationFolder> ArrLocation;
        protected MatKhau Pass;
        public MatKhau getPass()
        {
            return Pass;
        }
        public void setPass(MatKhau Pass)
        {
            this.Pass = Pass;
        }
        public MaHoaFile()
        {
            Pass = new MatKhau();
            InitializeComponent();
        }

        private void đổiMãPinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MaHoaFile_Load(object sender, EventArgs e)
        {
            LocationFolder tam = new LocationFolder();
            ArrLocation=tam.loadFlieLock();
            dataGridView1.DataSource = listToDataTable(ArrLocation);
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void đổiMãPinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DoiMatKhau ChangePass = new DoiMatKhau();
            ChangePass.setPass(Pass);
            if (ChangePass.ShowDialog() == DialogResult.OK)
            {
                Pass = ChangePass.getPass();
            }
            ChangePass.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đổiẢnhĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiAnh ChangePic = new DoiAnh();
            ChangePic.ShowDialog();
        }

        private void btn_AddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fB = new FolderBrowserDialog();
            if (fB.ShowDialog() == DialogResult.OK)
            {
                Path = fB.SelectedPath;
            }
        }

        public DataTable listToDataTable(List<LocationFolder> list)
        {
            DataTable dtTam = new DataTable();
            dtTam.Columns.Add("Tên File",typeof(string));
            dtTam.Columns.Add("Trạng Thái", typeof(string));
           // MessageBox.Show(""+ list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                dtTam.Rows.Add(list[i].getPathLocationFolder(),list[i].getStatus()==true?"Lock":"Unlock");
                
            }
            return dtTam;
        }
    }
}
