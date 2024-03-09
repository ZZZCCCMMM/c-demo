using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lne
{
    public partial class Form1 : Form
    {
        private static HImage m_image;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            hWindowControl1.Focus();

            hWindowControl1.HalconWindow.DrawLine(out double row1, out double column1, out double row2, out double column2);
            hWindowControl1.HalconWindow.SetColor("red");
            HTuple r1 = row1, c1 = column1, r2 = row2, c2 = column2;
            
            
            HMetrologyModel hMetrologyModel = new HMetrologyModel();

            HTuple measureLength1 = 10, measureLength2 = 10, measureSigma = 1, measureThreshold = 20; 
            HTuple genParamName = new HTuple();
            HTuple genParamValue = new HTuple();
            hMetrologyModel.AddMetrologyObjectLineMeasure(r1, c1, r2, c2, 
                measureLength1, measureLength2, measureSigma, measureThreshold, genParamName, genParamValue);
            hMetrologyModel.SetMetrologyObjectParam(0, "measure_length1", 60);
            hMetrologyModel.SetMetrologyObjectParam(0, "measure_length2", 20);
            hMetrologyModel.SetMetrologyObjectParam(0, "measure_distance", 10);
            hMetrologyModel.SetMetrologyObjectParam(0, "measure_threshold", 50);
            hMetrologyModel.SetMetrologyObjectParam(0, "measure_select", "first");
            hMetrologyModel.SetMetrologyObjectParam(0, "measure_transition", "positive");

            hMetrologyModel.ApplyMetrologyModel(m_image);
            HXLDCont contours = hMetrologyModel.GetMetrologyObjectMeasures(0, "all", out HTuple row, out HTuple column);
            
            HXLDCont xldCont = new HXLDCont();
            xldCont.GenCrossContourXld(row, column, 10, 0.7853);


            HTuple result = hMetrologyModel.GetMetrologyObjectResult(0, "all", "result_type", 
                new HTuple(new string [] { "row_begin", "column_begin", "row_end", "column_end" }));

            if (result.Length>0)
            {
                double row_begin = result[0];
                double row_end = result[1];
                double column_begin = result[2];
                double column_end = result[3];

                HXLDCont xldLine = new HXLDCont(new HTuple(new double[] { row_begin, row_end }),
                    new HTuple(new double[] { column_begin, column_end }));

                HOperatorSet.DispObj(m_image, hWindowControl1.HalconWindow);

                //HOperatorSet.DispObj(xldLine, hWindowControl1.HalconWindow);
                //hWindowControl1.HalconWindow.SetColor("blue");
                HOperatorSet.DispObj(contours, hWindowControl1.HalconWindow);
                hWindowControl1.HalconWindow.SetColor("green");
                HOperatorSet.DispObj(xldCont, hWindowControl1.HalconWindow);
                hWindowControl1.HalconWindow.SetColor("white");
            }
            else
            {
                MessageBox.Show("未检测到结果！");
            }


        }

        public void Form1_Load(object sender, EventArgs e)
        {
            m_image = new HImage(@"D:\procedure\halcon\HALCON-23.05-Progress\examples\images\printer_chip\printer_chip_01.png");
            m_image.GetImageSize(out int width, out int height);
            HOperatorSet.SetPart(hWindowControl1.HalconWindow, 0, 0, height + 1, width + 1);
            HOperatorSet.DispObj(m_image, hWindowControl1.HalconWindow);
        }

    }
}
