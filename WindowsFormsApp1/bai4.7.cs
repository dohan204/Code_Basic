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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // kiểm tra giai thừa
            int n = Convert.ToInt32(textBox1.Text);
            int sum = 1;
            // kiểm tra số dương
            if (n < 0)
            {
                MessageBox.Show("Vui lòng nhập số dương");
                return;
            }
            // sử dụng vòng lặp for để tính tổng n!
            for (int i = 1; i <= n; i++) {
                sum *= i;
            }
            // hiển thị kết quả
            textBox2.Text = sum.ToString();
        }
    }
}
