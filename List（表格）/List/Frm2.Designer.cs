﻿namespace List
{
    partial class Frm2
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
            btnList = new Button();
            SuspendLayout();
            // 
            // btnList
            // 
            btnList.Location = new Point(384, 174);
            btnList.Name = "btnList";
            btnList.Size = new Size(94, 29);
            btnList.TabIndex = 0;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // Frm2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnList);
            Name = "Frm2";
            Text = "Frm2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnList;
    }
}