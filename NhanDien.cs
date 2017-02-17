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
        string name;
        Image<Gray, byte> frame;
        Image<Gray, byte>  Result;
        Image<Bgr, byte> CurrentFrame;
        Image<Gray, byte> GrayFrame;
        private Capture capture = null;
        private bool captureInProgress;
        private int NumLabels;
        private int ContTrain, t;
        Image<Gray, byte> result;
        Image<Gray, byte> TrainedFace;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        Classifier_Train Eigen_Recog = new Classifier_Train();
        public CascadeClassifier Face = new CascadeClassifier(Application.StartupPath + "/haarcascade_frontalface_default.xml");
        

        /// <summary>
        /// 
        /// </summary>
        public NhanDien()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            try
            {
                // Khởi tạo kiểu Nhận dạng
                InitializeComponent();
                if (Eigen_Recog.IsTrained)
                {
                    MessageBox.Show("Tải ảnh huấn luyện");
                }
                else
                {
                    MessageBox.Show("Không tải được ảnh huấn luyện");
                }
                //Kiểu Nhận Diện
                Eigen_Recog.Recognizer_Type = "EMGU.CV.EigenFaceRecognizer";
                //Giatri
                Eigen_Recog.Set_Eigen_Threshold = 3500;
                
                capture = new Capture();
                capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }



        void Frame(object sender, EventArgs e)
        {
            try
            {
                CurrentFrame = capture.QueryFrame().ToImage<Bgr, byte>().Resize(720, 480, Emgu.CV.CvEnum.Inter.Cubic);
            }
            catch (Exception ex)
            {

            }
            //CHuyển về Gray
            if (CurrentFrame != null)
            {
                GrayFrame = CurrentFrame.Convert<Gray, Byte>();
                //Lấy Img Ảnh sau khi defect
                Rectangle[] facesDetected =Face.DetectMultiScale(GrayFrame, 1.2, 10, new Size(50, 50), Size.Empty);

                //Lấy từng mặt đối tượng 
                for (int i = 0; i < facesDetected.Length; i++)// (Duyệt từng đối tượng)
                {
                    //Căn chỉnh hình            
                    // facesDetected[i].X += (int)(facesDetected[i].Height * 0.15);
                    // facesDetected[i].Y += (int)(facesDetected[i].Width * 0.22);
                    // facesDetected[i].Height -= (int)(facesDetected[i].Height * 0.3);
                    // facesDetected[i].Width -= (int)(facesDetected[i].Width * 0.35);

                    Result = CurrentFrame.Copy(facesDetected[i]).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
                    Result._EqualizeHist();

                    //Vẽ lên ảnh 
                    CurrentFrame.Draw(facesDetected[i], new Bgr(Color.Yellow), 2);


                }

                imageBox1.Image = CurrentFrame;


            }
        }


        
        private void ProcessFrame(object sender, EventArgs arg)
        {

            Mat frame=new Mat();
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
                //Bitmap c = frame.Bitmap;
                //Bitmap bmp = new Bitmap(face.Size.Width, face.Size.Height);
                //Graphics g = Graphics.FromImage(bmp);
                //g.DrawImage(c, 0, 0, face, GraphicsUnit.Pixel);
                
            }
            
///////////////////////* xử lý 
            for (int i = 0; i < faces.Count; i++)// (Rectangle face_found in facesDetected)
            {
                //This will focus in on the face from the haar results its not perfect but it will remove a majoriy
                //of the background noise

                Rectangle tam = faces[i];
                tam.X += (int)(tam.Height * 0.15);
                tam.Y += (int)(tam.Width * 0.22);
                tam.Height -= (int)(tam.Height * 0.3);
                tam.Width -= (int)(tam.Width * 0.35);

                result = frame.ToImage<Gray,byte>().Copy(tam).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
                result._EqualizeHist();
                //draw the face detected in the 0th (gray) channel with blue color
                //frame.ToImage<Bgr, byte>().Draw(tam, new Bgr(Color.Red), 2);
                
               
                if (Eigen_Recog.IsTrained)
                {
                    name = Eigen_Recog.Recognise(result);
                    int match_value = (int)Eigen_Recog.Get_Eigen_Distance;
                    //string name1 = name + "";
                   MessageBox.Show(name);
                    label1.Text = name;
                    //Draw the label for each face detected and recognized
                    //(frame.ToImage<Bgr, byte>()).Draw(name + "1", new Point(tam.X - 2, tam.Y - 2), FontFace.HersheyComplex, 20, new Bgr(Color.LightGreen));
                    //ADD_Face_Found(result, name, match_value);
                    faces[i] = tam;
                     
                }
                
            }
//////////////////////////
            imageBox1.Image = frame;
            //MessageBox.Show(name);  
 
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            capture.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            capture.Start(); 
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
            capture.Pause();
            
        }
    }
}