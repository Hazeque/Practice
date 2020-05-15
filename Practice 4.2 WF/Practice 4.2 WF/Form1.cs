using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_4._2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        public void rec(int i)
        {
            if (i == 0)
                return;
            else
                rec(i - 1);
            textBox2.Text = textBox2.Text + Convert.ToString(i + " ");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int N = Int32.Parse(textBox1.Text);
            if (N < 1000)
                MessageBox.Show("Введено неверное значение  N ", "Сообщение");
            else
                rec(N);
        }
    }
}
    