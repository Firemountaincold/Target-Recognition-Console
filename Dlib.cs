using DlibDotNet;
using DlibDotNet.Dnn;
using DlibDotNet.Extensions;
using System.Drawing;
using System.Linq;

namespace Target_Recognition_Console
{
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
