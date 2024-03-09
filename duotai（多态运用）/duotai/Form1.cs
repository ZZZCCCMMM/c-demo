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
            IUsb uPan = new Upan("U��");
            uPan.EquipmentWorking();
            IUsb fans = new Fans("����");
            fans.EquipmentWorking();
            IUsb light = new Light("���");
            light.EquipmentWorking();
        }
    }
}