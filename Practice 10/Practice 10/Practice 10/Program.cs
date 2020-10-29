using System;
using System.IO;

namespace Practice_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"K1");
            Directory.CreateDirectory(@"K2");
            File.WriteAllText(@"K1\t1","Иванов Иван Иванович, 1965 года рождения, место жительства г.Саратов");
            File.WriteAllText(@"K1\t2", "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            string line = File.ReadAllText(@"K1\t1") + Environment.NewLine;
            line += File.ReadAllText(@"K1\t2");
            File.WriteAllText(@"K2\t3", line);
            FileInfo inf = new FileInfo(@"K1\t1"); 
            Console.WriteLine("Полное название каталога: " + inf.FullName);
            inf = new FileInfo(@"K1\t2");
            Console.WriteLine("Полное название каталога: " + inf.FullName);
            inf = new FileInfo(@"K2\t3");
            Console.WriteLine("Полное название каталога: " + inf.FullName);
            File.Move(@"K1\t2", @"K2\t2",true);
            File.Copy(@"K1\t1", @"K2\t1", true);
            Directory.Move(@"K2", @"ALL");
            File.Delete(@"K2");
            File.Delete(@"K1\t1");
            Directory.Delete(@"K1");
            DirectoryInfo dirInfo = new DirectoryInfo(@"ALL");
            Console.WriteLine("Название каталога: " + dirInfo.Name);
            Console.WriteLine("Полное название каталога: " + dirInfo.FullName);
            Console.WriteLine("Время создания каталога: " + dirInfo.CreationTime);
            Console.WriteLine("Корневой каталог: " + dirInfo.Root);
            inf = new FileInfo(@"ALL\t1");
            Console.WriteLine("Полное название каталога: " + inf.FullName);
            Console.WriteLine("Название каталога: " + inf.Name);
            Console.WriteLine("Время создания каталога: " + inf.CreationTime);
            inf = new FileInfo(@"ALL\t2");
            Console.WriteLine("Полное название каталога: " + inf.FullName);
            Console.WriteLine("Название каталога: " + inf.Name);
            Console.WriteLine("Время создания каталога: " + inf.CreationTime);
            inf = new FileInfo(@"ALL\t3");
            Console.WriteLine("Полное название каталога: " + inf.FullName);
            Console.WriteLine("Название каталога: " + inf.Name);
            Console.WriteLine("Время создания каталога: " + inf.CreationTime);
        }
    } 
}
