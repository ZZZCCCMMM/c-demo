namespace List
{
    public partial class Form1 : Form
    {
        public List<Person> PerList;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBinding_Click(object sender, EventArgs e)
        {
            PerList = new List<Person>();
            PerList.Add(new Person() { Age = 11, Id = 1, Name = "z" });
            PerList.Add(new Person() { Age = 12, Id = 2, Name = "c" });
            PerList.Add(new Person() { Age = 14, Id = 3, Name = "m" });
            PerList.Add(new Person() { Age = 13, Id = 4, Name = "j" });
            dataGridView1.DataSource = PerList;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex=e.RowIndex;
            if (PerList != null)
            {
                dataGridView1.DataSource = new List<Person>();
                
                PerList.RemoveAt(rowIndex);
                dataGridView1.DataSource = PerList;
            }

        }
    }
}