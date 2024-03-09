using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mymatch
{
    public partial class Form1 : Form
    {
       
        bool ReadImage = false;
        bool gencircle1 = false;
        bool hv_Model = false;
        HWindow hWindow;
        HObject readImg, gencircle, ho_ModelContours2, imgduce, ho_ModelContours4, ho_ContoursAffinTrans, circle;
        HTuple Width1, Height1, row1, column1, radius1, ModalId, area, hv_row, hv_column, HHomMat2D1, 
            hv_Row, hv_Column, hv_Angle2, hv_Score2, hv_i, HHomMat2Dity, HHomMat2Dtrans, HHomMat2Drotate;

        private void matchbtn_Click(object sender, EventArgs e)
        {
            matchbtn.Enabled = true;
            HOperatorSet.GenEmptyObj(out ho_ContoursAffinTrans);
            ho_ContoursAffinTrans.Dispose();
            if (createbtn.Enabled == true && hv_Model == true)
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
                    HOperatorSet.SetColor(hWindow, "red");
                    HOperatorSet.SetDraw(hWindow, "margin");
                    HOperatorSet.DispObj(circle, hWindow);

                    HOperatorSet.SetColor(hWindow, "black");
                    HOperatorSet.SetTposition(hWindow, hv_Row.TupleSelect(hv_i), hv_Column.TupleSelect(hv_i));
                    HOperatorSet.WriteString(hWindow, hv_i + 1);



                 }
                HOperatorSet.SetColor(hWindow, "red");
                HOperatorSet.SetTposition(hWindow, 140, 20);
                HOperatorSet.WriteString(hWindow, "匹配数量：" + (int)(new HTuple(hv_Score2.TupleLength())) + "个");
            }
            else
            {
                MessageBox.Show("请先创建模板");
            }
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            
            if (ROIbtn.Enabled == true && gencircle1 == true)
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
                    HOperatorSet.DispObj(readImg, hWindow);
                    HOperatorSet.DispObj(ho_ModelContours4, hWindow);
                }
                catch (Exception)
                {

                    MessageBox.Show("ROI没有保存！\n请绘制完成后，按右击保存！");
                }

            }
            else
            {
                MessageBox.Show("请先绘制ROI！");
            }
            matchbtn.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readbtn.Enabled = true;
            createbtn.Enabled = false;
            ROIbtn.Enabled = false;
            matchbtn.Enabled = false;
            hWindow = hWindowControl1.HalconWindow;
            HOperatorSet.ReadImage(out readImg, "目标定位背景");
            HOperatorSet.GetImageSize(readImg,out Width1 ,out Height1);
            HOperatorSet.SetPart(hWindow, 0, 0, Height1 - 1, Width1 -1);
            HOperatorSet.DispObj(readImg, hWindow);
            readImg.Dispose();
        }

        private void ROIbtn_Click(object sender, EventArgs e)
        {
            
            HOperatorSet.GenEmptyObj(out gencircle);
            gencircle.Dispose();
            if (readbtn.Enabled = true && ReadImage == true)
            {
                HOperatorSet.DispObj(readImg, hWindow);
                HOperatorSet.SetColor(hWindow, "green");
                HOperatorSet.SetDraw(hWindow, "margin");
                HOperatorSet.SetLineWidth(hWindow, 3);
                HOperatorSet.DrawCircle(hWindow, out row1, out column1, out radius1);
                HOperatorSet.GenCircle(out gencircle,row1,column1,radius1);
                gencircle1 = true;
                HOperatorSet.DispObj(gencircle, hWindow);
            }
            else
            {
                MessageBox.Show("请重新绘制ROI");
            }
            createbtn.Enabled = true;
        }

        private void readbtn_Click(object sender, EventArgs e)
        {
            HOperatorSet.GenEmptyObj(out readImg);
            readImg.Dispose();
            using(OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "图片";
                dlg.Multiselect = false;
                dlg.Filter = "图像|*.bmp; *.pcx; *.png; *.jpg; *.gif;*.tif; *.ico; *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf;";
                if (dlg.ShowDialog()==DialogResult.OK)
                {
                    HOperatorSet.ReadImage(out readImg, dlg.FileName);
                    HOperatorSet.GetImageSize(readImg, out Width1, out Height1);
                    HOperatorSet.SetPart(hWindow, 0, 0, Height1 - 1, Width1 - 1);
                    HOperatorSet.DispObj(readImg, hWindow);
                    ReadImage = true;
                }
                else
                { 
                    MessageBox.Show("请选择图象 !");
                }

            }
            ROIbtn.Enabled = true;
        }
    }
}
