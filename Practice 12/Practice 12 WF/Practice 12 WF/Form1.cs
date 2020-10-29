using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_12_WF
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
                  string s = "Длина стороны a: " + a + Environment.NewLine +  "Длина стороны b:  " + b + Environment.NewLine;
                return s;
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

            public string this[int i]
            {
                get
                {
                    switch (i)
                    {
                        case 0:
                            return $"Индексу {i} соответствует сторона a, равная {a} см";
                        case 1:
                            return $"Индексу {i} соответствует сторона b, равная {b} см";
                        default:
                            return $"Индекс {i} является недействительным";
                    }
                }
            }
            public static Rectangle operator ++(Rectangle r)
            {
                r.A++;
                r.B++;
                return r;
            }

            public static Rectangle operator --(Rectangle r)
            {
                r.A--;
                r.B--;
                return r;
            }

            public static bool operator false(Rectangle r)
            {
                if (!r.Square())
                    return false;
                return true;
            }

            public static bool operator true(Rectangle r)
            {
                if (r.Square())
                    return true;
                return false;
            }

            public static Rectangle operator *(Rectangle r, int v)
            {
                r.A *= v;
                r.B *= v;
                return r;
            }

            public static Rectangle operator *(int v, Rectangle r)
            {
                r.A *= v;
                r.B *= v;
                return r;
            }

            public override string ToString()
            {
                return a.ToString() + ", " + b.ToString();
            }

            public static implicit operator Rectangle(string str)
            {
                string[] w = str.Split(' ');
                return new Rectangle(Convert.ToInt32(w[0]), Convert.ToInt32(w[1]));
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            Rectangle firstRectangle = new Rectangle(a, b);
            textBox5.Text = firstRectangle.GetArgs();
            textBox5.Text += "Периметр прямоугольника равна " +firstRectangle.Pr() + Environment.NewLine;
            textBox5.Text += "Площадь прямоугольника равна " +firstRectangle.Sq() + Environment.NewLine;
            if (firstRectangle.Square())
                textBox5.Text += "Данный прямоугольник является квадратом" + Environment.NewLine; 
            else
                textBox5.Text += "Данный прямоугольник не является квадратом" + Environment.NewLine; 
            int index = Convert.ToInt32(textBox3.Text);
            textBox5.Text += firstRectangle[index] + Environment.NewLine; 
            textBox5.Text += "Оператор ++: " + (++firstRectangle) + Environment.NewLine;
            textBox5.Text += "Оператор --: " + (--firstRectangle) + Environment.NewLine;
            int k = Convert.ToInt32(textBox4.Text);
            textBox5.Text += "Оператор *: " + (firstRectangle*k) + Environment.NewLine;
            textBox5.Text += "Преобразования типа Rectangle в string: " + firstRectangle.ToString() + Environment.NewLine;
            Rectangle F = textBox7.Text;
            textBox5.Text += "Преобразования типа string в Rectangle:  " + Environment.NewLine + " Строчка: " + F + Environment.NewLine; 
            textBox5.Text += "Длина прямгоульника F = " + F.a + " Ширина прямоугольника F = " + F.b;
        }

    }
}
