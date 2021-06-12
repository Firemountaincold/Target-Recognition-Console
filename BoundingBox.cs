using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;

namespace Target_Recognition_Console
{
    public class Box
    {
        private const string configurationFilename = @"C:\software\TRC\Cfg\yolov4.cfg";
        private const string weightsFilename = @"C:\software\TRC\Weights\yolov3.weights";
        private const string namesFile = @"C:\software\TRC\Data\coco.names";
        private static Dictionary<int, string> _namesDic = new Dictionary<int, string>();
        private static YoloWrapper _wrapper;

        public void Initilize()
        {
            //初始化
            int gpu = 0;
            Console.WriteLine(configurationFilename);
            Console.WriteLine(weightsFilename);
            _wrapper = new YoloWrapper(configurationFilename, weightsFilename, gpu);
            var lines = File.ReadAllLines(namesFile);
            for (var i = 0; i < lines.Length; i++)
            {
                _namesDic.Add(i, lines[i]);
            }
        }

        public DataTable Convert(string imagePath)
        {
            //从图片得出结果的数据表
            var bbox = _wrapper.Detect(imagePath);
            var table = new DataTable();
            table.Columns.Add("Type");
            table.Columns.Add("Confidence");
            table.Columns.Add("X");
            table.Columns.Add("Y");
            table.Columns.Add("Width");
            table.Columns.Add("Height");
            foreach (var item in bbox.Where(o => o.h > 0 || o.w > 0))
            {
                var type = _namesDic[(int)item.obj_id];
                DataRow dr = table.NewRow();
                dr["Type"] = type;
                dr["Confidence"] = item.prob;
                dr["X"] = item.x;
                dr["Y"] = item.y;
                dr["Width"] = item.w;
                dr["Height"] = item.h;
                table.Rows.Add(dr);
            }
            return table;
        }
    }
}
