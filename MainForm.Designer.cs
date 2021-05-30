
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonpause = new System.Windows.Forms.Button();
            this.buttonplayvideo = new System.Windows.Forms.Button();
            this.buttonopenvideo = new System.Windows.Forms.Button();
            this.buttonopenimg = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxauto = new System.Windows.Forms.CheckBox();
            this.labelopen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonopeniimgf = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonsavephoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxphoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(817, 18);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(473, 315);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // textBoxinfo
            // 
            this.textBoxinfo.Location = new System.Drawing.Point(817, 345);
            this.textBoxinfo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxinfo.Multiline = true;
            this.textBoxinfo.Name = "textBoxinfo";
            this.textBoxinfo.Size = new System.Drawing.Size(473, 270);
            this.textBoxinfo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonstop);
            this.groupBox1.Controls.Add(this.buttonstart);
            this.groupBox1.Controls.Add(this.buttonload);
            this.groupBox1.Controls.Add(this.radioButtonface);
            this.groupBox1.Controls.Add(this.radioButtontarget);
            this.groupBox1.Location = new System.Drawing.Point(322, 336);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(473, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dlib框架";
            // 
            // buttonstop
            // 
            this.buttonstop.Enabled = false;
            this.buttonstop.Location = new System.Drawing.Point(324, 29);
            this.buttonstop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonstop.Name = "buttonstop";
            this.buttonstop.Size = new System.Drawing.Size(124, 23);
            this.buttonstop.TabIndex = 2;
            this.buttonstop.Text = "停止检测";
            this.buttonstop.UseVisualStyleBackColor = true;
            this.buttonstop.Click += new System.EventHandler(this.buttonstop_Click);
            // 
            // buttonstart
            // 
            this.buttonstart.Enabled = false;
            this.buttonstart.Location = new System.Drawing.Point(172, 29);
            this.buttonstart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(124, 23);
            this.buttonstart.TabIndex = 1;
            this.buttonstart.Text = "开始检测";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // buttonload
            // 
            this.buttonload.Location = new System.Drawing.Point(12, 29);
            this.buttonload.Margin = new System.Windows.Forms.Padding(2);
            this.buttonload.Name = "buttonload";
            this.buttonload.Size = new System.Drawing.Size(124, 23);
            this.buttonload.TabIndex = 0;
            this.buttonload.Text = "载入模型";
            this.buttonload.UseVisualStyleBackColor = true;
            this.buttonload.Click += new System.EventHandler(this.buttonload_Click);
            // 
            // radioButtonface
            // 
            this.radioButtonface.AutoSize = true;
            this.radioButtonface.Location = new System.Drawing.Point(172, 68);
            this.radioButtonface.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonface.Name = "radioButtonface";
            this.radioButtonface.Size = new System.Drawing.Size(71, 16);
            this.radioButtonface.TabIndex = 4;
            this.radioButtonface.Text = "人脸识别";
            this.radioButtonface.UseVisualStyleBackColor = true;
            this.radioButtonface.CheckedChanged += new System.EventHandler(this.radioButtonface_CheckedChanged);
            // 
            // radioButtontarget
            // 
            this.radioButtontarget.AutoSize = true;
            this.radioButtontarget.Checked = true;
            this.radioButtontarget.Location = new System.Drawing.Point(73, 68);
            this.radioButtontarget.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtontarget.Name = "radioButtontarget";
            this.radioButtontarget.Size = new System.Drawing.Size(71, 16);
            this.radioButtontarget.TabIndex = 5;
            this.radioButtontarget.TabStop = true;
            this.radioButtontarget.Text = "目标检测";
            this.radioButtontarget.UseVisualStyleBackColor = true;
            this.radioButtontarget.CheckedChanged += new System.EventHandler(this.radioButtontarget_CheckedChanged);
            // 
            // textBoxnum
            // 
            this.textBoxnum.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxnum.Location = new System.Drawing.Point(425, 562);
            this.textBoxnum.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnum.Name = "textBoxnum";
            this.textBoxnum.ReadOnly = true;
            this.textBoxnum.Size = new System.Drawing.Size(41, 14);
            this.textBoxnum.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 563);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "目标数量：";
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(646, 557);
            this.buttonexit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(124, 23);
            this.buttonexit.TabIndex = 3;
            this.buttonexit.Text = "退出程序";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Location = new System.Drawing.Point(322, 18);
            this.videoSourcePlayer.Margin = new System.Windows.Forms.Padding(2);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(473, 315);
            this.videoSourcePlayer.TabIndex = 3;
            this.videoSourcePlayer.Text = "videoSourcePlayer1";
            this.videoSourcePlayer.VideoSource = null;
            // 
            // pictureBoxphoto
            // 
            this.pictureBoxphoto.Location = new System.Drawing.Point(8, 18);
            this.pictureBoxphoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxphoto.Name = "pictureBoxphoto";
            this.pictureBoxphoto.Size = new System.Drawing.Size(263, 146);
            this.pictureBoxphoto.TabIndex = 4;
            this.pictureBoxphoto.TabStop = false;
            // 
            // buttonphoto
            // 
            this.buttonphoto.Enabled = false;
            this.buttonphoto.Location = new System.Drawing.Point(75, 174);
            this.buttonphoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonphoto.Name = "buttonphoto";
            this.buttonphoto.Size = new System.Drawing.Size(80, 23);
            this.buttonphoto.TabIndex = 5;
            this.buttonphoto.Text = "拍照";
            this.buttonphoto.UseVisualStyleBackColor = true;
            this.buttonphoto.Click += new System.EventHandler(this.buttonphoto_Click);
            // 
            // buttonopencam
            // 
            this.buttonopencam.Enabled = false;
            this.buttonopencam.Location = new System.Drawing.Point(160, 82);
            this.buttonopencam.Margin = new System.Windows.Forms.Padding(2);
            this.buttonopencam.Name = "buttonopencam";
            this.buttonopencam.Size = new System.Drawing.Size(112, 20);
            this.buttonopencam.TabIndex = 6;
            this.buttonopencam.Text = "打开";
            this.buttonopencam.UseVisualStyleBackColor = true;
            this.buttonopencam.Click += new System.EventHandler(this.buttonopencam_Click);
            // 
            // comboBoxcam
            // 
            this.comboBoxcam.FormattingEnabled = true;
            this.comboBoxcam.Location = new System.Drawing.Point(85, 14);
            this.comboBoxcam.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxcam.Name = "comboBoxcam";
            this.comboBoxcam.Size = new System.Drawing.Size(182, 20);
            this.comboBoxcam.TabIndex = 7;
            this.comboBoxcam.SelectedIndexChanged += new System.EventHandler(this.comboBoxcam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "摄像头：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "分辨率：";
            // 
            // comboBoxreso
            // 
            this.comboBoxreso.FormattingEnabled = true;
            this.comboBoxreso.Location = new System.Drawing.Point(85, 46);
            this.comboBoxreso.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxreso.Name = "comboBoxreso";
            this.comboBoxreso.Size = new System.Drawing.Size(182, 20);
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
            this.groupBox2.Location = new System.Drawing.Point(322, 460);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(473, 70);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YOLOv4框架";
            // 
            // buttonstopyolo
            // 
            this.buttonstopyolo.Enabled = false;
            this.buttonstopyolo.Location = new System.Drawing.Point(324, 23);
            this.buttonstopyolo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonstopyolo.Name = "buttonstopyolo";
            this.buttonstopyolo.Size = new System.Drawing.Size(124, 23);
            this.buttonstopyolo.TabIndex = 0;
            this.buttonstopyolo.Text = "停止检测";
            this.buttonstopyolo.UseVisualStyleBackColor = true;
            this.buttonstopyolo.Click += new System.EventHandler(this.buttonstopyolo_Click);
            // 
            // buttonstartyolo
            // 
            this.buttonstartyolo.Enabled = false;
            this.buttonstartyolo.Location = new System.Drawing.Point(172, 23);
            this.buttonstartyolo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonstartyolo.Name = "buttonstartyolo";
            this.buttonstartyolo.Size = new System.Drawing.Size(124, 23);
            this.buttonstartyolo.TabIndex = 0;
            this.buttonstartyolo.Text = "开始检测";
            this.buttonstartyolo.UseVisualStyleBackColor = true;
            this.buttonstartyolo.Click += new System.EventHandler(this.buttonstartyolo_Click);
            // 
            // buttonloadyolo
            // 
            this.buttonloadyolo.Location = new System.Drawing.Point(12, 23);
            this.buttonloadyolo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonloadyolo.Name = "buttonloadyolo";
            this.buttonloadyolo.Size = new System.Drawing.Size(124, 23);
            this.buttonloadyolo.TabIndex = 0;
            this.buttonloadyolo.Text = "载入模型";
            this.buttonloadyolo.UseVisualStyleBackColor = true;
            this.buttonloadyolo.Click += new System.EventHandler(this.buttonloadyolo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonopencam);
            this.groupBox3.Controls.Add(this.comboBoxcam);
            this.groupBox3.Controls.Add(this.comboBoxreso);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(9, 239);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(291, 120);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "摄像头采集";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonpause);
            this.groupBox4.Controls.Add(this.buttonplayvideo);
            this.groupBox4.Controls.Add(this.buttonopenvideo);
            this.groupBox4.Location = new System.Drawing.Point(10, 370);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(290, 121);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "视频文件采集";
            // 
            // buttonpause
            // 
            this.buttonpause.Location = new System.Drawing.Point(159, 77);
            this.buttonpause.Margin = new System.Windows.Forms.Padding(2);
            this.buttonpause.Name = "buttonpause";
            this.buttonpause.Size = new System.Drawing.Size(112, 20);
            this.buttonpause.TabIndex = 0;
            this.buttonpause.Text = "停止播放";
            this.buttonpause.UseVisualStyleBackColor = true;
            this.buttonpause.Click += new System.EventHandler(this.buttonpause_Click);
            // 
            // buttonplayvideo
            // 
            this.buttonplayvideo.Location = new System.Drawing.Point(159, 35);
            this.buttonplayvideo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonplayvideo.Name = "buttonplayvideo";
            this.buttonplayvideo.Size = new System.Drawing.Size(112, 20);
            this.buttonplayvideo.TabIndex = 0;
            this.buttonplayvideo.Text = "开始播放";
            this.buttonplayvideo.UseVisualStyleBackColor = true;
            this.buttonplayvideo.Click += new System.EventHandler(this.buttonplayvideo_Click);
            // 
            // buttonopenvideo
            // 
            this.buttonopenvideo.Location = new System.Drawing.Point(17, 35);
            this.buttonopenvideo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonopenvideo.Name = "buttonopenvideo";
            this.buttonopenvideo.Size = new System.Drawing.Size(112, 20);
            this.buttonopenvideo.TabIndex = 0;
            this.buttonopenvideo.Text = "选择视频文件";
            this.buttonopenvideo.UseVisualStyleBackColor = true;
            this.buttonopenvideo.Click += new System.EventHandler(this.buttonopenvideo_Click);
            // 
            // buttonopenimg
            // 
            this.buttonopenimg.Location = new System.Drawing.Point(17, 33);
            this.buttonopenimg.Margin = new System.Windows.Forms.Padding(2);
            this.buttonopenimg.Name = "buttonopenimg";
            this.buttonopenimg.Size = new System.Drawing.Size(112, 20);
            this.buttonopenimg.TabIndex = 0;
            this.buttonopenimg.Text = "打开图片";
            this.buttonopenimg.UseVisualStyleBackColor = true;
            this.buttonopenimg.Click += new System.EventHandler(this.buttonopenimg_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxauto);
            this.groupBox5.Controls.Add(this.labelopen);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.buttonopeniimgf);
            this.groupBox5.Controls.Add(this.buttonopenimg);
            this.groupBox5.Location = new System.Drawing.Point(9, 512);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(291, 99);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "图片文件采集";
            // 
            // checkBoxauto
            // 
            this.checkBoxauto.AutoSize = true;
            this.checkBoxauto.Location = new System.Drawing.Point(159, 72);
            this.checkBoxauto.Name = "checkBoxauto";
            this.checkBoxauto.Size = new System.Drawing.Size(108, 16);
            this.checkBoxauto.TabIndex = 3;
            this.checkBoxauto.Text = "文件夹自动检测";
            this.checkBoxauto.UseVisualStyleBackColor = true;
            // 
            // labelopen
            // 
            this.labelopen.AutoSize = true;
            this.labelopen.Location = new System.Drawing.Point(74, 73);
            this.labelopen.Name = "labelopen";
            this.labelopen.Size = new System.Drawing.Size(17, 12);
            this.labelopen.TabIndex = 2;
            this.labelopen.Text = "无";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "已打开：";
            // 
            // buttonopeniimgf
            // 
            this.buttonopeniimgf.Location = new System.Drawing.Point(159, 33);
            this.buttonopeniimgf.Margin = new System.Windows.Forms.Padding(2);
            this.buttonopeniimgf.Name = "buttonopeniimgf";
            this.buttonopeniimgf.Size = new System.Drawing.Size(112, 20);
            this.buttonopeniimgf.TabIndex = 0;
            this.buttonopeniimgf.Text = "打开文件夹";
            this.buttonopeniimgf.UseVisualStyleBackColor = true;
            this.buttonopeniimgf.Click += new System.EventHandler(this.buttonopeniimgf_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonsavephoto);
            this.groupBox6.Controls.Add(this.buttonphoto);
            this.groupBox6.Controls.Add(this.pictureBoxphoto);
            this.groupBox6.Location = new System.Drawing.Point(10, 18);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(290, 209);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "拍照";
            // 
            // buttonsavephoto
            // 
            this.buttonsavephoto.Location = new System.Drawing.Point(191, 174);
            this.buttonsavephoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsavephoto.Name = "buttonsavephoto";
            this.buttonsavephoto.Size = new System.Drawing.Size(80, 23);
            this.buttonsavephoto.TabIndex = 6;
            this.buttonsavephoto.Text = "保存照片";
            this.buttonsavephoto.UseVisualStyleBackColor = true;
            this.buttonsavephoto.Click += new System.EventHandler(this.buttonsavephoto_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1299, 622);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBoxnum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.videoSourcePlayer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxinfo);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Target Recognition Console";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxphoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonpause;
        private System.Windows.Forms.Button buttonopenimg;
        private System.Windows.Forms.Button buttonplayvideo;
        private System.Windows.Forms.Button buttonopenvideo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonsavephoto;
        private System.Windows.Forms.Button buttonopeniimgf;
        private System.Windows.Forms.CheckBox checkBoxauto;
        private System.Windows.Forms.Label labelopen;
        private System.Windows.Forms.Label label4;
    }
}

