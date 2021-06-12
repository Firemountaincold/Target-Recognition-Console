using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Target_Recognition_Console
{
    class TextBoxWriter : TextWriter
    {
        TextBox textBox;
        delegate void WriteFunc(string value);
        WriteFunc write;
        WriteFunc writeLine;

        public TextBoxWriter(TextBox textBox)
        {
            this.textBox = textBox;
            write = Write;
            writeLine = WriteLine;
        }

        public override Encoding Encoding
        {
            // 使用UTF-16避免不必要的编码转换
            get { return Encoding.Unicode; }
        }

        public override void Write(string value)
        {
            // 最低限度需要重写的方法
            if (textBox.InvokeRequired)
                textBox.BeginInvoke(write, value);
            else
                textBox.AppendText(value);
        }

        public override void WriteLine(string value)
        {
            // 为提高效率直接处理一行的输出
            if (textBox.InvokeRequired)
                textBox.BeginInvoke(writeLine, value);
            else
            {
                textBox.AppendText(value);
                textBox.AppendText(this.NewLine);
            }
        }
    }
}
