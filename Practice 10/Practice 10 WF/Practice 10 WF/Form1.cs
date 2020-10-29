using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practice_10_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"K1");
            Directory.CreateDirectory(@"K2");
            File.WriteAllText(@"K1\t1", "Иванов Иван Иванович, 1965 года рождения, место жительства г.Саратов");
            File.WriteAllText(@"K1\t2", "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            string line = File.ReadAllText(@"K1\t1") + Environment.NewLine;
            line += File.ReadAllText(@"K1\t2");
            File.WriteAllText(@"K2\t3", line);
            FileInfo inf = new FileInfo(@"K1\t1");
            textBox1.Text += "Полное название каталога: " + inf.FullName + Environment.NewLine;
            inf = new FileInfo(@"K1\t2");
            textBox1.Text += "Полное название каталога: " + inf.FullName + Environment.NewLine;
            inf = new FileInfo(@"K2\t3");
            textBox1.Text += "Полное название каталога: " + inf.FullName + Environment.NewLine;
            File.Move(@"K1\t2", @"K2\t2");
            File.Copy(@"K1\t1", @"K2\t1", true);
            Directory.Move(@"K2", @"ALL");
            File.Delete(@"K2");
            File.Delete(@"K1\t1");
            Directory.Delete(@"K1");
            DirectoryInfo dirInfo = new DirectoryInfo(@"ALL");
            textBox1.Text += "Название каталога: " + dirInfo.Name + Environment.NewLine;
            textBox1.Text += "Полное название каталога: " + dirInfo.FullName + Environment.NewLine;
            textBox1.Text += "Время создания каталога: " + dirInfo.CreationTime + Environment.NewLine;
            textBox1.Text += "Корневой каталог: " + dirInfo.Root + Environment.NewLine;
            inf = new FileInfo(@"ALL\t1");
            textBox1.Text += "Полное название каталога: " + inf.FullName + Environment.NewLine;
            textBox1.Text += "Название каталога: " + inf.Name + Environment.NewLine;
            textBox1.Text += "Время создания каталога: " + inf.CreationTime + Environment.NewLine;
            inf = new FileInfo(@"ALL\t2");
            textBox1.Text += "Полное название каталога: " + inf.FullName + Environment.NewLine;
            textBox1.Text += "Название каталога: " + inf.Name + Environment.NewLine;
            textBox1.Text += "Время создания каталога: " + inf.CreationTime + Environment.NewLine;
            inf = new FileInfo(@"ALL\t3");
            textBox1.Text += "Полное название каталога: " + inf.FullName + Environment.NewLine;
            textBox1.Text += "Название каталога: " + inf.Name + Environment.NewLine;
            textBox1.Text += "Время создания каталога: " + inf.CreationTime+ Environment.NewLine;
        }
    }
}
