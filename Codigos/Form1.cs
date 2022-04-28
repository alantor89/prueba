using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codigos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n =Convert.ToInt32( textBox2.Text);
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            textBox1.Text = fact.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);
            int b = Convert.ToInt32(textBox4.Text);
            int c = Convert.ToInt32(textBox5.Text);
            int res = 0;
            if (a < b)
            {
                if (b < c)
                {
                    res = c;
                }
                else
                    res = b;
            }
            else if (a > b)
            {
                if (a < c)
                {
                    res = c;
                }
                else
                    res = a;
            }
            textBox6.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(textBox7.Text);
            double a = Convert.ToDouble(textBox8.Text);

            double res = 0;
            res = b * a / 2;
            textBox9.Text = res.ToString();
        }
    }
}
