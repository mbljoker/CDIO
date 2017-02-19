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
    public partial class DoiMatKhau : Form
    {
        protected MatKhau Pass{get;set;}

        public MatKhau getPass()
        {
            return Pass;
        }
        public void setPass(MatKhau Pass)
        {
            this.Pass=Pass;
        }
        
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        
        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Thực hiện đổi mật khẩu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            if (Pass.Check(tbx_PasswordOld.Text) == true)
            {
                if (textBox1.Text == textBox2.Text)
                {
                    
                    Pass.SavePass(textBox2.Text);
                    MessageBox.Show("Thay đổi thành công !","Thông Báo");
                    DialogResult = DialogResult.OK;
                    this.Hide();
                }
                else
                {
                    lblThongBao.Text = "Mật khẩu mới không khớp !";
                }

            }
            else
            {
                lblThongBao.Text = "Mật Khẩu cũ không đúng !";
            }
        }
    }
}
