using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1._1_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double M = Double.Parse(textBox1.Text);
            double N = Double.Parse(textBox2.Text);
            double quotient = M / N;
            if (M % N == 0)
                textBox3.Text = quotient.ToString();
            else
                MessageBox.Show("M на N нацело не делится","Сообщение");
        }
    }
}
