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
    public partial class NhapTen : Form
    {
        public String Ten;
        public NhapTen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ten = textBox1.Text;
            if (Ten.Length < 1 || Ten == null)
            {
                button2.PerformClick();

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void NhapTen_Load(object sender, EventArgs e)
        {

        }
    }
}
