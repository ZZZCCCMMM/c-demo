namespace mymatch
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
            this.readbtn = new System.Windows.Forms.Button();
            this.ROIbtn = new System.Windows.Forms.Button();
            this.createbtn = new System.Windows.Forms.Button();
            this.matchbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(13, 13);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(590, 425);
            this.hWindowControl1.TabIndex = 0;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(590, 425);
            // 
            // readbtn
            // 
            this.readbtn.Location = new System.Drawing.Point(646, 37);
            this.readbtn.Name = "readbtn";
            this.readbtn.Size = new System.Drawing.Size(81, 41);
            this.readbtn.TabIndex = 1;
            this.readbtn.Text = "读图";
            this.readbtn.UseVisualStyleBackColor = true;
            this.readbtn.Click += new System.EventHandler(this.readbtn_Click);
            // 
            // ROIbtn
            // 
            this.ROIbtn.Location = new System.Drawing.Point(646, 117);
            this.ROIbtn.Name = "ROIbtn";
            this.ROIbtn.Size = new System.Drawing.Size(81, 52);
            this.ROIbtn.TabIndex = 2;
            this.ROIbtn.Text = "画ROI";
            this.ROIbtn.UseVisualStyleBackColor = true;
            this.ROIbtn.Click += new System.EventHandler(this.ROIbtn_Click);
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(646, 223);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(81, 51);
            this.createbtn.TabIndex = 3;
            this.createbtn.Text = "创建模板";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // matchbtn
            // 
            this.matchbtn.Location = new System.Drawing.Point(646, 303);
            this.matchbtn.Name = "matchbtn";
            this.matchbtn.Size = new System.Drawing.Size(81, 51);
            this.matchbtn.TabIndex = 4;
            this.matchbtn.Text = "匹配模板";
            this.matchbtn.UseVisualStyleBackColor = true;
            this.matchbtn.Click += new System.EventHandler(this.matchbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.matchbtn);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.ROIbtn);
            this.Controls.Add(this.readbtn);
            this.Controls.Add(this.hWindowControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HalconDotNet.HWindowControl hWindowControl1;
        private System.Windows.Forms.Button readbtn;
        private System.Windows.Forms.Button ROIbtn;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button matchbtn;
    }
}

