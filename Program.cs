using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEmgCV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       
        [STAThread]
        
        static void Main()
        {
            // Phần mềm chúng nếu đóng gói sẽ đóng lun cả các folder và file  
            string key = "11112323a2";
            RegistryKey regKey = Registry.CurrentUser;
            try
            {

                if (regKey.OpenSubKey("Software\\LockFolder") == null)
                {
                    regKey = regKey.CreateSubKey("Software\\LockFolder");
                    regKey.SetValue("CatDat", 1);
                    regKey.Close();
                    if (Directory.Exists(Application.StartupPath + "\\SaveFolder"
                                            + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"))
                    {
                        DirectoryInfo d = new DirectoryInfo(Application.StartupPath
                                                                 + "\\SaveFolder" + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}");
                        d.Attributes = FileAttributes.Normal;
                        d.Delete();

                    }


                    #region SaveFolder
                    if (!Directory.Exists(Application.StartupPath + "\\SaveFolder"))
                    {
                        Directory.CreateDirectory(Application.StartupPath + "\\SaveFolder");
                    }
                    if (!File.Exists(Application.StartupPath + "\\SaveFolder\\LocationFolder.txt"))
                    {
                        File.Create(Application.StartupPath + "\\SaveFolder\\LocationFolder.txt").Close();
                    }
                    if (!File.Exists(Application.StartupPath + "\\SaveFolder\\Pass.txt"))
                    {
                        File.Create(Application.StartupPath + "\\SaveFolder\\Pass.txt").Close();
                        using (StreamWriter SW = new StreamWriter(Application.StartupPath + "/SaveFolder/Pass.txt"))
                        {
                            SW.Write("e10adc3949ba59abbe56e057f20f883e");
                        }

                    }
                    if (!File.Exists(Application.StartupPath + "\\SaveFolder\\PassAnh.txt"))
                    {
                        File.Create(Application.StartupPath + "\\SaveFolder\\PassAnh.txt").Close();

                    }
                    #endregion

                    #region SaveFolder

                    if (!File.Exists(Application.StartupPath + "\\SaveFolder\\Data.txt"))
                    {
                        File.Create(Application.StartupPath + "\\SaveFolder\\Data.txt").Close();

                    }
                    #endregion

                    LockAndUnlock.lockFolder(Application.StartupPath + "\\SaveFolder", key);


                }
                
                
             
              //Mở khóa folder chứ thông tin
              
              LockAndUnlock.unlockFoder(Application.StartupPath + "\\SaveFolder" + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", key);
              if (!File.Exists(Application.StartupPath + "\\SaveFolder\\Pass.txt"))
              {
                  File.Create(Application.StartupPath + "\\SaveFolder\\Pass.txt").Close();
                  using (StreamWriter SW = new StreamWriter(Application.StartupPath + "/SaveFolder/Pass.txt"))
                  {
                      SW.Write("e10adc3949ba59abbe56e057f20f883e");
                  }

              }
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Không thể khởi động chương trình !");
                return;
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MaHoaFile());
            //MessageBox.Show("Vao Đây");
            identifyFolder Login = new identifyFolder();
            if (Login.ShowDialog() == DialogResult.OK)
            {         
                MaHoaFile FormChinh = new MaHoaFile();
                FormChinh.ShowDialog();
                //FormChinh.Dispose();
           
            }

            try
            {
                
                LockAndUnlock.lockFolder(Application.StartupPath + "\\SaveFolder", key);
            }
            catch
            {
                //MessageBox.Show("Lỗi Đóng FROM!");
            }
            ///Khóa lại 
            
           // MessageBox.Show("Keets thuc");
            ///test lock Folder
            /*
            string str1=null;
            LockAndUnlock.Pass.loadPass();
            str1=LockAndUnlock.lockFolder("C:\\Users\\LBMJoker\\Desktop\\Test");
            if(str1!=null) MessageBox.Show(str1);
            string str = LockAndUnlock.Pass.getMD5("123456");
            if (LockAndUnlock.unlockFoder(str1,str)!=null)
            {
                MessageBox.Show("Lock Thành công !");
            }
           */
            ///Test Lock File
            /*
            string st=LockAndUnlock.LockFile("C:\\Users\\LBMJoker\\Desktop\\aaaaa.txt", "aaaaa.txt", "123456");
            MessageBox.Show(st);
            string st1 = LockAndUnlock.unlockFile(st, "aaaaa.txt", "123456");
           */

        }
    }
}
