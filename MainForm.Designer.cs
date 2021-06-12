
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
            this.radioButtongo = new System.Windows.Forms.RadioButton();
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButtonnotrt = new System.Windows.Forms.RadioButton();
            this.radioButtonrealtime = new System.Windows.Forms.RadioButton();
            this.buttonabout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxcuda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxphoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(639, 18);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(651, 226);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // textBoxinfo
            // 
            this.textBoxinfo.Location = new System.Drawing.Point(983, 258);
            this.textBoxinfo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxinfo.Multiline = true;
            this.textBoxinfo.Name = "textBoxinfo";
            this.textBoxinfo.Size = new System.Drawing.Size(307, 292);
            this.textBoxinfo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtongo);
            this.groupBox1.Controls.Add(this.buttonstop);
            this.groupBox1.Controls.Add(this.buttonstart);
            this.groupBox1.Controls.Add(this.buttonload);
            this.groupBox1.Controls.Add(this.radioButtonface);
            this.groupBox1.Controls.Add(this.radioButtontarget);
            this.groupBox1.Location = new System.Drawing.Point(519, 330);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(443, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dlib框架";
            // 
            // radioButtongo
            // 
            this.radioButtongo.AutoSize = true;
            this.radioButtongo.Checked = true;
            this.radioButtongo.Location = new System.Drawing.Point(56, 59);
            this.radioButtongo.Name = "radioButtongo";
            this.radioButtongo.Size = new System.Drawing.Size(71, 16);
            this.radioButtongo.TabIndex = 6;
            this.radioButtongo.TabStop = true;
            this.radioButtongo.Text = "目标检测";
            this.radioButtongo.UseVisualStyleBackColor = true;
            this.radioButtongo.CheckedChanged += new System.EventHandler(this.radioButtongo_CheckedChanged);
            // 
            // buttonstop
            // 
            this.buttonstop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonstop.Enabled = false;
            this.buttonstop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonstop.Location = new System.Drawing.Point(294, 23);
            this.buttonstop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonstop.Name = "buttonstop";
            this.buttonstop.Size = new System.Drawing.Size(112, 20);
            this.buttonstop.TabIndex = 2;
            this.buttonstop.Text = "停止检测";
            this.buttonstop.UseVisualStyleBackColor = false;
            this.buttonstop.Click += new System.EventHandler(this.buttonstop_Click);
            // 
            // buttonstart
            // 
            this.buttonstart.BackColor = System.Drawing.Color.OldLace;
            this.buttonstart.Enabled = false;
            this.buttonstart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonstart.Location = new System.Drawing.Point(157, 23);
            this.buttonstart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(112, 20);
            this.buttonstart.TabIndex = 1;
            this.buttonstart.Text = "开始检测";
            this.buttonstart.UseVisualStyleBackColor = false;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // buttonload
            // 
            this.buttonload.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonload.Location = new System.Drawing.Point(15, 23);
            this.buttonload.Margin = new System.Windows.Forms.Padding(2);
            this.buttonload.Name = "buttonload";
            this.buttonload.Size = new System.Drawing.Size(112, 20);
            this.buttonload.TabIndex = 0;
            this.buttonload.Text = "载入模型";
            this.buttonload.UseVisualStyleBackColor = false;
            this.buttonload.Click += new System.EventHandler(this.buttonload_Click);
            // 
            // radioButtonface
            // 
            this.radioButtonface.AutoSize = true;
            this.radioButtonface.Location = new System.Drawing.Point(174, 59);
            this.radioButtonface.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonface.Name = "radioButtonface";
            this.radioButtonface.Size = new System.Drawing.Size(71, 16);
            this.radioButtonface.TabIndex = 4;
            this.radioButtonface.Text = "人脸检测";
            this.radioButtonface.UseVisualStyleBackColor = true;
            this.radioButtonface.CheckedChanged += new System.EventHandler(this.radioButtonface_CheckedChanged);
            // 
            // radioButtontarget
            // 
            this.radioButtontarget.AutoSize = true;
            this.radioButtontarget.Location = new System.Drawing.Point(294, 59);
            this.radioButtontarget.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtontarget.Name = "radioButtontarget";
            this.radioButtontarget.Size = new System.Drawing.Size(71, 16);
            this.radioButtontarget.TabIndex = 5;
            this.radioButtontarget.Text = "汽车检测";
            this.radioButtontarget.UseVisualStyleBackColor = true;
            this.radioButtontarget.CheckedChanged += new System.EventHandler(this.radioButtontarget_CheckedChanged);
            // 
            // textBoxnum
            // 
            this.textBoxnum.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxnum.Location = new System.Drawing.Point(352, 29);
            this.textBoxnum.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnum.Name = "textBoxnum";
            this.textBoxnum.ReadOnly = true;
            this.textBoxnum.Size = new System.Drawing.Size(41, 14);
            this.textBoxnum.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "目标数量：";
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonexit.Location = new System.Drawing.Point(813, 520);
            this.buttonexit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(112, 20);
            this.buttonexit.TabIndex = 3;
            this.buttonexit.Text = "退出程序";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Location = new System.Drawing.Point(11, 18);
            this.videoSourcePlayer.Margin = new System.Windows.Forms.Padding(2);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(616, 226);
            this.videoSourcePlayer.TabIndex = 3;
            this.videoSourcePlayer.Text = "videoSourcePlayer1";
            this.videoSourcePlayer.VideoSource = null;
            // 
            // pictureBoxphoto
            // 
            this.pictureBoxphoto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBoxphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxphoto.Location = new System.Drawing.Point(8, 18);
            this.pictureBoxphoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxphoto.Name = "pictureBoxphoto";
            this.pictureBoxphoto.Size = new System.Drawing.Size(263, 101);
            this.pictureBoxphoto.TabIndex = 4;
            this.pictureBoxphoto.TabStop = false;
            // 
            // buttonphoto
            // 
            this.buttonphoto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonphoto.Enabled = false;
            this.buttonphoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonphoto.Location = new System.Drawing.Point(75, 131);
            this.buttonphoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonphoto.Name = "buttonphoto";
            this.buttonphoto.Size = new System.Drawing.Size(80, 23);
            this.buttonphoto.TabIndex = 5;
            this.buttonphoto.Text = "拍照";
            this.buttonphoto.UseVisualStyleBackColor = false;
            this.buttonphoto.Click += new System.EventHandler(this.buttonphoto_Click);
            // 
            // buttonopencam
            // 
            this.buttonopencam.BackColor = System.Drawing.Color.OldLace;
            this.buttonopencam.Enabled = false;
            this.buttonopencam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonopencam.Location = new System.Drawing.Point(160, 90);
            this.buttonopencam.Margin = new System.Windows.Forms.Padding(2);
            this.buttonopencam.Name = "buttonopencam";
            this.buttonopencam.Size = new System.Drawing.Size(112, 20);
            this.buttonopencam.TabIndex = 6;
            this.buttonopencam.Text = "打开";
            this.buttonopencam.UseVisualStyleBackColor = false;
            this.buttonopencam.Click += new System.EventHandler(this.buttonopencam_Click);
            // 
            // comboBoxcam
            // 
            this.comboBoxcam.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxcam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxcam.FormattingEnabled = true;
            this.comboBoxcam.Location = new System.Drawing.Point(85, 22);
            this.comboBoxcam.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxcam.Name = "comboBoxcam";
            this.comboBoxcam.Size = new System.Drawing.Size(182, 20);
            this.comboBoxcam.TabIndex = 7;
            this.comboBoxcam.SelectedIndexChanged += new System.EventHandler(this.comboBoxcam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "摄像头：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "分辨率：";
            // 
            // comboBoxreso
            // 
            this.comboBoxreso.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxreso.FormattingEnabled = true;
            this.comboBoxreso.Location = new System.Drawing.Point(85, 54);
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
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Controls.Add(this.buttonstopyolo);
            this.groupBox2.Controls.Add(this.buttonstartyolo);
            this.groupBox2.Controls.Add(this.buttonloadyolo);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(519, 437);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(443, 70);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YOLOv4框架";
            // 
            // buttonstopyolo
            // 
            this.buttonstopyolo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonstopyolo.Enabled = false;
            this.buttonstopyolo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonstopyolo.Location = new System.Drawing.Point(294, 27);
            this.buttonstopyolo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonstopyolo.Name = "buttonstopyolo";
            this.buttonstopyolo.Size = new System.Drawing.Size(112, 20);
            this.buttonstopyolo.TabIndex = 0;
            this.buttonstopyolo.Text = "停止检测";
            this.buttonstopyolo.UseVisualStyleBackColor = false;
            this.buttonstopyolo.Click += new System.EventHandler(this.buttonstopyolo_Click);
            // 
            // buttonstartyolo
            // 
            this.buttonstartyolo.BackColor = System.Drawing.Color.OldLace;
            this.buttonstartyolo.Enabled = false;
            this.buttonstartyolo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonstartyolo.Location = new System.Drawing.Point(157, 27);
            this.buttonstartyolo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonstartyolo.Name = "buttonstartyolo";
            this.buttonstartyolo.Size = new System.Drawing.Size(112, 20);
            this.buttonstartyolo.TabIndex = 0;
            this.buttonstartyolo.Text = "开始检测";
            this.buttonstartyolo.UseVisualStyleBackColor = false;
            this.buttonstartyolo.Click += new System.EventHandler(this.buttonstartyolo_Click);
            // 
            // buttonloadyolo
            // 
            this.buttonloadyolo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonloadyolo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonloadyolo.Location = new System.Drawing.Point(15, 27);
            this.buttonloadyolo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonloadyolo.Name = "buttonloadyolo";
            this.buttonloadyolo.Size = new System.Drawing.Size(112, 20);
            this.buttonloadyolo.TabIndex = 0;
            this.buttonloadyolo.Text = "载入模型";
            this.buttonloadyolo.UseVisualStyleBackColor = false;
            this.buttonloadyolo.Click += new System.EventHandler(this.buttonloadyolo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonopencam);
            this.groupBox3.Controls.Add(this.comboBoxcam);
            this.groupBox3.Controls.Add(this.comboBoxreso);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(11, 430);
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
            this.groupBox4.Location = new System.Drawing.Point(318, 258);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(180, 127);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "视频文件采集";
            // 
            // buttonpause
            // 
            this.buttonpause.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonpause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonpause.Location = new System.Drawing.Point(35, 89);
            this.buttonpause.Margin = new System.Windows.Forms.Padding(2);
            this.buttonpause.Name = "buttonpause";
            this.buttonpause.Size = new System.Drawing.Size(112, 20);
            this.buttonpause.TabIndex = 0;
            this.buttonpause.Text = "停止播放";
            this.buttonpause.UseVisualStyleBackColor = false;
            this.buttonpause.Click += new System.EventHandler(this.buttonpause_Click);
            // 
            // buttonplayvideo
            // 
            this.buttonplayvideo.BackColor = System.Drawing.Color.OldLace;
            this.buttonplayvideo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonplayvideo.Location = new System.Drawing.Point(35, 57);
            this.buttonplayvideo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonplayvideo.Name = "buttonplayvideo";
            this.buttonplayvideo.Size = new System.Drawing.Size(112, 20);
            this.buttonplayvideo.TabIndex = 0;
            this.buttonplayvideo.Text = "开始播放";
            this.buttonplayvideo.UseVisualStyleBackColor = false;
            this.buttonplayvideo.Click += new System.EventHandler(this.buttonplayvideo_Click);
            // 
            // buttonopenvideo
            // 
            this.buttonopenvideo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonopenvideo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonopenvideo.Location = new System.Drawing.Point(35, 26);
            this.buttonopenvideo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonopenvideo.Name = "buttonopenvideo";
            this.buttonopenvideo.Size = new System.Drawing.Size(112, 20);
            this.buttonopenvideo.TabIndex = 0;
            this.buttonopenvideo.Text = "选择视频文件";
            this.buttonopenvideo.UseVisualStyleBackColor = false;
            this.buttonopenvideo.Click += new System.EventHandler(this.buttonopenvideo_Click);
            // 
            // buttonopenimg
            // 
            this.buttonopenimg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonopenimg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonopenimg.Location = new System.Drawing.Point(35, 32);
            this.buttonopenimg.Margin = new System.Windows.Forms.Padding(2);
            this.buttonopenimg.Name = "buttonopenimg";
            this.buttonopenimg.Size = new System.Drawing.Size(112, 20);
            this.buttonopenimg.TabIndex = 0;
            this.buttonopenimg.Text = "打开图片";
            this.buttonopenimg.UseVisualStyleBackColor = false;
            this.buttonopenimg.Click += new System.EventHandler(this.buttonopenimg_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxauto);
            this.groupBox5.Controls.Add(this.labelopen);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.buttonopeniimgf);
            this.groupBox5.Controls.Add(this.buttonopenimg);
            this.groupBox5.Location = new System.Drawing.Point(318, 407);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(180, 142);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "图片文件采集";
            // 
            // checkBoxauto
            // 
            this.checkBoxauto.AutoSize = true;
            this.checkBoxauto.Location = new System.Drawing.Point(39, 92);
            this.checkBoxauto.Name = "checkBoxauto";
            this.checkBoxauto.Size = new System.Drawing.Size(108, 16);
            this.checkBoxauto.TabIndex = 3;
            this.checkBoxauto.Text = "文件夹自动检测";
            this.checkBoxauto.UseVisualStyleBackColor = true;
            // 
            // labelopen
            // 
            this.labelopen.AutoSize = true;
            this.labelopen.Location = new System.Drawing.Point(102, 119);
            this.labelopen.Name = "labelopen";
            this.labelopen.Size = new System.Drawing.Size(17, 12);
            this.labelopen.TabIndex = 2;
            this.labelopen.Text = "无";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "已打开：";
            // 
            // buttonopeniimgf
            // 
            this.buttonopeniimgf.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonopeniimgf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonopeniimgf.Location = new System.Drawing.Point(35, 61);
            this.buttonopeniimgf.Margin = new System.Windows.Forms.Padding(2);
            this.buttonopeniimgf.Name = "buttonopeniimgf";
            this.buttonopeniimgf.Size = new System.Drawing.Size(112, 20);
            this.buttonopeniimgf.TabIndex = 0;
            this.buttonopeniimgf.Text = "打开文件夹";
            this.buttonopeniimgf.UseVisualStyleBackColor = false;
            this.buttonopeniimgf.Click += new System.EventHandler(this.buttonopeniimgf_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonsavephoto);
            this.groupBox6.Controls.Add(this.buttonphoto);
            this.groupBox6.Controls.Add(this.pictureBoxphoto);
            this.groupBox6.Location = new System.Drawing.Point(11, 258);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(290, 165);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "拍照";
            // 
            // buttonsavephoto
            // 
            this.buttonsavephoto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonsavephoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsavephoto.Location = new System.Drawing.Point(191, 131);
            this.buttonsavephoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsavephoto.Name = "buttonsavephoto";
            this.buttonsavephoto.Size = new System.Drawing.Size(80, 23);
            this.buttonsavephoto.TabIndex = 6;
            this.buttonsavephoto.Text = "保存照片";
            this.buttonsavephoto.UseVisualStyleBackColor = false;
            this.buttonsavephoto.Click += new System.EventHandler(this.buttonsavephoto_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButtonnotrt);
            this.groupBox7.Controls.Add(this.radioButtonrealtime);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.textBoxnum);
            this.groupBox7.Location = new System.Drawing.Point(519, 258);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(443, 57);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "检测模式";
            // 
            // radioButtonnotrt
            // 
            this.radioButtonnotrt.AutoSize = true;
            this.radioButtonnotrt.Checked = true;
            this.radioButtonnotrt.Location = new System.Drawing.Point(157, 28);
            this.radioButtonnotrt.Name = "radioButtonnotrt";
            this.radioButtonnotrt.Size = new System.Drawing.Size(83, 16);
            this.radioButtonnotrt.TabIndex = 1;
            this.radioButtonnotrt.TabStop = true;
            this.radioButtonnotrt.Text = "非实时检测";
            this.radioButtonnotrt.UseVisualStyleBackColor = true;
            // 
            // radioButtonrealtime
            // 
            this.radioButtonrealtime.AutoSize = true;
            this.radioButtonrealtime.Location = new System.Drawing.Point(56, 28);
            this.radioButtonrealtime.Name = "radioButtonrealtime";
            this.radioButtonrealtime.Size = new System.Drawing.Size(71, 16);
            this.radioButtonrealtime.TabIndex = 0;
            this.radioButtonrealtime.Text = "实时检测";
            this.radioButtonrealtime.UseVisualStyleBackColor = true;
            // 
            // buttonabout
            // 
            this.buttonabout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonabout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonabout.Location = new System.Drawing.Point(676, 520);
            this.buttonabout.Name = "buttonabout";
            this.buttonabout.Size = new System.Drawing.Size(112, 20);
            this.buttonabout.TabIndex = 18;
            this.buttonabout.Text = "关于";
            this.buttonabout.UseVisualStyleBackColor = false;
            this.buttonabout.Click += new System.EventHandler(this.buttonabout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "CUDA：";
            // 
            // textBoxcuda
            // 
            this.textBoxcuda.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxcuda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxcuda.Location = new System.Drawing.Point(578, 526);
            this.textBoxcuda.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxcuda.Name = "textBoxcuda";
            this.textBoxcuda.ReadOnly = true;
            this.textBoxcuda.Size = new System.Drawing.Size(41, 14);
            this.textBoxcuda.TabIndex = 7;
            this.textBoxcuda.Text = "未启用";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1299, 559);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonabout);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.textBoxcuda);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButtonnotrt;
        private System.Windows.Forms.RadioButton radioButtonrealtime;
        private System.Windows.Forms.Button buttonabout;
        private System.Windows.Forms.RadioButton radioButtongo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxcuda;
    }
}

