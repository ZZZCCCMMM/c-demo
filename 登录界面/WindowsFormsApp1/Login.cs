using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.WellKnownTypes.Field.Types;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Loginvtn_Click(object sender, EventArgs e)
        {
            string sqlStr = "SELECT * FROM table1 WHERE Pwd = @Pwd and Name = @Name";
            DataSet ds = MySqlHelper.ExecSqlQuery(sqlStr);
            if (ds != null && ds.Tables.Count > 0)
            {
                Form1 side = new Form1();
                side.Show();
                this.Hide();
            }
        }
    }
}
