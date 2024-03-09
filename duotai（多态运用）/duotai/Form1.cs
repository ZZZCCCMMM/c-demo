using duotai.Interface;
using duotai.Models;

namespace duotai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDuoTai_Click(object sender, EventArgs e)
        {
            IUsb uPan = new Upan("U≈Ã");
            uPan.EquipmentWorking();
            IUsb fans = new Fans("∑Á…»");
            fans.EquipmentWorking();
            IUsb light = new Light("µÁµ∆");
            light.EquipmentWorking();
        }
    }
}