using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEmgCV
{
    class LockAndUnlock
    {
        public const string Key = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
        public const string FilePass="a1291gv.text";
        static public MatKhau Pass=new MatKhau();
        static DirectoryInfo d;
        /// <summary>
        /// Tạo file Xác thực
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static public bool createFile(string path)
        {
            try
            {
                //Tạo file Xác thực
                File.Create(path+"\\"+FilePass).Close();
                using (StreamWriter SW = new StreamWriter(path + "\\" + FilePass))
                {
                    SW.Write(Pass.getPassWord());
                    SW.Dispose();
                    SW.Close();
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
           
        }
        /// <summary>
        /// Thực hiên khóa Folder
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static public string  lockFolder(string path)
        {
            d = new DirectoryInfo(path);
            string selectedpath = d.Parent.FullName + d.Name;
            //Tạo file bên trong Folder để khi unlock tiến hành xác thực
            if (createFile(path) == false)
            {
                MessageBox.Show("Không tạo đc file !");
                return null;
            }
            // Khóa  Folder
            string str;
            if (!d.Root.Equals(d.Parent.FullName))  str=d.Parent.FullName + "\\" + d.Name + Key;
            else str=d.Parent.FullName + d.Name + Key;
            d.MoveTo(str);
            d.Attributes = FileAttributes.Hidden;
            return str;
            
        }
        /// <summary>
        /// Mở khóa folder
        /// </summary>
        /// <returns></returns>

        static public string unlockFoder(string path,string pass)
        {
            string str=null;
            //So sánh Pass lưu trong thư mục bị lock sau đó mở khóa, đúng trả về chuỗi sai trả về null
            if (pass==returnPass(path) )
            {
                d = new DirectoryInfo(path);
                File.Delete(path + "\\" + FilePass);
                str = path.Substring(0, path.LastIndexOf("."));
                d.MoveTo(str);
                d.Attributes = FileAttributes.Normal;
                d.Parent.Refresh();
            }
            return str;
          
            
        }
        /// <summary>
        /// Đọc Pass từ file bị lock
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static string returnPass(string path)
        {
            string str;
            try
            {
                using (StreamReader SR = new StreamReader(path + "\\" + FilePass))
                {
                    str = SR.ReadLine();
                }
                return str;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
    }
}
