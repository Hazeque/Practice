using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Лежит ли точка в заштрихованной области?");

            if ((x <= 0) && (x >= -8) && (y >= -8) && (y <= 8)) 
            {
                if ((x * x + y * y > 9) && (x * x + y * y < 64))
                        Console.WriteLine("Да");

                else
                {
                    
                    if ((x == 0) && (y >= 3) && (y <= 8))
                        Console.WriteLine("Точка лежит на границе");
                    if ((x == 0) && (y >= -8) && (y <= -3))
                        Console.WriteLine("Точка лежит на границе");
                    if ((x == Convert.ToInt32(-1 * Math.Sqrt(64 - y * y))) || (x == Convert.ToInt32(-1 * Math.Sqrt(9 - y * y))))
                    Console.WriteLine("Точка лежит на границе"); 
                    else
                    Console.WriteLine("Нет");

                }
               

            }
            else
                Console.WriteLine("Нет");
        }
    }
}
