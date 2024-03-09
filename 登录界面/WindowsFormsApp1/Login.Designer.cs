namespace WindowsFormsApp1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserId = new System.Windows.Forms.Label();
            this.Pwd = new System.Windows.Forms.Label();
            this.Logs = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.Loginvtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.Location = new System.Drawing.Point(25, 35);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(52, 15);
            this.UserId.TabIndex = 0;
            this.UserId.Text = "用户名";
            // 
            // Pwd
            // 
            this.Pwd.AutoSize = true;
            this.Pwd.Location = new System.Drawing.Point(25, 89);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(37, 15);
            this.Pwd.TabIndex = 0;
            this.Pwd.Text = "密码";
            // 
            // Logs
            // 
            this.Logs.AutoSize = true;
            this.Logs.Location = new System.Drawing.Point(48, 129);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(39, 15);
            this.Logs.TabIndex = 0;
            this.Logs.Text = "Logs";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(110, 35);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 25);
            this.textName.TabIndex = 1;
            // 
            // textPwd
            // 
            this.textPwd.Location = new System.Drawing.Point(110, 79);
            this.textPwd.Name = "textPwd";
            this.textPwd.Size = new System.Drawing.Size(100, 25);
            this.textPwd.TabIndex = 1;
            // 
            // Loginvtn
            // 
            this.Loginvtn.Location = new System.Drawing.Point(16, 168);
            this.Loginvtn.Name = "Loginvtn";
            this.Loginvtn.Size = new System.Drawing.Size(75, 23);
            this.Loginvtn.TabIndex = 2;
            this.Loginvtn.Text = "登录";
            this.Loginvtn.UseVisualStyleBackColor = true;
            this.Loginvtn.Click += new System.EventHandler(this.Loginvtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(135, 168);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "退出";
            this.exitbtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Loginvtn);
            this.panel1.Controls.Add(this.Logs);
            this.panel1.Controls.Add(this.textPwd);
            this.panel1.Controls.Add(this.exitbtn);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.UserId);
            this.panel1.Controls.Add(this.Pwd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 246);
            this.panel1.TabIndex = 3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 246);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Label Pwd;
        private System.Windows.Forms.Label Logs;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.Button Loginvtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Panel panel1;
    }
}