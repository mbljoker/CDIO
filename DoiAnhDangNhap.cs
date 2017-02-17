using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.Cuda;
using TestEmgCV;
using System.IO;
using System.Collections;

namespace TestEmgCV
{
    public partial class DoiAnhDangNhap : Form
    {
        private Capture capture;
        private bool captureInProgress; 
        public DoiAnhDangNhap()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            try
            {
                capture = new Capture(CaptureType.Stereo);
                capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

       
        private void ProcessFrame(object sender, EventArgs arg)
        {

            Image<Gray, byte> frame;
            frame = capture.QuerySmallFrame().ToImage<Gray, byte>();
            imageBox2.Image = frame;
        }
        

        private void button3_Click_1(object sender, EventArgs e)
        {
         
            capture.Pause();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            capture.Start();
        }

        private void DoiAnhDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void imageBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
