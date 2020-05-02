using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("Введите значение первого числа");
            double value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение второго числа");
            double value2 = Convert.ToDouble(Console.ReadLine());
            double solution = (value1 * value1 + value2 * value2) / 2;
            Console.WriteLine("Среднее арифметическое кубов двух данных чисел равно " + solution);

        }
    }
}
