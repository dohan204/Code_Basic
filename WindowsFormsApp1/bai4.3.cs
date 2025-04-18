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

        private void button1_Click(object sender, EventArgs e)
        {
            float n = float.Parse(t1.Text);
            float sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / (float)i;
            }
            t2.Text = sum.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
