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
            string key = "11112323a2";  
    
            RegistryKey regKey = Registry.CurrentUser;
            try
            {
                if (regKey.OpenSubKey("Software\\LockFolder") == null)
                {
                    regKey = regKey.CreateSubKey("Software\\LockFolder");
                    regKey.SetValue("CatDat", 1);
                    regKey.Close();
                    
                   
                }
               
              //Mở khóa folder chứ thông tin 
              LockAndUnlock.unlockFoder(Application.StartupPath + "\\SaveFolder" + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", key);
              LockAndUnlock.unlockFoder(Application.StartupPath + "\\ImgTrain" + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", key);
                
                
            }
            catch
            {
                MessageBox.Show("Không thể khởi động chương trình !");
                return;
            }
            
             
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MaHoaFile());
            identifyFolder Login = new identifyFolder();
            if (Login.ShowDialog() == DialogResult.OK)
            {         
                MaHoaFile FormChinh = new MaHoaFile();
                FormChinh.ShowDialog();
            }
            try
            {
                LockAndUnlock.lockFolder(Application.StartupPath + "\\SaveFolder", key);
                LockAndUnlock.lockFolder(Application.StartupPath + "\\ImgTrain", key);
            }
            catch
            {
                MessageBox.Show("Lỗi Đóng file !");
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
