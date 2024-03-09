namespace instrument
{
    partial class MainForm
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemStudent,
            this.ToolStripMenuItemTeacher,
            this.ExitToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 28);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // ToolStripMenuItemStudent
            // 
            this.ToolStripMenuItemStudent.Name = "ToolStripMenuItemStudent";
            this.ToolStripMenuItemStudent.Size = new System.Drawing.Size(113, 24);
            this.ToolStripMenuItemStudent.Text = "学生成绩管理";
            this.ToolStripMenuItemStudent.Click += new System.EventHandler(this.ToolStripMenuItemStudent_Click);
            // 
            // ToolStripMenuItemTeacher
            // 
            this.ToolStripMenuItemTeacher.Name = "ToolStripMenuItemTeacher";
            this.ToolStripMenuItemTeacher.Size = new System.Drawing.Size(113, 24);
            this.ToolStripMenuItemTeacher.Text = "教师成绩管理";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "成绩管理";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStudent;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTeacher;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}

