using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_7._2_WF
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
            string[] parts = s.Trim().Split(' ', '.', ',', ':', '!', '?');
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Contains('1') || parts[i].Contains('2') || parts[i].Contains('3') || parts[i].Contains('4') || parts[i].Contains('5') || parts[i].Contains('6') || parts[i].Contains('7') || parts[i].Contains('8') || parts[i].Contains('9') || parts[i].Contains('0'))
                {
                    textBox2.Text += parts[i] + " ";
                }
            }
        }
    }
}
