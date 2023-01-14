using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace โปรแกรมสำหรับบันทึกข้อมูลนักศึกษา
{

    public partial class Form2info : Form
    {
        Form1 fgrid;
        public Form2info(Form1 fg)
        {
            InitializeComponent();
            this.fgrid = fg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fgrid.dataGridView1.Rows.Add(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text, textBox5.Text, textBox6.Text);
        }
    }
}
