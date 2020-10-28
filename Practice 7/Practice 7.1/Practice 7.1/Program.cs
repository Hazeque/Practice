using System;

namespace Practice_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            s = s.ToLower();
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] == 'x')|| (s[i] == 'y'))
                    k++;              
            }
            Console.WriteLine("Общее число вхождений символов х и y равно " + k);
        }
    }
}
