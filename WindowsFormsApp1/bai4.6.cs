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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n = float.Parse(textBox1.Text);
            float sum = 0;
            while(n < 0)
            {
                MessageBox.Show("Vui lòng nhập số dương");
                n = float.Parse(textBox1.Text);
            }
            for(int i = 1; i <= n; i+=2)// kiểm tra số lẻ
            {
                if (i % 2 != 0) {
                    sum += 1f/ i;
                }
            }
            textBox2.Text = sum.ToString();
        }
    }
}
