using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_5._1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double f(double x)
        {
            try
            {
                if ((x * x) < 1) throw new Exception();
                else return Math.Sqrt(x * x - 1);
            }
            catch
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double h = double.Parse(textBox3.Text);
                for (double i = a; i <= b; i += h)
                    try
                    {
                        textBox4.Text += ("y при а = " + i + " равно " + f(i)) + Environment.NewLine;
                    }
                    catch
                    {
                        textBox4.Text += ("y при а = " + i + " error") + Environment.NewLine;
                    }
            }
            catch (FormatException)
            {
               MessageBox.Show("Неверный формат ввода данных", "Сообщение");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }
    }
}
