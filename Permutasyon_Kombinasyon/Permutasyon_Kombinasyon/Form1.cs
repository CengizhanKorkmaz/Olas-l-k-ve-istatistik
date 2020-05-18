using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Permutasyon_Kombinasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n, r, per, fakt, fakt1;
            n = Convert.ToDouble(textBox1.Text);
            r = Convert.ToDouble(textBox2.Text);
            fakt = n;
            for (int i = Convert.ToInt32(n) - 1; i >= 1; i--)
            {
                fakt = fakt * i;
            }

            double number;
            number = n - r;
            fakt1 = number;
            for (int i = Convert.ToInt32(number) - 1; i >= 1; i--)
            {
                fakt1 = fakt1 * i;
            }
            per = fakt / fakt1;
            label6.Text = per.ToString();
            label6.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n, r, kombinasyon, fakt, fakt1, fakt2;
            n = Convert.ToDouble(textBox3.Text);
            r = Convert.ToDouble(textBox4.Text);

            fakt = n;
            for (int i = Convert.ToInt32(n)- 1; i >= 1; i--)
            {
                fakt = fakt * i;
            }
            fakt2 = r;
            for (int i = Convert.ToInt32(r) - 1; i >= 1; i--)
            {
                fakt2 = fakt2 * i;
            }

            double number;
            number = n - r;
            fakt1 = number;
            for (int i = Convert.ToInt32(number) - 1; i >= 1; i--)
            {
                fakt1 = fakt1 * i;
            }
            fakt1 = fakt2 * fakt1;
            kombinasyon = fakt / fakt1;
            label7.Text = kombinasyon.ToString();
            label7.Visible = true;
        }
    }
}
