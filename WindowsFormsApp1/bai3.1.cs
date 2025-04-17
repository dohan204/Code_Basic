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

        private void button1_Click_1(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float c = float.Parse(txtC.Text);
            float d = float.Parse(txtD.Text);
            float i = float.Parse(txtE.Text);
            float f = float.Parse(txtF.Text);
            float x, y;

            float D = a * i - b * d;      // Định thức hệ
            float Dx = c * i - b * f;
            float Dy = a * f - c * d;

            if (D != 0)
            {
                // Hệ có nghiệm duy nhất
                x = Dx / D;
                y = Dy / D;
                txtkq.Text = "Nghiệm duy nhất là: x = " + x + ", y = " + y;
            }
            else
            {
                // D == 0 -> xét tiếp
                if (Dx == 0 && Dy == 0)
                {
                    txtkq.Text = "Hệ có vô số nghiệm";
                }
                else
                {
                    txtkq.Text = "Hệ vô nghiệm";
                }
            }

        }
    }
}
