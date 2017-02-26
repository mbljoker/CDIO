using Emgu.CV;
using Emgu.CV.Structure;
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
    public partial class identifyFolder : Form
    {
        MatKhau PassID;

        Image<Bgr, byte> CurrentFrame;
        Image<Gray, byte> GrayFrame;
        Capture CaptureID;
        Image<Gray, byte> Result;
        public CascadeClassifier Face = new CascadeClassifier(Application.StartupPath + "/haarcascade_frontalface_default.xml");
        string PathFolderImg = "";
        Classifier_Train EigenRecog = new Classifier_Train();
        int Threshold = 1500;
        public identifyFolder()
        {
            InitializeComponent();
            if (EigenRecog.IsTrained)
            {
               //MessageBox.Show("");
            }
            else
            {
                MessageBox.Show("Không tải được cơ sở dữ liệu dể xác thực");
            }
            //Kiểu Nhận Diện
            EigenRecog.Recognizer_Type = "EMGU.CV.EigenFaceRecognizer";
            //Giatri
            PassID = new MatKhau();
            EigenRecog.Set_Eigen_Threshold = Threshold;
            startCapture();
        }
        //Khởi Động Camera
        public void startCapture()
        {
            CaptureID = new Capture();
            //capture.QueryFrame();
            //Sự kiện chạy khung hình 
            Application.Idle += new EventHandler(searchFace);
        }

        //Tìm kiếm mặt trên camera
        private void searchFace(object sender, EventArgs e)
        {
            CurrentFrame = CaptureID.QueryFrame().ToImage<Bgr, byte>().Resize(720, 480, Emgu.CV.CvEnum.Inter.Cubic);
            //CurrentFrame=capture.QueryFrame().;
            //=CurrentFrame.Resize(720, 480, Emgu.CV.CvEnum.Inter.Cubic);
            if (CurrentFrame != null)
            {
                GrayFrame = CurrentFrame.Convert<Gray, Byte>();
                //Lấy Img Ảnh sau khi defect
                Rectangle[] FacesDetected = Face.DetectMultiScale(GrayFrame, 1.2, 10, new Size(50, 50), Size.Empty);

                // (Duyệt từng đối tượng)
                for (int i = 0; i < FacesDetected.Length; i++)
                {
                    //Căn chỉnh hình    
                    ///*
                    FacesDetected[i].X += (int)(FacesDetected[i].Height * 0.15);
                    FacesDetected[i].Y += (int)(FacesDetected[i].Width * 0.22);
                    FacesDetected[i].Height -= (int)(FacesDetected[i].Height * 0.3);
                    FacesDetected[i].Width -= (int)(FacesDetected[i].Width * 0.35);
                    //Lấy Khuôn mặt trên ảnh 
                    Result = CurrentFrame.Copy(FacesDetected[i]).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
                    //Chuẩn Ảnh
                    Result._EqualizeHist();
                    //Vẽ lên ảnh 
                    CurrentFrame.Draw(FacesDetected[i], new Bgr(Color.Yellow), 2);

                    if (EigenRecog.IsTrained)
                    {
                        string Name = EigenRecog.Recognise(Result);
                        int MatchValue = (int)EigenRecog.Get_Eigen_Distance;
                        picCamera.Image = Result;
                        //MessageBox.Show(Name);
                        if (Name != "Unknown") lblName.Text = Name;
                        lblIndex.Text = Name + "   " + MatchValue + ">" + Threshold;
                        if (EigenRecog.Get_Eigen_Distance > Threshold)
                        {
                            CaptureID.Stop();
                            Application.Idle -= new EventHandler(searchFace);
                            CaptureID.Dispose();
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                picCamera.Image = CurrentFrame;
            }

        }

        private void identifyFolder_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String Pass=tbxPassWord.Text.Trim();
            if (PassID.Check(Pass) == true)
            {
                CaptureID.Stop();
                Application.Idle -= new EventHandler(searchFace);
                CaptureID.Dispose();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai Mật Khẩu !","Thông Báo");
            }
        }

        private void tbxPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter.PerformClick();
            }
        }
    }
}
