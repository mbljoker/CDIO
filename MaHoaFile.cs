using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEmgCV
{
    public partial class MaHoaFile : Form
    {
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
    }
}
