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
    public partial class NhanDien : Form
    {
        private Capture capture = null;
        private Capture mh1 = null;
        private bool captureInProgress; 
        public NhanDien()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            try
            {
                capture = new Capture();
                mh1 = new Capture();
                mh1.ImageGrabbed += mh1_ImageGrabbed;
                capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void mh1_ImageGrabbed(object sender, EventArgs e)
        {
            Mat frame = new Mat();
            capture.Retrieve(frame, 0);
            imageBox2.Image = frame;
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            Mat frame = new Mat();
            capture.Retrieve(frame, 0);
            Mat image = frame; 
            long detectionTime;
            List<Rectangle> faces = new List<Rectangle>();
            List<Rectangle> eyes = new List<Rectangle>();
            bool tryUseCuda = false;
            bool tryUseOpenCL = true;
 
 
            DetectFace.Detect(
              image, "haarcascade_frontalface_default.xml", "haarcascade_eye.xml",
              faces, eyes,
              tryUseCuda,
              tryUseOpenCL,
              out detectionTime);

            foreach (Rectangle face in faces)
            {
                CvInvoke.Rectangle(image, face, new Bgr(Color.Yellow).MCvScalar, 3);
                Bitmap c = frame.Bitmap;
                Bitmap bmp = new Bitmap(face.Size.Width, face.Size.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(c, 0, 0, face, GraphicsUnit.Pixel);
            }

            foreach (Rectangle eye in eyes)
            {
                CvInvoke.Rectangle(image, eye, new Bgr(Color.Green).MCvScalar, 2);
                Bitmap c = frame.Bitmap;
                Bitmap bmp = new Bitmap(eye.Size.Width, eye.Size.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(c, 0, 0, eye, GraphicsUnit.Pixel);
            }
            imageBox1.Image = frame;
 
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            mh1.Start();
            capture.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart.Text = "Start";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            mh1.Pause();
            capture.Pause();
            
        }

       
 
 
    }
}