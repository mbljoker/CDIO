using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luxand;
using System.Runtime.InteropServices;
using System.IO;

namespace TestEmgCV
{
    public partial class identifyFolder : Form
    {
        MatKhau PassID;

        enum ProgramState { psRemember, psRecognize }
        ProgramState programState = ProgramState.psRecognize;

        String TenCamera;
        bool needClose = false;
        string Ten;
        Thread td;
        protected String TrackerMemoryFile = "tracker.dat";
        int mouseX = 0;
        int mouseY = 0;
        String Ten1;
        bool tt = true;
        [DllImport("gdi32.dll")]
        static extern bool DeleteObject(IntPtr hObject);
       
        public identifyFolder()
        {
            InitializeComponent();
            PassID = new MatKhau();
            if (!File.Exists(Application.StartupPath + "\\SaveFolder\\PassAnh.txt"))
            {
                File.Create(Application.StartupPath + "\\SaveFolder\\Data.txt").Close();
            }
            using (StreamReader SR = new StreamReader(Application.StartupPath + "/SaveFolder/PassAnh.txt"))
            {
                Ten1 = SR.ReadLine();
            }
            
        }
        //Khởi Động Camera
        

        //Tìm kiếm mặt trên camera
        
        
        private void identifyFolder_Load(object sender, EventArgs e)
        {
            if (FSDK.FSDKE_OK != FSDK.ActivateLibrary("iYL71M6OblPn4TOl8nYojjcGvZZaKo4seThAr+xuvRxW4gWSyK6glbCyrkFW9rzP1c/rLZbKCYeO15pjCoWGS9YAmb7i0U0RztaWBCPCdEqxy+YO1p0efMsRgocnVb1RM+Z2IRCMbvHoOQbg8fCZgKJ4wl+/1MfGHJKocXboYJU="))
            {
                MessageBox.Show("Please run the License Key Wizard (Start - Luxand - FaceSDK - License Key Wizard)", "Error activating FaceSDK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            //Khởi tạo thư viện
            FSDK.InitializeLibrary();
            //khởi tạo cammera
            FSDKCam.InitializeCapturing();

            string[] danhSachCamera;
            int soLuongCMR;
            FSDKCam.GetCameraList(out danhSachCamera, out soLuongCMR);

            if (0 == soLuongCMR)
            {
                MessageBox.Show("Please attach a camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            TenCamera = danhSachCamera[0];
            FSDKCam.VideoFormatInfo[] formatList;
            td = new Thread(nhanDien);
            td.IsBackground = true;
            td.Priority = ThreadPriority.Highest;
            td.Start();
        }

        public void nhanDien()
        {
            int CamXuLy = 0;
            int r = FSDKCam.OpenVideoCamera(ref TenCamera, ref CamXuLy);
            if (r != FSDK.FSDKE_OK)
            {
                MessageBox.Show("Error opening the first camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            int tracker = 0; //tạo tracker
            if (FSDK.FSDKE_OK != FSDK.LoadTrackerMemoryFromFile(ref tracker, TrackerMemoryFile)) // try to load saved tracker state
                FSDK.CreateTracker(ref tracker); // if could not be loaded, create a new tracker

            int err = 0; // set realtime face detection parameters
            FSDK.SetTrackerMultipleParameters(tracker,
                   "HandleArbitraryRotations=false; DetermineFaceRotationAngle=false; InternalResizeWidth=100; FaceDetectionThreshold=3;",
                   ref err);

            while (!needClose)
            {
                Int32 xuLyAnh = 0;
                if (FSDK.FSDKE_OK != FSDKCam.GrabFrame(CamXuLy, ref xuLyAnh)) // grab the current frame from the camera
                {
                    Application.DoEvents();
                    continue;
                }

                FSDK.CImage image = new FSDK.CImage(xuLyAnh); //new FSDK.CImage(imageHandle);
                //Image img = Image.FromFile("E:\\10257275_557036397739997_2637418459313670467_o.jpg");
                //Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                //Graphics g = Graphics.FromImage((Image)b);

                //g.DrawImage(img, 0, 0, pictureBox1.Width, pictureBox1.Height);
                //g.Dispose();

                ///FSDK.CImage image = new FSDK.CImage(b);
                //FSDK.CImage image = new FSDK.CImage("E:\\10257275_557036397739997_2637418459313670467_o.jpg");

                long[] IDs;
                long faceCount = 0;
                FSDK.FeedFrame(tracker, 0, image.ImageHandle, ref faceCount, out IDs, sizeof(long) * 256); // maximum of 256 faces detected
                Console.Write(IDs[0]);
                Array.Resize(ref IDs, (int)faceCount);

                // make UI controls accessible (to find if the user clicked on a face)
                Application.DoEvents();
                //Image.
                Image frameImage = image.ToCLRImage();
                Graphics gr = Graphics.FromImage(frameImage);

                for (int i = 0; i < IDs.Length; ++i)
                {
                    FSDK.TFacePosition facePosition = new FSDK.TFacePosition();
                    FSDK.GetTrackerFacePosition(tracker, 0, IDs[i], ref facePosition);
                    Console.Write(IDs.Length.ToString());
                    int left = facePosition.xc - (int)(facePosition.w * 0.6);
                    int top = facePosition.yc - (int)(facePosition.w * 0.5);
                    int w = (int)(facePosition.w * 1.2);

                    String name;
                    int res = FSDK.GetAllNames(tracker, IDs[i], out name, 65536); // maximum of 65536 characters

                    if (FSDK.FSDKE_OK == res && name.Length > 0)
                    { // draw name
                        StringFormat format = new StringFormat();
                        format.Alignment = StringAlignment.Center;
                        if (name == Ten1)
                        {
                            if (tt == true)
                            {
                                timer1.Interval = 1000;
                                timer1.Start();
                                tt = false;
                            }
                        }
                        gr.DrawString("", new System.Drawing.Font("Arial", 16),
                            new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen),
                            facePosition.xc, top + w + 5, format);
                    }

                    Pen pen = Pens.LightGreen;
                   
                    gr.DrawRectangle(pen, left, top, w, w);

                }
                programState = ProgramState.psRecognize;

                // display current frame
                pictureBox1.Image = frameImage;
                GC.Collect(); // collect the garbage after the deletion
            }
            FSDK.SaveTrackerMemoryToFile(tracker, TrackerMemoryFile);
            FSDK.FreeTracker(tracker);
            FSDKCam.CloseVideoCamera(CamXuLy);
            FSDKCam.FinalizeCapturing();

        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            String Pass=tbxPassWord.Text.Trim();
            if (PassID.Check(Pass) == true)
            {
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

        private void tbxPassWord_TextChanged(object sender, EventArgs e)
        {

        }
        int dem = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            dem++;
            if (dem == 4)
            {
                MessageBox.Show("Xác Thực Thành Công !","Thông Báo ");
                try
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch
                {
                    DialogResult = DialogResult.OK;
                }
                
               
            }
        
        }

        private void identifyFolder_FormClosing(object sender, FormClosingEventArgs e)
        {
            needClose = true;
            
        }
    }
}
