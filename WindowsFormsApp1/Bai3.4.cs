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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(txtDay.Text);
            int month = Convert.ToInt32(txtMonth.Text);
            int year = Convert.ToInt32(txtYear.Text);

            if (month < 1 || month > 12)
            {
                MessageBox.Show("Tháng không hợp lệ");
                return;
            }
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day < 1 || day > 31)
                {
                    MessageBox.Show("Ngày không hợp lệ");
                    return;
                }
                else
                {
                    MessageBox.Show("Ngày " + day + "/" + month + "/" + year + " là ngày hợp lệ");
                }
            }
             else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day < 1 || day > 30)
                {
                    MessageBox.Show("Ngày không hợp lệ");
                    return;
                }
                else
                {
                    MessageBox.Show("Ngày " + day + "/" + month + "/" + year + " là ngày hợp lệ");
                }
            }
            else
            {
                if (day < 1 || day > 29)
                {
                    MessageBox.Show("Ngày không hợp lệ");
                    return;
                }
                else if (day == 29 && !DateTime.IsLeapYear(year))
                {
                    MessageBox.Show("Ngày không hợp lệ");
                    return;
                }
                else
                {
                    MessageBox.Show("Ngày " + day + "/" + month + "/" + year + " là ngày hợp lệ");
                }
            }
        }
    }
}