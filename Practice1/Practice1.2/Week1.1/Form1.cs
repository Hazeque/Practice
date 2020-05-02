using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1._1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value1 = Double.Parse(textBox1.Text);
            double value2 = Double.Parse(textBox2.Text);
            double solution = (value1 * value1 + value2 * value2) / 2;
            textBox3.Text = solution.ToString();
        
        }
    }
}
