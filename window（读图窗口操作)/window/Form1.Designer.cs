namespace window
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
            this.bt_openImage = new System.Windows.Forms.Button();
            this.label_xyRGB = new System.Windows.Forms.Label();
            this.bt_ResetImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(13, 31);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(572, 407);
            this.hWindowControl1.TabIndex = 0;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(572, 407);
            this.hWindowControl1.HMouseMove += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseMove);
            this.hWindowControl1.HMouseDown += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseDown);
            this.hWindowControl1.HMouseUp += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseUp);
            this.hWindowControl1.HMouseWheel += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseWheel);
            // 
            // bt_openImage
            // 
            this.bt_openImage.Location = new System.Drawing.Point(637, 88);
            this.bt_openImage.Name = "bt_openImage";
            this.bt_openImage.Size = new System.Drawing.Size(94, 54);
            this.bt_openImage.TabIndex = 1;
            this.bt_openImage.Text = "选择图片";
            this.bt_openImage.UseVisualStyleBackColor = true;
            this.bt_openImage.Click += new System.EventHandler(this.bt_openImage_Click);
            // 
            // label_xyRGB
            // 
            this.label_xyRGB.AutoSize = true;
            this.label_xyRGB.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_xyRGB.Location = new System.Drawing.Point(12, 13);
            this.label_xyRGB.Name = "label_xyRGB";
            this.label_xyRGB.Size = new System.Drawing.Size(37, 15);
            this.label_xyRGB.TabIndex = 2;
            this.label_xyRGB.Text = "位置";
            // 
            // bt_ResetImage
            // 
            this.bt_ResetImage.Location = new System.Drawing.Point(637, 240);
            this.bt_ResetImage.Name = "bt_ResetImage";
            this.bt_ResetImage.Size = new System.Drawing.Size(94, 56);
            this.bt_ResetImage.TabIndex = 3;
            this.bt_ResetImage.Text = "适应窗口";
            this.bt_ResetImage.UseVisualStyleBackColor = true;
            this.bt_ResetImage.Click += new System.EventHandler(this.bt_ResetImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_ResetImage);
            this.Controls.Add(this.label_xyRGB);
            this.Controls.Add(this.bt_openImage);
            this.Controls.Add(this.hWindowControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HWindowControl hWindowControl1;
        private System.Windows.Forms.Button bt_openImage;
        private System.Windows.Forms.Label label_xyRGB;
        private System.Windows.Forms.Button bt_ResetImage;
    }
}

