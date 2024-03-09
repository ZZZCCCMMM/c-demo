using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace new_matching
{
    public partial class Form1 : Form
    {
        private HWindow window;
        private static HImage m_image;
        private HRegion modelRegion;
        private HShapeModel shapeModel;
        private HImage i_image;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createbtn.Enabled = true;
            inspectbtn.Enabled = false;
            window = hWindowControl1.HalconWindow;
            m_image = new HImage(@"D:\desk\相机标定\任务\matching\mat.png");
            m_image.GetImageSize(out int width, out int height);
            HOperatorSet.SetPart(window, 0, 0, height + 1, width + 1);
            HOperatorSet.DispObj(m_image, window);
            m_image.DispObj(window);
            window.SetDraw("margin");
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            hWindowControl1.Focus();
            hWindowControl1.HalconWindow.DrawCircle(out double row, out double column, out double radius);
            hWindowControl1.HalconWindow.SetColor("red");
            HTuple y = row, x = column, rad = radius;
            HRegion hRegion = new HRegion();
            hRegion.GenCircle(y, x, rad);

            HImage imgReduced;
            imgReduced = m_image.ReduceDomain(hRegion);

            createbtn.Enabled = false;
            window.SetColor("red");
            window.SetDraw("margin");
            window.SetLineWidth(3);

            imgReduced.InspectShapeModel(out modelRegion, 1, 30);

            // The default contructor creates an empty generic shape model.
            // This is different to many other constructors that create
            // an empty uninitialized instance.
            shapeModel = new HShapeModel();
            // In this example matching works with default parameters.
            // For illustration, we set angle_step to 1.0.
            shapeModel.SetGenericShapeModelParam("angle_step", new HTuple(1.0).TupleRad().D);
            shapeModel.TrainGenericShapeModel(imgReduced);

            window.SetColor("green");
            window.SetDraw("fill");
            modelRegion.DispObj(window);
            window.SetColor("blue");
            window.SetDraw("margin");
            inspectbtn.Enabled = true;

        }

        private void inspectbtn_Click(object sender, EventArgs e)
        {
            int numMatchResult, y = 0, x = 0;
            HGenericShapeModelResult result;
            i_image = new HImage(@"D:\desk\相机标定\任务\matching\mat1.png");
            i_image.GetImageSize(out int width_i, out int height_i);
            HOperatorSet.DispObj(i_image, hWindowControl1.HalconWindow);

            result = shapeModel.FindGenericShapeModel(i_image, out numMatchResult);
            if (numMatchResult == 1)
            {
                y = result.GetGenericShapeModelResult(0, "row");
                x = result.GetGenericShapeModelResult(0, "column");
                location.Text = $"X: {x}, Y: {y}".ToString();

            }
            
        }
    }
}
