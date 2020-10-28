using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_7._1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            s = s.ToLower();
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] == 'x') || (s[i] == 'y'))
                    k++;
            }
            textBox2.Text = Convert.ToString(k);
        }
    }
}
