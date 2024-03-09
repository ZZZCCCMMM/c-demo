namespace cramer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.hWindowControl1 = new HalconDotNet.HWindowControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ROIbtn = new System.Windows.Forms.Button();
            this.createbtn = new System.Windows.Forms.Button();
            this.matchbtn = new System.Windows.Forms.Button();
            this.readbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.label_xyRGB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(13, 13);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(621, 404);
            this.hWindowControl1.TabIndex = 0;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(621, 404);
            this.hWindowControl1.HMouseMove += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseMove);
            this.hWindowControl1.HMouseDown += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseDown);
            this.hWindowControl1.HMouseUp += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseUp);
            this.hWindowControl1.HMouseWheel += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseWheel);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "打开相机";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(649, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "实时采集";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(649, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "停止采集";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(649, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "单采集";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ROIbtn
            // 
            this.ROIbtn.Location = new System.Drawing.Point(764, 24);
            this.ROIbtn.Name = "ROIbtn";
            this.ROIbtn.Size = new System.Drawing.Size(90, 49);
            this.ROIbtn.TabIndex = 5;
            this.ROIbtn.Text = "ROI";
            this.ROIbtn.UseVisualStyleBackColor = true;
            this.ROIbtn.Click += new System.EventHandler(this.ROIbtn_Click);
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(764, 162);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(90, 48);
            this.createbtn.TabIndex = 6;
            this.createbtn.Text = "创建模板";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // matchbtn
            // 
            this.matchbtn.Location = new System.Drawing.Point(764, 229);
            this.matchbtn.Name = "matchbtn";
            this.matchbtn.Size = new System.Drawing.Size(90, 43);
            this.matchbtn.TabIndex = 7;
            this.matchbtn.Text = "测试匹配";
            this.matchbtn.UseVisualStyleBackColor = true;
            this.matchbtn.Click += new System.EventHandler(this.matchbtn_Click);
            // 
            // readbtn
            // 
            this.readbtn.Location = new System.Drawing.Point(764, 92);
            this.readbtn.Name = "readbtn";
            this.readbtn.Size = new System.Drawing.Size(90, 42);
            this.readbtn.TabIndex = 8;
            this.readbtn.Text = "读图";
            this.readbtn.UseVisualStyleBackColor = true;
            this.readbtn.Click += new System.EventHandler(this.readbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(649, 311);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(205, 63);
            this.resetbtn.TabIndex = 9;
            this.resetbtn.Text = "适应窗口";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // label_xyRGB
            // 
            this.label_xyRGB.AutoSize = true;
            this.label_xyRGB.Location = new System.Drawing.Point(13, 448);
            this.label_xyRGB.Name = "label_xyRGB";
            this.label_xyRGB.Size = new System.Drawing.Size(37, 15);
            this.label_xyRGB.TabIndex = 10;
            this.label_xyRGB.Text = "位置";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 475);
            this.Controls.Add(this.label_xyRGB);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.readbtn);
            this.Controls.Add(this.matchbtn);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.ROIbtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hWindowControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HWindowControl hWindowControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ROIbtn;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button matchbtn;
        private System.Windows.Forms.Button readbtn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Label label_xyRGB;
    }
}

