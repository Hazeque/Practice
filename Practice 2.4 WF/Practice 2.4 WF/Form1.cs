using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_2._4_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value = 41;
            for (int j = 41; j <= 71;)
            {

                for (int i = 0; i < 10; i++)
                {
                    if (i == 9)
                       textBox1.Text = textBox1.Text + value + " " + Environment.NewLine;
                    else
                        textBox1.Text = textBox1.Text + value + " ";
                    value++;
                }
                j = j + 10;
            }
        }
    }
}


