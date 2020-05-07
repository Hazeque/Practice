using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_3._1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text);
            double b = Double.Parse(textBox1.Text);
            if (function(a) > function(b))
                textBox3.Text = "Функция принимает наибольшее значение в точке а";
            else
                textBox3.Text = "Функция принимает наибольшее значение в точке b";
        }
        static double function(double x)
        {
            return x * x * x - Math.Sin(x);
        }
    }
}
