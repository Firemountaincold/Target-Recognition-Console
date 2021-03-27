using AForge.Video.DirectShow;
using DlibDotNet;
using DlibDotNet.Dnn;
using DlibDotNet.Extensions;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Target_Recognition_Console
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection CaptureDevices; //设备列表
        private VideoCaptureDevice captureDevice;  //摄像头设备
        private VideoCapabilities[] videoCapabilities;  //摄像头能力列表
        private VideoCapabilities videoCapabilitie;  //单一摄像头能力（分辨率等）
        public bool isface = true;
        public bool isfacestart = false;
        public bool iscarstart = false;
        public FaceDetection fd;
        public CarRecognition cr;
        public int dot = 0;
        public Form1()
        {
            InitializeComponent();
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
        }


        public void output(string str, int type)
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

        private void buttonphoto_Click(object sender, EventArgs e)
        {
            pictureBoxphoto.Image = videoSourcePlayer.GetCurrentVideoFrame();
            output("已进行拍照。", 1);
        }

        private void radioButtonface_CheckedChanged(object sender, EventArgs e)
        {
            isface = true;
        }

        private void radioButtontarget_CheckedChanged(object sender, EventArgs e)
        {
            isface = false;
        }

        private void buttonload_Click(object sender, EventArgs e)
        {
            if (isface)
            {
                OpenFileDialog dlgOpenFile = new OpenFileDialog { Filter = "模型(*.dat)|*.dat" };
                if (dlgOpenFile.ShowDialog() == DialogResult.OK)//OK表示按下了“打开”
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
                if (dlgOpenFile.ShowDialog() == DialogResult.OK)//OK表示按下了“打开”
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
                MessageBox.Show("请先打开摄像头", "警告");
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

        private void CarDetection()
        {
            try
            {
                //调用目标检测
                //获取拍摄的图像
                Bitmap img = (Bitmap)videoSourcePlayer.GetCurrentVideoFrame().Clone();
                int numCars = 0;
                //进行目标识别以及图像显示，更新界面的人脸识别数目
                pictureBox.Image = cr.CarRecognitionFromImage(img, out numCars);
                textBoxnum.Text = numCars.ToString();
            }
            catch (Exception ex)
            {
                output(ex.Message, 2);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            if (iscarstart)
            {
                dot++;
                CarDetection();
                output("帧" + dot.ToString() + "：目标数量为" + textBoxnum.Text + "。", 1);
            } 
            else if (isfacestart)
            {
                dot++;
                FaceDetection();
                output("帧" + dot.ToString() + "：目标数量为" + textBoxnum.Text + "。", 1);
            }
            else
            {
                dot = 0;
            }
        }
    }

    public class FaceDetection
    {
        //用于人脸检测的类
        private string faceDataPath;

        // 人脸数据文件路径名称属性
        public string FaceDataPath { get => faceDataPath; set => faceDataPath = value; }

        public FaceDetection(string path)
        {
            //默认文件路径
            faceDataPath = path;
        }

        public Bitmap FaceDetectionFromImage(Bitmap image, out int numOfFaceDetected)
        {
            numOfFaceDetected = 0;
            if (image != null)
            {
                // 图像转换到Dlib的图像类中
                Array2D<RgbPixel> img = BitmapExtensions.ToArray2D<RgbPixel>(image);

                using (var faceDetector = Dlib.GetFrontalFaceDetector())
                using (var shapePredictor = ShapePredictor.Deserialize(faceDataPath))
                {
                    // 检测人脸
                    var faces = faceDetector.Operator(img);

                    // 遍历检测到的人脸区域
                    foreach (var rect in faces)
                    {
                        //绘制脸部区域
                        Dlib.DrawRectangle(img, rect, new RgbPixel { Blue = 255 }, 3);
                        // 人脸区域中识别脸部特征
                        var shape = shapePredictor.Detect(img, rect);
                        // 简单绘制识别到的特征（用线连起来）
                        for (uint i = 1; i < shape.Parts; i++)
                        {
                            Dlib.DrawLine(img, shape.GetPart(i), shape.GetPart(i - 1), new RgbPixel { Red = 255 });
                        }
                    }
                    numOfFaceDetected = faces.Length;
                }
                return BitmapExtensions.ToBitmap<RgbPixel>(img);
            }
            return image;
        }

    }

    public class CarRecognition
    {
        //用于目标检测的类
        private string carDataPath;

        // 目标数据文件路径名称属性
        public string CarDataPath { get => carDataPath; set => carDataPath = value; }

        public CarRecognition(string path)
        {
            //默认文件路径
            carDataPath = path;
        }

        public Bitmap CarRecognitionFromImage(Bitmap image, out int numOfCarDetected)
        {
            numOfCarDetected = 0;
            if (image != null)
            {
                // 图像转换到Dlib的图像类中
                Matrix<RgbPixel> img = BitmapExtensions.ToMatrix<RgbPixel>(image);
                using (var deserialize = new ProxyDeserialize(carDataPath))
                using (var net = LossMmod.Deserialize(deserialize, 1))
                using (var shapePredictor = ShapePredictor.Deserialize(deserialize))
                {
                    // 检测目标
                    var dets = net.Operator(img).First();

                    // 遍历检测到的目标区域
                    foreach (var d in dets)
                    {
                        //我们使用shape_predictor来完善检测盒的确切形状和位置。
                        //经过训练的shape_predictor可以简单地输出盒子的4个角点。
                        //因此，我们要做的就是制作一个紧密包含这4个点的矩形，该矩形是我们精确的检测位置。
                        var fd = shapePredictor.Detect(img, d);
                        var rect = DlibDotNet.Rectangle.Empty;
                        for (var j = 0u; j < fd.Parts; ++j)
                            rect += fd.GetPart(j);
                        if (d.Label == "rear")
                        {
                            Dlib.DrawRectangle(img, rect, new RgbPixel(255, 0, 0), 3);
                        }
                        else
                        {
                            Dlib.DrawRectangle(img, rect, new RgbPixel(0, 0, 255), 3);
                        }
                        var shape = shapePredictor.Detect(img, rect);
                        // 简单绘制识别到的特征（用线连起来）
                        for (uint i = 1; i < shape.Parts; i++)
                        {
                            Dlib.DrawLine(img, shape.GetPart(i), shape.GetPart(i - 1), new RgbPixel { Green = 255 });
                        }
                    }
                    numOfCarDetected = dets.Count();
                }
                return BitmapExtensions.ToBitmap<RgbPixel>(img);
            }
            return image;
        }
    }
}
