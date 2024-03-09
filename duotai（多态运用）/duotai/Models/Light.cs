using duotai.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duotai.Models
{
    public class Light : IUsb
    {
        public string EquipmentName { get; set ; }
        public Light(string equipmentName)
        {
            EquipmentName=equipmentName;
            AddEquipment();
        }
        public void AddEquipment()
        {
            MessageBox.Show($"{EquipmentName}插入了");
        }

        public void EquipmentWorking()
        {
            OpenLight();
        }

        private void OpenLight()
        {
            MessageBox.Show($"{EquipmentName}正在亮");
        }
    }
}
