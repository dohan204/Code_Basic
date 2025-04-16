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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0; // Initialize 'result' to avoid CS0165
            double a, b, c, x1, x2, delta;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            if (a < 0)
            {
                MessageBox.Show("a phải lớn hơn 0");
            }
            else
            {
                delta = b * b -4 * a * c;
                if (delta < 0)
                {
                    textBox4.Text = result.ToString("Phương trình vô nghiệm");
                }
                if (delta == 0)
                {
                    textBox4.Text = result.ToString("Phương trình có một nghiệm duy nhất" +  result);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a); // Corrected formula
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a); // Corrected formula
                    textBox4.Text = result.ToString("Phương trình có hai nghiệm phân biệt x1=" + x1 + ",x2= " + x2); ;
                }
            }
        }
    }
}
