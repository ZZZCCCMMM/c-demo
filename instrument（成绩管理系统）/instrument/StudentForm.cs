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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void SetTreeViewStudents(TreeNode node)
        {
            if (node == null)
            {
                DataTable dt = SQL.GetTable("SELECT [Id], [Organs] FRO [dbo].[Organs] WHERE [ParentId] = 0");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    treeViewStudent.Nodes.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString());
                }
            }
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            Config.OpenDataGridViewDoubleBuffer(dataGridViewScore);
            SetTreeViewStudents(null);
        }
    }
}
