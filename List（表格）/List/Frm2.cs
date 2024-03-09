using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.ShowDialog();
        }
    }
}
