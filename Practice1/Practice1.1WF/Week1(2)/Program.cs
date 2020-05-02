using System;

namespace Week1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение M");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение N");
            int N = Convert.ToInt32(Console.ReadLine());
            double quotient = M / N;
            if (M % N == 0)
            Console.WriteLine("Частное от деления равно " + quotient);
            else
                Console.WriteLine("M на N нацело не делится ");
        }
    }
}
