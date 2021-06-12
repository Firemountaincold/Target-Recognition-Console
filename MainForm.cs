using AForge.Video.DirectShow;
using DlibDotNet;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Threading;
using System.Collections;

namespace Target_Recognition_Console
{
    public partial class MainForm : Form
    {
        private FilterInfoCollection CaptureDevices; //设备列表
        private VideoCaptureDevice captureDevice;  //摄像头设备
        private VideoCapabilities[] videoCapabilities;  //摄像头能力列表
        private VideoCapabilities videoCapabilitie;  //单一摄像头能力（分辨率等）
        public bool isface = false;
        public bool istarget = true;
        public bool isfacestart = false;
        public bool iscarstart = false;
        public bool isyolostart = false;
        public FaceDetection fd;
        public CarRecognition cr;
        public Box box = new Box();
        public int dot = 0;
        public int dot2 = 0;
        public int yolopic = 0;
        public string videoFilePath;
        public string imgFilePath;
        public string imgFolderPath;
        public string[] imglist;
        public bool isimg = false;
        public bool isimgfile = false;
        public bool isplay = false;
        public int photo = 1;

        public MainForm()
        {
            InitializeComponent();
        }


        public void output(string str, int type)
        {
            textBoxinfo.BeginInvoke(new Action(() =>
            {
                if (type == 1)
                {
                    textBoxinfo.Text += DateTime.Now + " [信息] " + str + "\r\n";
                }
                else
                {
                    textBoxinfo.Text += DateTime.Now + " [警告] " + str + "\r\n";
                }
                textBoxinfo.SelectionStart = textBoxinfo.Text.Length;
                textBoxinfo.ScrollToCaret();
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出软件？", "询问", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    if (captureDevice != null)
                    {
                        captureDevice.Stop();
                    }
                    CaptureDevices.Clear();
                    videoSourcePlayer.VideoSource = null;
                    videoSourcePlayer.Stop();
                }
                catch (Exception) { }
                Process.GetCurrentProcess().Kill();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void comboBoxcam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //选择摄像头后
            comboBoxreso.Items.Clear(); //先清理上次选择的摄像头支持的分辨率
            //获取摄像头设备
            FilterInfo filterInfo = CaptureDevices[comboBoxcam.SelectedIndex];
            captureDevice = new VideoCaptureDevice(filterInfo.MonikerString);
            //获取所选择的摄像头分辨率列表并添加
            videoCapabilities = captureDevice.VideoCapabilities;
            foreach (VideoCapabilities capabilitie in videoCapabilities)
            {
                comboBoxreso.Items.Add(capabilitie.FrameSize.Width.ToString() +
                "×" + capabilitie.FrameSize.Height.ToString());
            }
            //选中默认分辨率 触发coBox_Resolution_SelectedIndexChanged（）
            if (comboBoxreso.Items.Count > 0)
            {
                comboBoxreso.SelectedIndex = 0;
            }
        }

        private void comboBoxreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取选择的分辨率，选择时没有关闭摄像头时进行关闭
            videoCapabilitie = videoCapabilities[comboBoxreso.SelectedIndex];
            buttonopencam.Enabled = true;
            buttonphoto.Enabled = true;
            if (videoSourcePlayer.IsRunning)
            {
                captureDevice.Stop();
                videoSourcePlayer.VideoSource = null;
                videoSourcePlayer.VideoSource = null;
                buttonopencam.Text = "打开";
            }
        }

        private void buttonopencam_Click(object sender, EventArgs e)
        {
            dot2 = 0;
            if (buttonopencam.Text == "打开")
            {
                captureDevice.VideoResolution = videoCapabilitie;
                videoSourcePlayer.VideoSource = captureDevice;

                captureDevice.SimulateTrigger();
                videoSourcePlayer.Start();
                output("已打开摄像头。", 1);
                buttonopencam.Text = "关闭";
                buttonphoto.Enabled = true;
                comboBoxcam.Enabled = false;
                comboBoxreso.Enabled = false;
            }
            else
            {
                try
                {
                    videoSourcePlayer.Stop();
                }
                catch (Exception) { }
                videoSourcePlayer.VideoSource = null;
                output("已关闭摄像头。", 1);
                buttonopencam.Text = "打开";
                buttonphoto.Enabled = false;
                comboBoxreso.Enabled = true;
                comboBoxcam.Enabled = true;
            }
        }

        private void buttonopenvideo_Click(object sender, EventArgs e)
        {
            dot2 = 0;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "视频文件(*.avi;*.mp4)|*.avi;*.mp4";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoFilePath = openFileDialog.FileName;
                output("已载入视频：" + Path.GetFileName(videoFilePath), 1);
            }
        }

        private void buttonplayvideo_Click(object sender, EventArgs e)
        {
            // 活体对应视频路径的文件作为视频源
            FileVideoSource videoSource = new FileVideoSource(videoFilePath);
            videoSourcePlayer.VideoSource = videoSource;
            videoSourcePlayer.Start();
            output("已开始播放。", 1);
            buttonphoto.Enabled = true;
            isplay = true;
        }

        private void buttonpause_Click(object sender, EventArgs e)
        {
            if (isplay)
            {
                videoSourcePlayer.SignalToStop();
                videoSourcePlayer.WaitForStop();
            }
            else
            {
                MessageBox.Show("没有正在播放的视频！");
            }
        }

        private void buttonphoto_Click(object sender, EventArgs e)
        {
            pictureBoxphoto.Image = videoSourcePlayer.GetCurrentVideoFrame();
            output("已进行拍照。", 1);
        }

        private void radioButtonface_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonface.Checked)
            {
                isface = true;
            }
        }

        private void radioButtontarget_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtontarget.Checked)
            {
                isface = false;
                istarget = false;
            }
        }

        private void radioButtongo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtongo.Checked)
            {
                isface = false;
                istarget = true;
            }
        }

        private void buttonload_Click(object sender, EventArgs e)
        {
            if (isface)
            {
                OpenFileDialog dlgOpenFile = new OpenFileDialog { Filter = "模型(*.dat)|*.dat" };
                if (dlgOpenFile.ShowDialog() == DialogResult.OK)
                {
                    string path = dlgOpenFile.FileName;
                    fd = new FaceDetection(path);
                    output("已载入模型：" + dlgOpenFile.FileName, 1);
                    buttonstart.Enabled = true;
                }
            }
            else
            {
                OpenFileDialog dlgOpenFile = new OpenFileDialog { Filter = "模型(*.dat)|*.dat" };
                if (dlgOpenFile.ShowDialog() == DialogResult.OK)
                {
                    string path = dlgOpenFile.FileName;
                    cr = new CarRecognition(path);
                    output("已载入模型：" + dlgOpenFile.FileName, 1);
                    buttonstart.Enabled = true;
                }
            }
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            if (radioButtonrealtime.Checked)
            {
                //实时检测
                buttonstop.Enabled = true;
                if (videoSourcePlayer.IsRunning)
                {
                    if (isface)
                    {
                        isfacestart = true;
                        if (Dlib.IsSupportCuda)
                        {
                            output("正在使用GPU。", 1);
                        }
                        output("开始进行人脸检测。", 1);
                    }
                    else
                    {
                        iscarstart = true;
                        output("开始进行目标检测。", 1);
                    }
                    buttonstart.Enabled = false;
                }
                else
                {
                    MessageBox.Show("请先打开视频源。", "警告");
                }
            }
            else
            {
                //非实时检测
                if (!isface)
                {
                    dot2++;
                    CarDetection();
                    output("[Dlib]帧" + dot2.ToString() + "：目标数量为" + textBoxnum.Text + "。", 1);
                }
                else
                {
                    dot2++;
                    FaceDetection();
                    output("[Dlib]帧" + dot2.ToString() + "：目标数量为" + textBoxnum.Text + "。", 1);
                }
            }
        }

        private void buttonstop_Click(object sender, EventArgs e)
        {
            if (isface)
            {
                isfacestart = false;
                output("停止进行人脸检测。", 1);
            }
            else
            {
                iscarstart = false;
                output("停止进行目标检测。", 1);
            }
            buttonstop.Enabled = false;
            buttonstart.Enabled = true;
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否退出软件？", "询问", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    if (captureDevice != null)
                    {
                        captureDevice.Stop();
                    }
                    CaptureDevices.Clear();
                    videoSourcePlayer.VideoSource = null;
                    videoSourcePlayer.Stop();
                }
                catch (Exception) { }
                Process.GetCurrentProcess().Kill();
                Application.Exit();
            }
        }

        public void Face()
        {
            ThreadStart threadStartf = new ThreadStart(FaceDetection);
            Thread threadf = new Thread(threadStartf);
            threadf.Start();
        }

        private void FaceDetection()
        {
            try
            {
                //获取拍摄的图像
                Bitmap img = (Bitmap)videoSourcePlayer.GetCurrentVideoFrame().Clone();
                int numFaces = 0;
                //进行人脸识别以及图像显示，更新界面的人脸识别数目
                pictureBox.Image = fd.FaceDetectionFromImage(img, out numFaces);
                textBoxnum.Text = numFaces.ToString();
            }
            catch (Exception ex)
            {
                output(ex.Message, 2);
            }
        }

        public void Car()
        {
            ThreadStart threadStartc = new ThreadStart(CarDetection);
            Thread threadc = new Thread(threadStartc);
            threadc.Start();
        }

        private void CarDetection()
        {
            //调用目标检测
            try
            {
                //获取拍摄的图像
                Bitmap img = (Bitmap)videoSourcePlayer.GetCurrentVideoFrame().Clone();
                int numCars = 0;
                //进行目标识别以及图像显示，更新界面的人脸识别数目
                if (!istarget)
                {
                    pictureBox.Image = cr.CarRecognitionFromImage(img, out numCars);
                }
                else
                {
                    pictureBox.Image = cr.TargetDetection(img, out numCars);
                }
                textBoxnum.Text = numCars.ToString();
            }
            catch (Exception ex)
            {
                output(ex.TargetSite + "|" + ex.Message, 2);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //每秒调用一次
            timer.Interval = 1000;
            if (iscarstart)
            {
                dot++;
                CarDetection();
                output("[Dlib]帧" + dot.ToString() + "：目标数量为" + textBoxnum.Text + "。", 1);
            }
            else if (isfacestart)
            {
                dot++;
                FaceDetection();
                output("[Dlib]帧" + dot.ToString() + "：目标数量为" + textBoxnum.Text + "。", 1);
            }
            else if (isyolostart)
            {
                dot++;
                YOLO();
                output("[YOLO]帧" + dot.ToString() + "：目标数量为" + textBoxnum.Text + "。", 1);
            }
            else
            {
                dot = 0;
            }
        }

        private void buttonloadyolo_Click(object sender, EventArgs e)
        {
            //载入模型
            ThreadStart threadStart = new ThreadStart(BoxInit);
            Thread thread = new Thread(threadStart);
            thread.Start();
        }

        public void BoxInit()
        {
            //初始化
            output("正在初始化……", 1);
            box.Initilize();
            output("初始化完成。", 1);
            buttonstartyolo.BeginInvoke(new Action(() =>
            {
                buttonstartyolo.Enabled = true;
            }));
        }

        private void buttonstartyolo_Click(object sender, EventArgs e)
        {
            if (radioButtonrealtime.Checked)
            {
                //实时检测
                //开始检测
                buttonstopyolo.Enabled = true;
                if (videoSourcePlayer.IsRunning)
                {
                    output("开始进行目标检测。", 1);
                    isyolostart = true;
                }
                buttonstartyolo.Enabled = false;
            }
            else
            {
                //非实时检测
                dot2++;
                YOLO();
                output("[YOLO]帧" + dot2.ToString() + "：目标数量为" + textBoxnum.Text + "。", 1);
            }
        }

        private void buttonstopyolo_Click(object sender, EventArgs e)
        {
            //停止检测
            isyolostart = false;
            output("停止进行目标检测。", 1);
            buttonstopyolo.Enabled = false;
            buttonstartyolo.Enabled = true;
        }

        public void YOLO()
        {
            //检测当前图片
            Bitmap img = (Bitmap)videoSourcePlayer.GetCurrentVideoFrame().Clone();
            yolopic++;
            string pictureName = yolopic.ToString() + ".jpg";
            using (MemoryStream mem = new MemoryStream())
            {
                img.Save(pictureName, img.RawFormat);
                img.Dispose();
            }
            DataTable dt = box.Convert(pictureName);
            DrawPic(img, dt);
            textBoxnum.Text = dt.Rows.Count.ToString();
            File.Delete(pictureName);
        }

        public void DrawPic(Bitmap img, DataTable dt)
        {
            //绘制标注
            Graphics gps = Graphics.FromImage(img);
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                gps.DrawRectangle(new Pen(Color.Red, 1),Convert.ToInt32(dt.Rows[i]["X"]), Convert.ToInt32(dt.Rows[i]["Y"]), Convert.ToInt32(dt.Rows[i]["Width"]), Convert.ToInt32(dt.Rows[i]["Height"]));
                gps.DrawString(dt.Rows[i]["Type"].ToString(), Font, Brushes.Black, new PointF(20, 10));
            }
            pictureBox.Image = img;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //窗口启动项
            Console.SetOut(new TextBoxWriter(textBoxinfo));
            pictureBoxphoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //获取摄像头并添加到coBox_CamList
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in CaptureDevices)
            {
                comboBoxcam.Items.Add(filterInfo.Name);
            }
            output("已加载摄像头列表。", 1);
            timer.Start();
            CheckCuda();
        }

        private void buttonsavephoto_Click(object sender, EventArgs e)
        {
            if (pictureBoxphoto.Image != null)
            {
                Image img = pictureBoxphoto.Image;
                string path = Path.Combine(Application.StartupPath, DateTime.Now.DayOfYear.ToString() + "-" + photo.ToString() + ".jpeg");
                img.Save(path,System.Drawing.Imaging.ImageFormat.Jpeg);
                output("已保存图片至" + path, 1);
                photo++;
            }
            else
            {
                MessageBox.Show("没有可保存的照片！");
            }
        }

        private void buttonopenimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图片文件(*.jpg;*.jpeg)|*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgFilePath = openFileDialog.FileName;
                output("已载入图片：" + Path.GetFileName(imgFilePath), 1);
                labelopen.Text = "图片";
                pictureBox.Image = Image.FromFile(imgFilePath);
            }
        }

        private void buttonopeniimgf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.Description = "请选择包含图片的文件夹。";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                imgFolderPath = folderBrowserDialog.SelectedPath;
                output("已载入文件夹：" + Path.GetDirectoryName(imgFilePath), 1);
                labelopen.Text = "文件夹";
                imglist = GetFiles(imgFolderPath);
                pictureBox.Image = Image.FromFile(imglist[0]); 
            }
        }

        public string[] GetFiles(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            ArrayList alst = new ArrayList();
            foreach (string file in files)
            {
                string exname = file.Substring(file.LastIndexOf(".") + 1);
                if (".jpg|.jpeg".IndexOf(file.Substring(file.LastIndexOf(".") + 1)) > -1)
                {
                    FileInfo fi = new FileInfo(file);
                    alst.Add(fi.FullName);
                }
            }
            return (string[])alst.ToArray(typeof(string));
        }

        private void buttonabout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本程序由Hdu李呤泽开发，仅用于课堂学习。", "关于");
        }

        public void CheckCuda()
        {
            //检查是否支持CUDA
            if (Dlib.IsSupportCuda)
            {
                textBoxcuda.Text = "已启用";
                textBoxcuda.ForeColor = Color.Green;
            }
        }
    }
}
