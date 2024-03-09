using HalconDotNet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pic
{
    public partial class Form1 : Form
    {
        HWindow hw_home;
        HObject ReadImage1;
        HTuple Width1;
        HTuple Height1;
        HObject ho_Image;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HTuple hv_AcqHandle = new HTuple();
            HOperatorSet.InfoFramegrabber("GigEVision2", "device",  out HTuple information, out HTuple valueList);
            HOperatorSet.OpenFramegrabber("GigEVision2", 0, 0, 0, 0, 0, 0, "progressive",
                -1, "default", -1, "false", "default", "c42f90fe697d_Hikrobot_MVCE10031GM",
                0, -1, out hv_AcqHandle);
            HOperatorSet.SetFramegrabberParam(hv_AcqHandle, "[Consumer]exposure", 130026.0);
            HOperatorSet.SetFramegrabberParam(hv_AcqHandle, "[Consumer]gain", 6.2825);
            HOperatorSet.GrabImageStart(hv_AcqHandle, -1);
            HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle, -1);
            HOperatorSet.DispObj(ho_Image, hw_home);
        }

        private void hWindowControl1_Load(object sender, EventArgs e)
        {
            hw_home = hWindowControl1.HalconWindow;
            //给窗口句柄的背景
            HOperatorSet.ReadImage(out ReadImage1, "目标定位背景");
            HOperatorSet.GetImageSize(ReadImage1, out Width1, out Height1);
            HOperatorSet.SetPart(hw_home, 0, 0, Height1 - 1, Width1 - 1);
            HOperatorSet.DispObj(ReadImage1, hw_home);
            
        }
    }
}
