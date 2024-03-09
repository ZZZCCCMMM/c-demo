namespace new_matching
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
            this.createbtn = new System.Windows.Forms.Button();
            this.inspectbtn = new System.Windows.Forms.Button();
            this.location = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(12, 39);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(619, 399);
            this.hWindowControl1.TabIndex = 0;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(619, 399);
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(676, 57);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(87, 38);
            this.createbtn.TabIndex = 1;
            this.createbtn.Text = "创建";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // inspectbtn
            // 
            this.inspectbtn.Location = new System.Drawing.Point(676, 202);
            this.inspectbtn.Name = "inspectbtn";
            this.inspectbtn.Size = new System.Drawing.Size(87, 51);
            this.inspectbtn.TabIndex = 2;
            this.inspectbtn.Text = "检测";
            this.inspectbtn.UseVisualStyleBackColor = true;
            this.inspectbtn.Click += new System.EventHandler(this.inspectbtn_Click);
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.location.Location = new System.Drawing.Point(12, 13);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(56, 23);
            this.location.TabIndex = 3;
            this.location.Text = "位置";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.location);
            this.Controls.Add(this.inspectbtn);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.hWindowControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HalconDotNet.HWindowControl hWindowControl1;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button inspectbtn;
        private System.Windows.Forms.Label location;
    }
}

