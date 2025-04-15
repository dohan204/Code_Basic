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
            int canh = Convert.ToInt32(textBox1.Text);
            int chuvi = canh * 4;
            MessageBox.Show("Chu vi hinh vuong la: " + chuvi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int canh = Convert.ToInt32(textBox1.Text);
            int dientich = canh * canh;
            MessageBox.Show("Dien tich hinh vuong la: " + dientich);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int canh = Convert.ToInt32(textBox1.Text);
            int duongcheo = (canh * canh) + (canh * canh);
            duongcheo = (int)Math.Sqrt(duongcheo);  
            MessageBox.Show("Duong cheo hinh vuong la: " + duongcheo);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
