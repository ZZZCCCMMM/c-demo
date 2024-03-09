using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duotai.Interface
{
    public interface IUsb
    {
        /// <summary>
        /// 设备名称
        /// </summary>
        public string EquipmentName { get; set; }
        /// <summary>
        /// 添加时触发
        /// </summary>
        public void AddEquipment();

        /// <summary>
        /// 正在工作
        /// </summary>
        public void EquipmentWorking();
        
    }
}
