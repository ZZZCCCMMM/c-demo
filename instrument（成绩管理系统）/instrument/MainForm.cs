using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace instrument
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripMenuItemStudent_Click(object sender, EventArgs e)
        {
            Config.ConnecctionString = "Data Source =(local)\\SQLEXPRESS;Database = Test; User Id =sa; Pwd = sa_12345678";
            StudentForm studentForm = new StudentForm()
            {
                MdiParent = this
            };
            studentForm.Show(); 
            
        }
    }
}
