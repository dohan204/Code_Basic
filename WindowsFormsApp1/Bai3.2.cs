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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(textBox1.Text);
            string season = "";
            if (month == 1 || month == 2 || month == 3)
            {
                season = "Mùa Xuân";
            }
            else if (month == 4 || month == 5 || month == 6)
            {
                season = "Mùa Hè";
            }
            else if (month == 7 || month == 8 || month == 9)
            {
                season = "Mùa Thu";
            }
            else if (month == 10 || month == 11 || month == 12)
            {
                season = "Mùa Đông";
            }
            else
            {
                MessageBox.Show("Tháng không hợp lệ");
                return;
            }
            MessageBox.Show("Tháng " + month + " là " + season);
        }
        
    }
}
