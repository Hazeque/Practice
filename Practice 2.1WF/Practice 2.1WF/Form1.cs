using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_2._1WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(textBox1.Text);
            double y = Double.Parse(textBox2.Text);

            if ((x <= 0) && (x >= -8) && (y >= -8) && (y <= 8))
            {
                if ((x * x + y * y > 9) && (x * x + y * y < 64))
                    textBox3.Text = "Да";
                else
                {
                    if ((x == 0) && (y >= 3) && (y <= 8))
                        textBox3.Text = "Точка лежит на границе";
                    if ((x == 0) && (y >= -8) && (y <= -3))
                        textBox3.Text = "Точка лежит на границе";
                    if ((x == Convert.ToInt32(-1 * Math.Sqrt(64 - y * y))) || (x == Convert.ToInt32(-1 * Math.Sqrt(9 - y * y))))
                        textBox3.Text = "Точка лежит на границе";
                    else
                        textBox3.Text = "Нет";
                }
            }
            else
                textBox3.Text = "Нет";
        }
    }
}