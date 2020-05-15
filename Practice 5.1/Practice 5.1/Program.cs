using System;

namespace Practice_5._1
{
    class Program
    {
        static double f(double x)
        {
            try
            {
                if ((x * x) < 1) throw new Exception();
                else return Math.Sqrt(x * x - 1);
            }
            catch
            {
                throw;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите значение а ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите значение b ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Введите значение h ");
                double h = double.Parse(Console.ReadLine());
                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y при а = " + i + " равно " + f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y при а = " + i + " error");
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }
    }
}
