using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int _type = 0;
        public Form2(Person person, int type)
        {
            InitializeComponent();
            _type = type;
            if (person != null)
            {
                txtID.Text = person.ID.ToString();
                txtName.Text = person.UserName;
                txtQQ.Text = person.UserQQ;
            }
            if (type == 1)
            {
                button1.Text = "添加";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_type == 1)
            {
                Person person = new Person();
                person.UserName = txtName.Text;
                person.UserQQ = txtQQ.Text;
                string sqlStr = "insert into lqwvje001 (userName,userQQ) values(@userName,@userQQ)";
                MySqlParameter[] para = new MySqlParameter[]
                {
                    new MySqlParameter("@userName",person.UserName),
                    new MySqlParameter("@userQQ",person.UserQQ)
                };
                if (MySqlHelper.ExecSql(sqlStr, para))
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else
            {
                string sqlStr = "update lqwvje001 set UserName=@UserName ,UserQQ=@UserQQ where ID=@ID";
                MySqlParameter[] para = new MySqlParameter[]
               {
                    new MySqlParameter("@userName",txtName.Text),
                    new MySqlParameter("@userQQ",txtQQ.Text),
                    new MySqlParameter("@ID",txtID.Text)
               };
                if (MySqlHelper.ExecSql(sqlStr, para))
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }

            }
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
