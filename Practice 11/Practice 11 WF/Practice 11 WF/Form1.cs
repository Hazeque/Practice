using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_11_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
class Rectangle
        {
            public int a, b;

            public Rectangle()
            {
                a = 0;
                b = 0;
            }

            public Rectangle(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public string GetArgs()
            {
                string info = "Длина стороны a: " + a + " Длина стороны b: " + b + Environment.NewLine;
                return info;
            }
            public int Pr()
            {
                int P = (a + b) * 2;
                return P;
            }
            public int Sq()
            {
                int S = a * b;
                return S;
            }
            public bool Square()
            {
                if (a == b)
                    return true;
                else
                    return false;
            }
            public int A
            {
                get => a;
                set => a = value;
            }

            public int B
            {
                get => b;
                set => b = value;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            if ((a <= 0) || (b <= 0))
                MessageBox.Show("Ошибка: длина стороны не может быть меньше или равна 0","Сообщение");
            else
            {
                Rectangle firstRectangle = new Rectangle(a, b);
                textBox3.Text = firstRectangle.GetArgs();
                textBox3.Text += "Периметр прямоугольник равен " + Convert.ToString(firstRectangle.Pr()) + Environment.NewLine;
                textBox3.Text += "Площадь прямоугольника равен " + (firstRectangle.Sq()) + Environment.NewLine;
                if (firstRectangle.Square())
                    textBox3.Text += "Данный прямоугольник является квадратом";
                else
                    textBox3.Text += "Данный прямоугольник не является квадратом";
            }
        }      
    }
}

