using System;
using System.Runtime.InteropServices;

namespace Target_Recognition_Console
{
    public class YoloWrapper : IDisposable
    {
        private const string YoloLibraryName = @".\Dll\yolo_cpp_dll.dll";
        //调用dll
        [DllImport(YoloLibraryName, EntryPoint = "init")]
        private static extern int InitializeYolo(string configurationFilename, string weightsFilename, int gpu);
        [DllImport(YoloLibraryName, EntryPoint = "detect_image")]
        private static extern int DetectImage(string filename, ref BboxContainer container);
        [DllImport(YoloLibraryName, EntryPoint = "detect_mat")]
        private static extern int DetectImage(IntPtr pArray, int nSize, ref BboxContainer container);
        [DllImport(YoloLibraryName, EntryPoint = "dispose")]
        private static extern int DisposeYolo();
        public YoloWrapper(string configurationFilename, string weightsFilename, int gpu)
        {
            //初始化
            InitializeYolo(configurationFilename, weightsFilename, gpu);
        }
        public void Dispose()
        {
            //关闭
            DisposeYolo();
        }
        public BoundingBox[] Detect(string filename)
        {
            //目标检测
            var container = new BboxContainer();
            var count = DetectImage(filename, ref container);
            return container.candidates;
        }
        public BoundingBox[] Detect(byte[] imageData)
        {
            //目标检测
            var container = new BboxContainer();
            var size = Marshal.SizeOf(imageData[0]) * imageData.Length;
            var pnt = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.Copy(imageData, 0, pnt, imageData.Length);
                var count = DetectImage(pnt, imageData.Length, ref container);
                if (count == -1)
                {
                    throw new NotSupportedException($"{YoloLibraryName} has no OpenCV support");
                }
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                Marshal.FreeHGlobal(pnt);
            }
            return container.candidates;
        }
    }
}
