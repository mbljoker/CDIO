using System;
using System.Collections.Generic;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MaHoaFile());
           /* identifyFolder Login = new identifyFolder();
            if (Login.ShowDialog() == DialogResult.OK)
            {         
                MaHoaFile FormChinh = new MaHoaFile();
                FormChinh.ShowDialog();
            }
            */
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

           
        }
    }
}
