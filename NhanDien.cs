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
        Font font = new System.Drawing.Font("Microsoft Sans Serif", 1.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Capture capture = null;
        private Capture mh1 = null;
        private bool captureInProgress;
        private int NumLabels;
        private int ContTrain, t;
        Image<Gray, byte> result;
        Image<Gray, byte> TrainedFace;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
       // private EigenObjectRecognizer.RecognitionResult name;
        public NhanDien()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;


            //
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/Anh/AnhLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;
                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/Anh/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //
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
          //  MCvAvgComp faceDetected=
        }
        private void button3_Click(object sender, EventArgs e)
        {
            mh1.Pause();
            capture.Pause();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Đào tạo truy cập khuôn mặt 
                ContTrain = ContTrain + 1;
                //Lấy ảnh từ video
                Mat img1 = new Mat();
                capture.Retrieve(img1, 0);
                //img1=capture.QueryFrame().Reshape(320, 240);
                //Xác đinh khuôn mặt
                long detectionTime;
                List<Rectangle> faces = new List<Rectangle>();
                List<Rectangle> eyes = new List<Rectangle>();
                bool tryUseCuda = false;
                bool tryUseOpenCL = true;
                DetectFace.Detect(img1, "haarcascade_frontalface_default.xml",
                                    "haarcascade_eye.xml",
                                    faces, eyes,
                                    tryUseCuda,
                                    tryUseOpenCL,
                                    out detectionTime);
                //Xác định lại các khung mặt
                foreach (Rectangle f in faces)
                {
                    TrainedFace = capture.QueryFrame().ToImage<Gray,byte>().Copy(f).Convert<Gray, byte>();
                    //imageBox3.Image = TrainedFace;
                    //MessageBox.Show(TrainedFace.ToString())
                    break;
                }
      
                //imageBox3.Image = TrainedFace;
                //resize kích thước ảnh chuyển về 
                /*
                 * Đang lấy mẫu sử dụng mối quan hệ khu vực pixel.
                 *Đây là phương pháp ưa thích cho decimation hình ảnh 
                 *đó cho kết quả gợn sóng miễn phí. 
                 *Trong trường hợp của phóng to nó cũng tương tự như phương pháp CV_INTER_NN
                 *
                */
               TrainedFace = TrainedFace.Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
                
                trainingImages.Add(TrainedFace);
                //lưu tên vào label
                labels.Add(("face"+trainingImages.ToArray().Length+1).ToString());
               
                //imageBox1.Image = TrainedFace;

                //Lưu số ảnh có trong List trainingImages
                File.WriteAllText(Application.StartupPath + "/Anh/AnhLabels.txt", trainingImages.ToArray().Length.ToString() + "%");
                MessageBox.Show(trainingImages.ToArray().Length.ToString());
                //Lưu lại ảnh và tên // Có thể tối ưu thêm
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/Anh/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/Anh/AnhLabels.txt", labels.ToArray()[i - 1] + "%");
                }
                MessageBox.Show( "Training OK");
            }
            catch
            {
                ContTrain--;
                MessageBox.Show("Lỗi train lại ");
            }
            finally
            {

            }
        }
    }
}