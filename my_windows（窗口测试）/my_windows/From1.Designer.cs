namespace my_windows
{
    partial class From1
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.hWindowControl1 = new HalconDotNet.HWindowControl();
            this.selectbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.label_xyRGB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(17, 40);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(468, 368);
            this.hWindowControl1.TabIndex = 0;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(468, 368);
            this.hWindowControl1.HMouseMove += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseMove);
            this.hWindowControl1.HMouseDown += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseDown);
            this.hWindowControl1.HMouseUp += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseUp);
            this.hWindowControl1.HMouseWheel += new HalconDotNet.HMouseEventHandler(this.hWindowControl1_HMouseWheel);
            // 
            // selectbtn
            // 
            this.selectbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectbtn.Location = new System.Drawing.Point(17, 425);
            this.selectbtn.Name = "selectbtn";
            this.selectbtn.Size = new System.Drawing.Size(83, 40);
            this.selectbtn.TabIndex = 1;
            this.selectbtn.Text = "选择图像";
            this.selectbtn.UseVisualStyleBackColor = true;
            this.selectbtn.Click += new System.EventHandler(this.selectbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetbtn.Location = new System.Drawing.Point(397, 424);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(88, 41);
            this.resetbtn.TabIndex = 2;
            this.resetbtn.Text = "适应图像";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // label_xyRGB
            // 
            this.label_xyRGB.AutoSize = true;
            this.label_xyRGB.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_xyRGB.Location = new System.Drawing.Point(13, 14);
            this.label_xyRGB.Name = "label_xyRGB";
            this.label_xyRGB.Size = new System.Drawing.Size(56, 23);
            this.label_xyRGB.TabIndex = 3;
            this.label_xyRGB.Text = "位置";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectbtn);
            this.panel1.Controls.Add(this.label_xyRGB);
            this.panel1.Controls.Add(this.resetbtn);
            this.panel1.Controls.Add(this.hWindowControl1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 489);
            this.panel1.TabIndex = 4;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(773, 489);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HalconDotNet.HWindowControl hWindowControl1;
        private System.Windows.Forms.Button selectbtn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Label label_xyRGB;
        private System.Windows.Forms.Panel panel1;
    }
}
