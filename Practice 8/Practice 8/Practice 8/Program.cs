using System;
using System.Text.RegularExpressions;

namespace Practice_8
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Regex regex = new Regex(@"\b[A-Z]\S*");
            Console.WriteLine("Слова, начиющиеся с большой буквы: ");
            foreach (var i in regex.Matches(str))
                Console.WriteLine(i + " ");
        }
    }
}
