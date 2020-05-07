using System;

namespace Practice_3._1
{
    class Program
    {
        static double function (double x)
        {
            return x * x * x - Math.Sin(x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение а");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            double b = Convert.ToDouble(Console.ReadLine());
            double z = function(a);
            if (function(a) > function(b))
                Console.WriteLine("Функция принимает наибольшее значение в точке а");
            else
                Console.WriteLine("Функция принимает наибольшее значение в точке b");

        }
    }
}
