using System;

namespace Practice_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите значение а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            int b = Convert.ToInt32(Console.ReadLine());
            int N = nod(a, b);
            Console.WriteLine("Наибольший общий делитель: " + N);
            int nod(int a, int b)
            {
                if (a == b) return a;
                if (a > b) return nod(a - b, b);
                return nod(a, b - a);
            }
        }
    }
}
