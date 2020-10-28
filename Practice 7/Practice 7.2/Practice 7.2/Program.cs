using System;

namespace Practice_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            string[] parts = s.Trim().Split(' ', '.', ',', ':', '!', '?');
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Contains('1') || parts[i].Contains('2') || parts[i].Contains('3') || parts[i].Contains('4') || parts[i].Contains('5') || parts[i].Contains('6') || parts[i].Contains('7') || parts[i].Contains('8') || parts[i].Contains('9') || parts[i].Contains('0'))
                {
                    Console.WriteLine(parts[i] + " ");
                }
            }
        }
    }
}

