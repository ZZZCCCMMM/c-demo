using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(new Person(), 1);
            form2.ShowDialog();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sqlStr = "select * from lqwvje001";
            DataSet ds = MySqlHelper.ExecSqlQuery(sqlStr);
            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.CurrentRow;
            if (dr == null)
            {
                MessageBox.Show("请选择要修改的数据");
                return;
            }
            Person person = new Person();
            person.ID = Dr2Int(Dr2Str(dr.Cells["ID"].Value));
            person.UserName = Dr2Str(dr.Cells["UserName"].Value);
            person.UserQQ = Dr2Str(dr.Cells["UserQQ"].Value);
            Form2 form2 = new Form2(person, 0);
            form2.ShowDialog();
        }
        public string Dr2Str(object o)
        {
            if (o != null)
            {
                return o.ToString();
            }
            return string.Empty;
        }
        public int Dr2Int(object o)
        {
            int result = 0;
            if (o != null)
            {
                int.TryParse(o.ToString(), out result);

            }
            return result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.CurrentRow;
            if (dr == null)
            {
                MessageBox.Show("请选择要删除的数据");
                return;
            }
            string sqlStr = "delete from lqwvje001 where id=@id";
            MySqlParameter para = new MySqlParameter("@id", dr.Cells["ID"].Value);
            if (MySqlHelper.ExecSql(sqlStr, para))
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }
    }
}
