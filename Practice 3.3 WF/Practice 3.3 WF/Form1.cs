using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_3._3_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double function(double x, double a, out double y)
        {
            y = function(x, a);
            return y;
        }

        static double function(double x, double a)
        {
            if (x < a)
                return 0;
            if (x == a)
                return 1;
            else
                return (x - a) / (x + a);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text);
            double b = Double.Parse(textBox2.Text);
            double x = Double.Parse(textBox3.Text);
            double h = Double.Parse(textBox4.Text);
            double y;
            if (x > a)
            {
                if (x + a == 0)
                    MessageBox.Show("Знаменатель не может равняться 0", "Ошибка");
                else
                    while (x < b)
                    {
                        textBox5.Text += Convert.ToString(function(x, a, out y)) + Environment.NewLine;
                        x = x + h;
                    }
            }
            else
            {
                while (x < b)
                {
                    textBox5.Text += Convert.ToString(function(x, a, out y)) + Environment.NewLine;
                    x = x + h;
                }

            }
        }
    }
}