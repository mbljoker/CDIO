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
using System.Collections;
using System.IO;

namespace TestEmgCV
{
    public partial class MaHoaFile : Form
    {
        string Path;
        List<LocationFolder> ArrLocation;
        protected MatKhau Pass;
        Hashtable IdLcFd;
        string File1=Application.StartupPath + "/SaveFolder/LocationFolder.txt";
        
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
            ArrLocation = new List<LocationFolder>();
            IdLcFd  = new Hashtable();
            InitializeComponent();
        }

        private void đổiMãPinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MaHoaFile_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            ArrLocation = RWFile.loadFlieLock();
            IdLcFd = RWFile.IdLtFd;
            dataGridView1.DataSource = listToDataTable(ArrLocation);
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            
            
           
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
            StreamWriter SW = new StreamWriter(Application.StartupPath + "/SaveFolder/LocationFolder.txt", true, Encoding.Unicode);
            FolderBrowserDialog fB = new FolderBrowserDialog();
            if (fB.ShowDialog() == DialogResult.OK)
            {
                Path = fB.SelectedPath;
                //Chuẩn : Tên File|Thuộc Tính File | Địa chỉ Lock File|KeyLock| Trạng Thái|Tên File
                if (IdLcFd.ContainsKey(Path) == false)
                {
                    LocationFolder tam = new LocationFolder();
                    string[] arrStr = Path.Split('\\');
                    tam.setNameF(arrStr[arrStr.Length-1]);
                    tam.setPathLocationFolder(Path);
                    //tam.setKeyLock(true);Chưa thêm vào
                    //tam.setPathLocationFolderLock();
                    tam.setFileFolder(false);
                    tam.setStatus(true);
                    string s = Path + "|" + "1|" + tam.getPathLocationFolderLock() + "|"
                                + tam.getKeyLock() + "|" + "1" + "|" + tam.getNameF();
                    SW.Write(s + "\n");
                    ArrLocation.Add(tam);
                    IdLcFd.Add(Path, 1);
                    SW.Close();

                }
                else
                {
                    MessageBox.Show("File " + Path+ " đã có !");
                }
                dataGridView1.DataSource = listToDataTable(ArrLocation);
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

                dtTam.Rows.Add(list[i].getNameF(),list[i].getStatus()==true?"Lock":"Unlock");
              
                
            }
         
            return dtTam;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Multiselect = true;
            if (oFD.ShowDialog() == DialogResult.OK)
            {

                using(StreamWriter SW = new StreamWriter(Application.StartupPath + "/SaveFolder/LocationFolder.txt", true, Encoding.Unicode))
                {
                    string[] fileNames = oFD.FileNames;
                    string[] safeFileNames = oFD.SafeFileNames;
                    //Chuẩn : Tên File|Thuộc Tính File | Địa chỉ Lock File|KeyLock| Trạng Thái|Tên File
                    for (int i = 0; i < fileNames.Length; i++)
                    {
                        if (IdLcFd.ContainsKey(fileNames[i]) == false)
                        {
                            LocationFolder tam = new LocationFolder();
                            tam.setNameF(safeFileNames[i]);
                            tam.setPathLocationFolder(fileNames[i]);
                            //tam.setKeyLock(true);Chưa thêm vào
                            //tam.setPathLocationFolderLock();
                            tam.setFileFolder(false);
                            tam.setStatus(true);
                            string s = fileNames[i] + "|" + "0|" + tam.getPathLocationFolderLock() + "|"
                                        + tam.getKeyLock() + "|" + "1" + "|" + tam.getNameF();
                            SW.Write(s + "\n");
                            ArrLocation.Add(tam);
                            IdLcFd.Add(fileNames[i], 1);


                        }
                        else
                        {
                            MessageBox.Show("File " + safeFileNames[i] + " đã có !");
                        }


                    }
                    SW.Close();
                }
               
                dataGridView1.DataSource = listToDataTable(ArrLocation);
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
               
                RWFile.saveFile(File1, null, true);
                if (dataGridView1.CurrentRow.Index == 0)
                {
                    ArrLocation = new List<LocationFolder>();
                }
                else
                {
                    ArrLocation.RemoveAt(dataGridView1.CurrentRow.Index);
                    foreach (LocationFolder tam in ArrLocation)
                    {
                        RWFile.saveFile(File1, tam, false);
                    }

                }
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                MessageBox.Show("Xóa thành Công !");
            }
            

        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString());
           
            if (e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].Cells[0].Selected = true;
                dataGridView1.Rows[e.RowIndex].Selected=true;
                if (dataGridView1.Rows[e.RowIndex].Cells[1].Value=="Lock")
                {
                    khóaToolStripMenuItem.Visible = false;
                    mởKhóaToolStripMenuItem.Visible = true;
                  
                }
                else
                {
                    khóaToolStripMenuItem.Visible = true;
                    mởKhóaToolStripMenuItem.Visible = false;
                }
                
            }
           
        }

        private void mởKhóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = "UnLock";
            ArrLocation[dataGridView1.CurrentRow.Index].setStatus(false);
            RWFile.saveFile(File1, null, true);
            foreach (LocationFolder tam in ArrLocation)
            {
                RWFile.saveFile(File1, tam, false);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void khóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value= "Lock";
            ArrLocation[dataGridView1.CurrentRow.Index].setStatus(true);
            RWFile.saveFile(File1, null, true);
            foreach (LocationFolder tam in ArrLocation)
            {
                RWFile.saveFile(File1, tam, false);
            }
        }
    }
}
