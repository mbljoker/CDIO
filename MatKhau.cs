using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TestEmgCV
{
    public class MatKhau
    {
        public MatKhau()
        {
            loadPass();
        }
        protected string PassWord;
        /// <summary>
        /// Lưu Pass
        /// </summary>
        /// <param name="Pass"></param>
        /// <returns></returns>
        public bool SavePass(string Pass)
        {
            try
            {
                Pass = getMD5(Pass);
                ///Thêm cơ sở dữ liệu vào sau
                Pass = PassWord;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Thêm Vào");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Mã Hóa MD5
        /// </summary>
        /// <param name="Pass"></param>
        /// <returns></returns>
        public string getMD5(string Pass)
        {
            String Crypt = "";
            Byte[] Buffer = System.Text.Encoding.UTF8.GetBytes(Pass);
            System.Security.Cryptography.MD5CryptoServiceProvider MD5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            Buffer = MD5.ComputeHash(Buffer);
            foreach (Byte b in Buffer)
            {
                Crypt += b.ToString("x2");
            }
            return Crypt;
        }

        /// <summary>
        /// Kiểm Tra Mat Khau
        /// </summary>
        /// <param name="Pass"></param>
        /// <returns></returns>
        public bool Check(string Pass)
        {
            if (loadPass() == true)
            {
                Pass = getMD5(Pass);
                return Pass == PassWord;
            }
            return false;
            
        }

        bool loadPass()
        {
            try{
                //Thêm cơ sở dữ liệu vào sau
                PassWord = "e10adc3949ba59abbe56e057f20f883e";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
    }
}
