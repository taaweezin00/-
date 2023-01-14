namespace โปรแกรมสำหรับบันทึกข้อมูลนักศึกษา
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2info finfo = new Form2info(this);
            finfo.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells["rn"].Value = (e.RowIndex + 1).ToString();
        }
    }
}