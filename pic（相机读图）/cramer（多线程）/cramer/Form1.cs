using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace cramer
{
    public partial class Form1 : Form
    {
        private double RowDown;//鼠标按下时的行坐标
        private double ColDown;//鼠标按下时的列坐标
        bool ReadImage = false;
        bool gencircle1 = false;
        bool hv_Model = false;
        HObject readImg, gencircle, ho_ModelContours2, imgduce, ho_ModelContours4, ho_ContoursAffinTrans, circle;
        HTuple Width1, Height1, row1, column1, radius1, ModalId, area, hv_row, hv_column, HHomMat2D1,
            hv_Row, hv_Column, hv_Angle2, hv_Score2, hv_i, HHomMat2Dity, HHomMat2Dtrans, HHomMat2Drotate;
        HTuple hv_AcqHandle = null;
        //halcon窗口句柄
        HTuple handle;
        //单采集的图像
        HObject image = null;
        //抓取图像的线程
        Thread brabT;
        //线程开关
        bool isRun = true;
        public Form1()
        {
            InitializeComponent();
            handle = hWindowControl1.HalconWindow;
            readbtn.Enabled = true;
            createbtn.Enabled = false;
            ROIbtn.Enabled = false;
            matchbtn.Enabled = false;
            handle = hWindowControl1.HalconWindow;
            HOperatorSet.ReadImage(out readImg, "目标定位背景");
            HOperatorSet.GetImageSize(readImg, out Width1, out Height1);
            HOperatorSet.SetPart(handle, 0, 0, Height1 - 1, Width1 - 1);
            HOperatorSet.DispObj(readImg, handle);
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            HOperatorSet.SetPart(handle, 0, 0, Height1 - 1, Width1 - 1);
            HOperatorSet.ClearWindow(handle);
            HOperatorSet.DispObj(readImg, handle);
        }

        private void hWindowControl1_HMouseMove(object sender, HMouseEventArgs e)
        {
            HTuple Row, Column, Button, pointGray;
            HOperatorSet.GetMposition(handle, out Row, out Column, out Button);              //获取当前鼠标的坐标值
            if (Height1 != null && (Row > 0 && Row < Height1) && (Column > 0 && Column < Width1)&& readImg == null)//设置3个条件项，防止程序崩溃。
            {
                HOperatorSet.GetGrayval(readImg, Row, Column, out pointGray);                 //获取当前点的灰度值
            }
            else
            {
                pointGray = "_";
            }
            String str = String.Format("Row:{0}  Column:{1}  Gray:{2}", Row, Column, pointGray); //格式化字符串
            label_xyRGB.Text = str;
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
            HOperatorSet.GetMposition(handle, out Row, out Col, out Button);
            HOperatorSet.GetPart(handle, out Row0, out Column0, out Row00, out Column00);
            Ht = Row00 - Row0;
            Wt = Column00 - Column0;
            if (Ht * Wt < 32000 * 32000 || Zoom == 1.5)//普通版halcon能处理的图像最大尺寸是32K*32K。如果无限缩小原图像，导致显示的图像超出限制，则会造成程序崩溃
            {
                r1 = (Row0 + ((1 - (1.0 / Zoom)) * (Row - Row0)));
                c1 = (Column0 + ((1 - (1.0 / Zoom)) * (Col - Column0)));
                r2 = r1 + (Ht / Zoom);
                c2 = c1 + (Wt / Zoom);
                HOperatorSet.SetPart(handle, r1, c1, r2, c2);
                HOperatorSet.ClearWindow(handle);
                HOperatorSet.DispObj(readImg, handle);
            }
        }

        private void hWindowControl1_HMouseUp(object sender, HMouseEventArgs e)
        {
            HTuple row1, col1, row2, col2, Row, Column, Button;
            HOperatorSet.GetMposition(handle, out Row, out Column, out Button);
            double RowMove = Row - RowDown;   //鼠标弹起时的行坐标减去按下时的行坐标，得到行坐标的移动值
            double ColMove = Column - ColDown;//鼠标弹起时的列坐标减去按下时的列坐标，得到列坐标的移动值
            HOperatorSet.GetPart(handle, out row1, out col1, out row2, out col2);//得到当前的窗口坐标
            HOperatorSet.SetPart(handle, row1 - RowMove, col1 - ColMove, row2 - RowMove, col2 - ColMove);//这里可能有些不好理解。以左上角原点为参考点
            HOperatorSet.ClearWindow(handle);
            if (Height1 != null)
            {
                HOperatorSet.DispObj(readImg, handle);
            }
            else
            {
                MessageBox.Show("请加载一张图片");
            }
        }

        private void hWindowControl1_HMouseDown(object sender, HMouseEventArgs e)
        {
            HTuple Row, Column, Button;
            HOperatorSet.GetMposition(handle, out Row, out Column, out Button);
            RowDown = Row;    // 鼠标按下时的行坐标
            ColDown = Column;
        }

        private void matchbtn_Click(object sender, EventArgs e)
        {
            hWindowControl1.Focus();
            matchbtn.Enabled = true;
            HOperatorSet.GenEmptyObj(out ho_ContoursAffinTrans);
            ho_ContoursAffinTrans.Dispose();
            if (createbtn.Enabled == true && hv_Model == true)
            {
                match();
            }
            else
            {
                MessageBox.Show("请先创建模板");
            }
            
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            hWindowControl1.Focus();
            if (ROIbtn.Enabled == true && gencircle1 == true)
            {
                model();
            }
            else
            {
                MessageBox.Show("请先绘制ROI！");
            }
            matchbtn.Enabled = true;
            
        }

        private void ROIbtn_Click(object sender, EventArgs e)
        {
            hWindowControl1.Focus();
            HOperatorSet.GenEmptyObj(out gencircle);
            gencircle.Dispose();
            if (readbtn.Enabled = true && ReadImage == true)
            {
                ROI();
            }
            else
            {
                MessageBox.Show("请重新绘制ROI");
            }
            createbtn.Enabled = true;
            
        }

        private void readbtn_Click(object sender, EventArgs e)
        {
            hWindowControl1.Focus();
            //清空窗口
            HOperatorSet.GenEmptyObj(out readImg);
            //释放内存
            readImg.Dispose();
            //打开图片路径
            using (OpenFileDialog ofg = new OpenFileDialog())
            {
                ofg.Title = "图片";
                ofg.Multiselect = false;
                ofg.Filter = "图像|*.bmp; *.pcx; *.png; *.jpg; *.gif;*.tif; *.ico; *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf";
                if (ofg.ShowDialog() == DialogResult.OK)
                {
                    //读取图像   readImg
                    HOperatorSet.ReadImage(out readImg, ofg.FileName);
                    //获取图像的大小
                    HOperatorSet.GetImageSize(readImg, out Width1, out Height1);
                    //图像居中显示
                    HOperatorSet.SetPart(handle, 0, 0, Height1 - 1, Width1 - 1);
                    //显示图像
                    HOperatorSet.DispObj(readImg, handle);
                    ReadImage = true;
                }
                else
                {
                    MessageBox.Show("请选择图像！");
                }
            }
            ROIbtn.Enabled = true;
        }
        //相机句柄


        //打开相机
        private void button1_Click(object sender, EventArgs e)
        {
            openCam();
            if (hv_AcqHandle == null)
            {
                return;
            }
            brabT = new Thread(brabImage);
            //开启线程并挂起它
            brabT.Start();
            brabT.Suspend();
        }
        //开始采集
        private void button2_Click(object sender, EventArgs e)
        {
            if (brabT != null)
            {
                //继续执行线程
                brabT.Resume();
            }

        }
        //停止采集
        private void button3_Click(object sender, EventArgs e)
        {
            if (brabT != null)
            {
                //暂停线程
                brabT.Suspend();
            }
        }

        //单采集
        private void button4_Click(object sender, EventArgs e)
        {
            HOperatorSet.GenEmptyObj(out readImg);
            readImg.Dispose();
            try
            {
                HOperatorSet.GrabImageStart(hv_AcqHandle, -1);

                //绑定窗口
                handle = hWindowControl1.HalconWindow;
                //异步采集图像
                HOperatorSet.GrabImage(out readImg, hv_AcqHandle);
                //获取图像的大小
                HOperatorSet.GetImageSize(readImg, out Width1, out Height1);
                //图像居中显示
                HOperatorSet.SetPart(handle, 0, 0, Height1, Width1);
                HOperatorSet.DispObj(readImg, handle);
                ReadImage = true;
                //ReadImage1.Dispose();
                //关闭相机
                HOperatorSet.CloseFramegrabber(hv_AcqHandle);
            }
            catch (Exception)
            {
                HOperatorSet.WriteString(handle, "相机打开失败！");
            }
        }

        //当窗口关闭时
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (brabT != null)
            {
                isRun = false;
                //brabT.Join();
                //继续执行线程
                //brabT.Resume();
                //终止多余线程
                brabT.Abort();
            }
        }


        //抓取图片线程
        private void brabImage()
        {
            HTuple w, h;
            HOperatorSet.GrabImage(out readImg, hv_AcqHandle);
            HOperatorSet.GetImageSize(readImg, out w, out h);
            HOperatorSet.SetPart(handle, 0, 0, h, w);
            HOperatorSet.DispImage(readImg, handle);
            //显示玩之后释放图片
            readImg.Dispose();
            
            while (isRun)
            {
                try
                {
                    HOperatorSet.GrabImage(out readImg, hv_AcqHandle);
                    if (readImg != null)
                    {
                        //HOperatorSet.GetImageSize(readImg, out w, out h);
                        //HOperatorSet.SetPart(handle, 0, 0, h, w);
                        //HOperatorSet.DispImage(readImg, handle);
                        //显示玩之后释放图片
                        HOperatorSet.DispObj(readImg, handle);
                        ReadImage = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("相机已断开,请重新连接！");
                    Thread.Sleep(3000);
                    openCam();
                }

            }
            HOperatorSet.CloseFramegrabber(hv_AcqHandle);
        }
        private void match()
        {
            HOperatorSet.FindShapeModel(readImg, ModalId, (new HTuple(-180)).TupleRad()
                 , (new HTuple(180)).TupleRad(), 0.6, 0, 0.5, "least_squares", 5, 1.0, out hv_Row,
                out hv_Column, out hv_Angle2, out hv_Score2);
            for (hv_i = 0; (int)hv_i <= (int)(new HTuple(hv_Score2.TupleLength())) - 1; hv_i = (int)hv_i + 1)
            {
                HOperatorSet.HomMat2dIdentity(out HHomMat2Dity);
                HOperatorSet.HomMat2dTranslate(HHomMat2Dity, hv_Row.TupleSelect(hv_i), hv_Column.TupleSelect(hv_i), out HHomMat2Dtrans);
                HOperatorSet.HomMat2dRotate(HHomMat2Dtrans, hv_Angle2.TupleSelect(hv_i), hv_Row.TupleSelect(hv_i), hv_Column.TupleSelect(hv_i), out HHomMat2Drotate);
                HOperatorSet.AffineTransContourXld(ho_ModelContours4, out ho_ContoursAffinTrans, HHomMat2Drotate);
                HOperatorSet.GenCircle(out circle, hv_Row.TupleSelect(hv_i), hv_Column.TupleSelect(hv_i), 30);
                HOperatorSet.SetColor(handle, "red");
                HOperatorSet.SetDraw(handle, "margin");
                HOperatorSet.DispObj(circle, handle);
                HOperatorSet.SetColor(handle, "black");
                HOperatorSet.SetTposition(handle, hv_Row.TupleSelect(hv_i), hv_Column.TupleSelect(hv_i));
                HOperatorSet.WriteString(handle, hv_i + 1);
            }
            HOperatorSet.SetColor(handle, "red");
            HOperatorSet.SetTposition(handle, 140, 20);
            HOperatorSet.WriteString(handle, "匹配数量：" + (int)(new HTuple(hv_Score2.TupleLength())) + "个");
            
        }
        private void model()
        {
            //清空图像、释放内存
            HOperatorSet.GenEmptyObj(out ho_ModelContours4);
            ho_ModelContours4.Dispose();
            //清空图像、释放内存
            HOperatorSet.GenEmptyObj(out imgduce);
            imgduce.Dispose();
            try
            {
                //填充ROI区域（抠图）并输出  ImageReduce
                HOperatorSet.ReduceDomain(readImg, gencircle, out imgduce);
                //创建模板
                HOperatorSet.CreateShapeModel(imgduce, "auto", (new HTuple(-180)).TupleRad()
                , (new HTuple(180)).TupleRad(), "auto", "auto", "use_polarity", "auto", "auto",
                out ModalId);
                //获取轮廓
                HOperatorSet.GetShapeModelContours(out ho_ModelContours2, ModalId, 1);
                hv_Model = true;
                HOperatorSet.AreaCenter(gencircle, out area, out hv_row, out hv_column);
                HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_row, hv_column, 0, out HHomMat2D1);
                HOperatorSet.AffineTransContourXld(ho_ModelContours2, out ho_ModelContours4,
                    HHomMat2D1);
                HOperatorSet.DispObj(readImg, handle);
                HOperatorSet.DispObj(ho_ModelContours4, handle);
            }
            catch (Exception)
            {
                MessageBox.Show("ROI没有保存！\n请绘制完成后，按右击保存！");
            }
            
        }
        private void ROI()
        {
            HOperatorSet.DispObj(readImg, handle);
            HOperatorSet.SetColor(handle, "green");
            HOperatorSet.SetDraw(handle, "margin");
            HOperatorSet.SetLineWidth(handle, 3);
            HOperatorSet.DrawCircle(handle, out row1, out column1, out radius1);
            HOperatorSet.GenCircle(out gencircle, row1, column1, radius1);
            gencircle1 = true;
            HOperatorSet.DispObj(gencircle, handle); 
        }
        
        private void openCam()
        {
            //释放相机句柄
            HOperatorSet.CloseAllFramegrabbers();
            try
            {
                //连接相机
                HOperatorSet.OpenFramegrabber("GigEVision2", 0, 0, 0, 0, 0, 0, "progressive",
                -1, "default", -1, "false", "default", "c42f90fe697d_Hikrobot_MVCE10031GM",
                0, -1, out hv_AcqHandle);
                HOperatorSet.SetFramegrabberParam(hv_AcqHandle, "[Consumer]exposure", 40000);
                HOperatorSet.SetFramegrabberParam(hv_AcqHandle, "[Consumer]gain", 2.0156);
                readbtn.Enabled = true;
                createbtn.Enabled = true;
                ROIbtn.Enabled = true;
                matchbtn.Enabled = true;
                MessageBox.Show("相机连接成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("相机连接失败！");
            }
        }
    }

}
