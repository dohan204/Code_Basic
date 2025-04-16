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


        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);
            int c = Convert.ToInt32(txtC.Text);

            int max = a;
            if(b > max)
            {
                max = b;
            }
            if(c > max)
            {
                max = c;
            }
            txtfirst.Text = max.ToString();
            int tb = a;
            if (b > tb)
            {
                tb = b;
            }
            if (c < tb)
            {
                tb = c;
            }
            txtsecond.Text = tb.ToString();
            int min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
            txtthirst.Text = min.ToString();
        }
    }
}
