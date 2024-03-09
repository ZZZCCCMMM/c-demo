namespace duotai
{
    partial class Form1
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
            btnDuoTai = new Button();
            SuspendLayout();
            // 
            // btnDuoTai
            // 
            btnDuoTai.Location = new Point(417, 144);
            btnDuoTai.Name = "btnDuoTai";
            btnDuoTai.Size = new Size(94, 29);
            btnDuoTai.TabIndex = 0;
            btnDuoTai.Text = "多态";
            btnDuoTai.UseVisualStyleBackColor = true;
            btnDuoTai.Click += btnDuoTai_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDuoTai);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDuoTai;
    }
}