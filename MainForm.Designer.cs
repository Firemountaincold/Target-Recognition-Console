
namespace Target_Recognition_Console
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxinfo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonstop = new System.Windows.Forms.Button();
            this.buttonstart = new System.Windows.Forms.Button();
            this.buttonload = new System.Windows.Forms.Button();
            this.radioButtonface = new System.Windows.Forms.RadioButton();
            this.radioButtontarget = new System.Windows.Forms.RadioButton();
            this.textBoxnum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonexit = new System.Windows.Forms.Button();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.pictureBoxphoto = new System.Windows.Forms.PictureBox();
            this.buttonphoto = new System.Windows.Forms.Button();
            this.buttonopencam = new System.Windows.Forms.Button();
            this.comboBoxcam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxreso = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonstopyolo = new System.Windows.Forms.Button();
            this.buttonstartyolo = new System.Windows.Forms.Button();
            this.buttonloadyolo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxphoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(654, 10);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(693, 394);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // textBoxinfo
            // 
            this.textBoxinfo.Location = new System.Drawing.Point(994, 420);
            this.textBoxinfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxinfo.Multiline = true;
            this.textBoxinfo.Name = "textBoxinfo";
            this.textBoxinfo.Size = new System.Drawing.Size(353, 275);
            this.textBoxinfo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonstop);
            this.groupBox1.Controls.Add(this.buttonstart);
            this.groupBox1.Controls.Add(this.buttonload);
            this.groupBox1.Controls.Add(this.radioButtonface);
            this.groupBox1.Controls.Add(this.radioButtontarget);
            this.groupBox1.Location = new System.Drawing.Point(429, 420);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(548, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dlib框架";
            // 
            // buttonstop
            // 
            this.buttonstop.Enabled = false;
            this.buttonstop.Location = new System.Drawing.Point(368, 36);
            this.buttonstop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonstop.Name = "buttonstop";
            this.buttonstop.Size = new System.Drawing.Size(165, 29);
            this.buttonstop.TabIndex = 2;
            this.buttonstop.Text = "停止检测";
            this.buttonstop.UseVisualStyleBackColor = true;
            this.buttonstop.Click += new System.EventHandler(this.buttonstop_Click);
            // 
            // buttonstart
            // 
            this.buttonstart.Enabled = false;
            this.buttonstart.Location = new System.Drawing.Point(193, 36);
            this.buttonstart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(165, 29);
            this.buttonstart.TabIndex = 1;
            this.buttonstart.Text = "开始检测";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // buttonload
            // 
            this.buttonload.Location = new System.Drawing.Point(16, 36);
            this.buttonload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonload.Name = "buttonload";
            this.buttonload.Size = new System.Drawing.Size(165, 29);
            this.buttonload.TabIndex = 0;
            this.buttonload.Text = "载入模型";
            this.buttonload.UseVisualStyleBackColor = true;
            this.buttonload.Click += new System.EventHandler(this.buttonload_Click);
            // 
            // radioButtonface
            // 
            this.radioButtonface.AutoSize = true;
            this.radioButtonface.Checked = true;
            this.radioButtonface.Location = new System.Drawing.Point(16, 85);
            this.radioButtonface.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonface.Name = "radioButtonface";
            this.radioButtonface.Size = new System.Drawing.Size(88, 19);
            this.radioButtonface.TabIndex = 4;
            this.radioButtonface.TabStop = true;
            this.radioButtonface.Text = "人脸识别";
            this.radioButtonface.UseVisualStyleBackColor = true;
            this.radioButtonface.CheckedChanged += new System.EventHandler(this.radioButtonface_CheckedChanged);
            // 
            // radioButtontarget
            // 
            this.radioButtontarget.AutoSize = true;
            this.radioButtontarget.Location = new System.Drawing.Point(131, 85);
            this.radioButtontarget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtontarget.Name = "radioButtontarget";
            this.radioButtontarget.Size = new System.Drawing.Size(88, 19);
            this.radioButtontarget.TabIndex = 5;
            this.radioButtontarget.Text = "目标检测";
            this.radioButtontarget.UseVisualStyleBackColor = true;
            this.radioButtontarget.CheckedChanged += new System.EventHandler(this.radioButtontarget_CheckedChanged);
            // 
            // textBoxnum
            // 
            this.textBoxnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxnum.Location = new System.Drawing.Point(522, 653);
            this.textBoxnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxnum.Name = "textBoxnum";
            this.textBoxnum.ReadOnly = true;
            this.textBoxnum.Size = new System.Drawing.Size(55, 18);
            this.textBoxnum.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 655);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "目标数量：";
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(797, 653);
            this.buttonexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(165, 29);
            this.buttonexit.TabIndex = 3;
            this.buttonexit.Text = "退出程序";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Location = new System.Drawing.Point(12, 10);
            this.videoSourcePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(636, 394);
            this.videoSourcePlayer.TabIndex = 3;
            this.videoSourcePlayer.Text = "videoSourcePlayer1";
            this.videoSourcePlayer.VideoSource = null;
            // 
            // pictureBoxphoto
            // 
            this.pictureBoxphoto.Location = new System.Drawing.Point(12, 420);
            this.pictureBoxphoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxphoto.Name = "pictureBoxphoto";
            this.pictureBoxphoto.Size = new System.Drawing.Size(391, 186);
            this.pictureBoxphoto.TabIndex = 4;
            this.pictureBoxphoto.TabStop = false;
            // 
            // buttonphoto
            // 
            this.buttonphoto.Enabled = false;
            this.buttonphoto.Location = new System.Drawing.Point(276, 666);
            this.buttonphoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonphoto.Name = "buttonphoto";
            this.buttonphoto.Size = new System.Drawing.Size(127, 29);
            this.buttonphoto.TabIndex = 5;
            this.buttonphoto.Text = "拍照";
            this.buttonphoto.UseVisualStyleBackColor = true;
            this.buttonphoto.Click += new System.EventHandler(this.buttonphoto_Click);
            // 
            // buttonopencam
            // 
            this.buttonopencam.Enabled = false;
            this.buttonopencam.Location = new System.Drawing.Point(276, 626);
            this.buttonopencam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonopencam.Name = "buttonopencam";
            this.buttonopencam.Size = new System.Drawing.Size(127, 29);
            this.buttonopencam.TabIndex = 6;
            this.buttonopencam.Text = "打开";
            this.buttonopencam.UseVisualStyleBackColor = true;
            this.buttonopencam.Click += new System.EventHandler(this.buttonopencam_Click);
            // 
            // comboBoxcam
            // 
            this.comboBoxcam.FormattingEnabled = true;
            this.comboBoxcam.Location = new System.Drawing.Point(12, 628);
            this.comboBoxcam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxcam.Name = "comboBoxcam";
            this.comboBoxcam.Size = new System.Drawing.Size(242, 23);
            this.comboBoxcam.TabIndex = 7;
            this.comboBoxcam.SelectedIndexChanged += new System.EventHandler(this.comboBoxcam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 608);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "摄像头：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 655);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "分辨率：";
            // 
            // comboBoxreso
            // 
            this.comboBoxreso.FormattingEnabled = true;
            this.comboBoxreso.Location = new System.Drawing.Point(12, 674);
            this.comboBoxreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxreso.Name = "comboBoxreso";
            this.comboBoxreso.Size = new System.Drawing.Size(242, 23);
            this.comboBoxreso.TabIndex = 11;
            this.comboBoxreso.SelectedIndexChanged += new System.EventHandler(this.comboBoxreso_SelectedIndexChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonstopyolo);
            this.groupBox2.Controls.Add(this.buttonstartyolo);
            this.groupBox2.Controls.Add(this.buttonloadyolo);
            this.groupBox2.Location = new System.Drawing.Point(429, 556);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(548, 87);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YOLOv4框架";
            // 
            // buttonstopyolo
            // 
            this.buttonstopyolo.Enabled = false;
            this.buttonstopyolo.Location = new System.Drawing.Point(368, 29);
            this.buttonstopyolo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonstopyolo.Name = "buttonstopyolo";
            this.buttonstopyolo.Size = new System.Drawing.Size(165, 29);
            this.buttonstopyolo.TabIndex = 0;
            this.buttonstopyolo.Text = "停止检测";
            this.buttonstopyolo.UseVisualStyleBackColor = true;
            this.buttonstopyolo.Click += new System.EventHandler(this.buttonstopyolo_Click);
            // 
            // buttonstartyolo
            // 
            this.buttonstartyolo.Enabled = false;
            this.buttonstartyolo.Location = new System.Drawing.Point(193, 29);
            this.buttonstartyolo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonstartyolo.Name = "buttonstartyolo";
            this.buttonstartyolo.Size = new System.Drawing.Size(165, 29);
            this.buttonstartyolo.TabIndex = 0;
            this.buttonstartyolo.Text = "开始检测";
            this.buttonstartyolo.UseVisualStyleBackColor = true;
            this.buttonstartyolo.Click += new System.EventHandler(this.buttonstartyolo_Click);
            // 
            // buttonloadyolo
            // 
            this.buttonloadyolo.Location = new System.Drawing.Point(16, 29);
            this.buttonloadyolo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonloadyolo.Name = "buttonloadyolo";
            this.buttonloadyolo.Size = new System.Drawing.Size(165, 29);
            this.buttonloadyolo.TabIndex = 0;
            this.buttonloadyolo.Text = "载入模型";
            this.buttonloadyolo.UseVisualStyleBackColor = true;
            this.buttonloadyolo.Click += new System.EventHandler(this.buttonloadyolo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 706);
            this.Controls.Add(this.textBoxnum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxcam);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonopencam);
            this.Controls.Add(this.buttonphoto);
            this.Controls.Add(this.pictureBoxphoto);
            this.Controls.Add(this.videoSourcePlayer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxinfo);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Target Recognition Console";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxphoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBoxinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.PictureBox pictureBoxphoto;
        private System.Windows.Forms.Button buttonphoto;
        private System.Windows.Forms.Button buttonopencam;
        private System.Windows.Forms.ComboBox comboBoxcam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxreso;
        private System.Windows.Forms.RadioButton radioButtontarget;
        private System.Windows.Forms.RadioButton radioButtonface;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonstop;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Button buttonload;
        private System.Windows.Forms.TextBox textBoxnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonstopyolo;
        private System.Windows.Forms.Button buttonstartyolo;
        private System.Windows.Forms.Button buttonloadyolo;
    }
}

