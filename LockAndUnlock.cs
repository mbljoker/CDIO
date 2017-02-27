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
        public const string Key = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";//Dùng để lock
        public const string FilePass="a1291gv.text";//File chứa mật khẩu lock
        //static public MatKhau Pass=new MatKhau();
        static DirectoryInfo d;
        static public string KT = "1";
        /// <summary>
        /// Tạo file Xác thực
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static public bool createFile(string path,string pass)
        {
            try
            {
                //Tạo file Xác thực
                File.Create(path+"\\"+FilePass).Close();
                using (StreamWriter SW = new StreamWriter(path + "\\" + FilePass))
                {
                    SW.Write(pass);
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
        static public string  lockFolder(string path,string pass)
        {
            d = new DirectoryInfo(path);
            string selectedpath = d.Parent.FullName + d.Name;
            //Tạo file bên trong Folder để khi unlock tiến hành xác thực
            if (createFile(path,pass) == false)
            {
                MessageBox.Show("Không tạo đc file !");
                return null;
            }
            // Khóa  Folder
            string str;
            if (!d.Root.Equals(d.Parent.FullName))  str=d.Parent.FullName + "\\" + d.Name + Key;
            else str=d.Parent.FullName + d.Name + Key;
            d.MoveTo(str);
            // Ẩn folder
            //d.Attributes = FileAttributes.Hidden;
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
                ///Mở Ẩn
                //d.Attributes = FileAttributes.Normal;
                d = new DirectoryInfo(path);
                File.Delete(path + "\\" + FilePass);
                //lấy về địa chỉ file cũ
                str = path.Substring(0, path.LastIndexOf("."));
                // Di chuyển về vị trí cũ của file 
                d.MoveTo(str);
                
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
       
        /// <summary>
        /// Lock file ! Chuyển file vào folder rồi lock được trả về chuỗi , sai trả về null
        /// </summary>
        /// <param name="path"></param>
        /// <param name="filename"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        static public string LockFile(string path,string filename,string pass)
        {
            try
            {
                //Lấy thư mục cha 
                DirectoryInfo di = new DirectoryInfo(path);
                string strP = di.Parent.FullName + "\\" + filename.Replace(".", KT);
                //Kiểm tra thư mục chưa tạo thì tạo 
                if (!Directory.Exists(strP))
                {
                    Directory.CreateDirectory(strP);
                }
                //Di chuyển file vào thư mục vừa tạo
                File.Move(path, strP + "\\" + filename);
                //thực hiện lock folder
                string strT = LockAndUnlock.lockFolder(strP, pass);
                return strT;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Unlock file ! Chuyển file vào folder rồi lock được trả về chuỗi , sai trả về null
        /// </summary>
        /// <param name="path"></param>
        /// <param name="filename"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        static public string unlockFile(string path, string filename, string pass)
        {
            try
            {
                //Mở folder file lock
                string strT = LockAndUnlock.unlockFoder(path, pass);
                DirectoryInfo di = new DirectoryInfo(path);
                //Chuyển file về vị trí cũ 
                MessageBox.Show(strT + "\\" + filename+"\n" +di.Parent.FullName + "\\" + filename);
                File.Move(strT + "\\" + filename, di.Parent.FullName + "\\" + filename);
                //Xóa folder tạm
                Directory.Delete(strT);
                return strT;
            }
            catch
            {
                return null;
            }
            
        }

    }
}
