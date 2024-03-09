using duotai.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duotai.Models
{
    public class Fans : IUsb
    {
        public string EquipmentName { get; set ; }
        public Fans(string equipmentName)
        {
            EquipmentName= equipmentName;
            AddEquipment();
        }
        public void AddEquipment()
        {
            MessageBox.Show($"{EquipmentName}插入了");
        }

        public void EquipmentWorking()
        {
            InsertUPan();
        }
        private void InsertUPan()
        {
            MessageBox.Show($"{EquipmentName}打开了");
        }
    }
}
