using System;

namespace Practice_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N >=1000 ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N < 1000)
                Console.Write("Введено неверное значение  N ");
            else
            rec(N);
        }
        static void rec(int i)
        {
            if (i == 0)
                return;
            else
                rec(i - 1);
            Console.Write(i + " ");
        }
    }
}
