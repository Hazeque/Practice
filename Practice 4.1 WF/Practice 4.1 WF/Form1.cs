using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_4._1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        int nod(int a, int b)
            {
                if (a == b) return a;
                if (a > b) return nod(a - b, b);
                return nod(a, b - a);
            }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int N = nod(a, b);         
            textBox3.Text = Convert.ToString(N);         
        }
    }
}
