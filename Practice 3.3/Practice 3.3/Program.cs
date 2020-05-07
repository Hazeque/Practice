using System;

namespace Practice_3._3
{
    class Program
    {
        static double function(double x, double a)
        {
            if (x < a)
                return 0;
            if (x == a)
                return 1;
            else
                return (x - a) / (x + a);
        }
        static double function(double x, double a, out double y)
        {
            y = function(x, a);
            return y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг h");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x > a)
            {
                if (x + a == 0)
                    Console.WriteLine("Знаменатель не может равняться 0");
                else
                    while (x < b)
                    {
                        Console.WriteLine(function(x, a));
                        x = x + h;
                    }
            }
            else
            {
                while (x < b)
                {
                    Console.WriteLine(function(x, a));
                    x = x + h;
                }
            }
        }
    }
}