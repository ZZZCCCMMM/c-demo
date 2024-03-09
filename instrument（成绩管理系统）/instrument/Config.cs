using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace instrument
{
    internal class Config
    {
        private static string _connecction_string;
        public static string ConnecctionString { 
            get {  return _connecction_string; }
            set {  _connecction_string = value;}
        }


        public static void OpenDataGridViewDoubleBuffer(DataGridView dgv)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, true, null);
        }
    }
}
