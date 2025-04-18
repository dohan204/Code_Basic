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

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int sum = 0;
            // sử dụng vòng lặp for để tính tổng 
            for(int i =2; i <=n; i+=2)
            {
                sum += i;   
            }
            // hiển thị kết quả
            textBox2.Text = sum.ToString();
        }
    }
}
