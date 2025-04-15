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
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void bai2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int sum = num + num2;
            MessageBox.Show("The sum is: " + sum.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int diff = num - num2;
            MessageBox.Show("The difference is: " + diff.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int prod = num * num2;
            MessageBox.Show("The product is: " + prod.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int div = num / num2;
            MessageBox.Show("The quotient is: " + div.ToString());
        }
    }
}
