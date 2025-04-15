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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double chieudai, chieurong;

            bool isValid1 = double.TryParse(textBox1.Text, out chieudai);
            bool isValid2 = double.TryParse(textBox2.Text, out chieurong);

            if (isValid1 && isValid2)
            {
                double duongcheo = Math.Sqrt((chieudai * chieudai) + (chieurong * chieurong));
                textBox3.Text = duongcheo.ToString("0.00"); // Làm tròn hiển thị 2 chữ số sau dấu phẩy
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng số vào chiều dài và chiều rộng!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chieudai = Convert.ToInt32(textBox1.Text);
            int chieurong = Convert.ToInt32(textBox2.Text);
            int chuvi = (chieudai + chieurong) * 2;
            textBox3.Text = chuvi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int chieudai = Convert.ToInt32(textBox1.Text);
            int chieurong = Convert.ToInt32(textBox2.Text);
            int dientich = chieudai * chieurong;
            textBox3.Text = dientich.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onclick_Click(object sender, EventArgs e)
        {
            double chieudai = Convert.ToDouble(textBox1.Text);
            double chieurong = Convert.ToDouble(textBox2.Text);
            double math = (chieudai * chieudai) + (chieurong * chieurong);
            double duongcheo = Math.Sqrt(math);
            textBox3.Text = duongcheo.ToString("0.00"); // Làm tròn hiển thị 2 chữ số sau dấu phẩy
        }
    }
}
