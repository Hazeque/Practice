using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_2._2WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int solution = Int32.Parse(textBox1.Text);
            switch (solution)
            {
                case 1: textBox2.Text = "Пики"; break;
                case 2: textBox2.Text = "Трефы"; break;
                case 3: textBox2.Text = "Бубны"; break;
                case 4: textBox2.Text = "Червы"; break;           
                default: textBox2.Text ="Введено неверное число"; break;
            }

        }
    }
}
