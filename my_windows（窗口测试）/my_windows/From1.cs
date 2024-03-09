using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;

namespace my_windows
{
    public partial class UserControl1: UserControl
    {
        HTuple WindowID, ImageWidth, ImageHeight;
        private double RowDown;//鼠标按下时的行坐标
        private double ColDown;//鼠标按下时的列坐标
        private new AutoAdaptWindowsSize AutoSize;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AutoSize = new AutoAdaptWindowsSize(this);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {//窗体大小改变事件
            if (AutoSize != null) // 一定加这个判断，电脑缩放布局不是100%的时候，会报错
            {
                AutoSize.FormSizeChanged();
            }
        }
        private void hWindowControl1_HMouseDown(object sender, HMouseEventArgs e)
        {
            HTuple Row, Column, Button;
            HOperatorSet.GetMposition(WindowID, out Row, out Column, out Button);
            RowDown = Row;    // 鼠标按下时的行坐标
            ColDown = Column;
        }

        private void hWindowControl1_HMouseMove(object sender, HMouseEventArgs e)
        {
            HTuple Row, Column, Button, pointGray;
            HOperatorSet.GetMposition(WindowID, out Row, out Column, out Button);              //获取当前鼠标的坐标值
            if (ImageHeight != null && (Row > 0 && Row < ImageHeight) && (Column > 0 && Column < ImageWidth))//设置3个条件项，防止程序崩溃。
            {
                HOperatorSet.GetGrayval(ho_image, Row, Column, out pointGray);                 //获取当前点的灰度值
            }
            else
            {
                pointGray = "_";
            }
            String str = String.Format("Row:{0}  Column:{1}  Gray:{2}", Row, Column, pointGray); //格式化字符串
            label_xyRGB.Text = str;
        
    }

        private void hWindowControl1_HMouseUp(object sender, HMouseEventArgs e)
        {
            HTuple row1, col1, row2, col2, Row, Column, Button;
            HOperatorSet.GetMposition(WindowID, out Row, out Column, out Button);
            double RowMove = Row - RowDown;   //鼠标弹起时的行坐标减去按下时的行坐标，得到行坐标的移动值
            double ColMove = Column - ColDown;//鼠标弹起时的列坐标减去按下时的列坐标，得到列坐标的移动值
            HOperatorSet.GetPart(WindowID, out row1, out col1, out row2, out col2);//得到当前的窗口坐标
            HOperatorSet.SetPart(WindowID, row1 - RowMove, col1 - ColMove, row2 - RowMove, col2 - ColMove);//这里可能有些不好理解。以左上角原点为参考点
            HOperatorSet.ClearWindow(WindowID);
            if (ImageHeight != null)
            {
                HOperatorSet.DispObj(ho_image, WindowID);
            }
            else
            {
                MessageBox.Show("请加载一张图片");
            }
        }

        private void hWindowControl1_HMouseWheel(object sender, HMouseEventArgs e)
        {
            HTuple Zoom, Row, Col, Button;
            HTuple Row0, Column0, Row00, Column00, Ht, Wt, r1, c1, r2, c2;
            if (e.Delta > 0)
            {
                Zoom = 1.5;
            }
            else
            {
                Zoom = 0.5;
            }
            HOperatorSet.GetMposition(WindowID, out Row, out Col, out Button);
            HOperatorSet.GetPart(WindowID, out Row0, out Column0, out Row00, out Column00);
            Ht = Row00 - Row0;
            Wt = Column00 - Column0;
            if (Ht * Wt < 32000 * 32000 || Zoom == 1.5)//普通版halcon能处理的图像最大尺寸是32K*32K。如果无限缩小原图像，导致显示的图像超出限制，则会造成程序崩溃
            {
                r1 = (Row0 + ((1 - (1.0 / Zoom)) * (Row - Row0)));
                c1 = (Column0 + ((1 - (1.0 / Zoom)) * (Col - Column0)));
                r2 = r1 + (Ht / Zoom);
                c2 = c1 + (Wt / Zoom);
                HOperatorSet.SetPart(WindowID, r1, c1, r2, c2);
                HOperatorSet.ClearWindow(WindowID);
                HOperatorSet.DispObj(ho_image, WindowID);
            }
        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            hWindowControl1.Focus();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "所有图像文件 | *.bmp; *.pcx; *.png; *.jpg; *.gif;*.tif; *.ico; *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                HTuple ImagePath = openFileDialog.FileName;
                HOperatorSet.ReadImage(out ho_image, ImagePath);
            }
            HOperatorSet.GetImageSize(ho_image, out ImageWidth, out ImageHeight);
            HOperatorSet.SetPart(WindowID, 0, 0, ImageHeight, ImageWidth);
            HOperatorSet.DispObj(ho_image, WindowID);
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            HOperatorSet.SetPart(WindowID, 0, 0, ImageHeight - 1, ImageWidth - 1);
            HOperatorSet.ClearWindow(WindowID);
            HOperatorSet.DispObj(ho_image, WindowID);
        }

        HObject ho_image;      //图像变量
        public UserControl1()
        {
            InitializeComponent();
            WindowID = hWindowControl1.HalconWindow;
        }
    }
}
