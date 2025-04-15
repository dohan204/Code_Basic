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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void btnChuvi_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int chuvi = (a + b) * 2;
            MessageBox.Show("Chu vi hình chữ nhật là: " + chuvi.ToString());
        }

        private void btnDientich_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int dientich = a * b;
            MessageBox.Show("Diện tích hình chữ nhật là: " + dientich.ToString());
        }

        private void btnDuongcheo_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double duongcheo = Math.Sqrt((a * a) + (b * b));
            MessageBox.Show("Đường chéo hình chữ nhật là: " + duongcheo.ToString("0.00")); // Làm tròn hiển thị 2 chữ số sau dấu phẩy
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
