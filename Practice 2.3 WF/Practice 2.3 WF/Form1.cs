﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_2._3_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 25; j <= 35; j++)
            {
                double value = j;
                textBox1.Text = textBox1.Text + value + " ";
                value = 0.5 + value;
                textBox1.Text = textBox1.Text + value + " ";
                value = value - 0.7;
                textBox1.Text = textBox1.Text + value + Environment.NewLine;
            }    
        }
    }
}
