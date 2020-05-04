using System;

namespace Practice_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер масти m от 1 до 4");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine("Пики"); break;
                case 2: Console.WriteLine("Трефы"); break;
                case 3: Console.WriteLine("Бубны"); break;
                case 4: Console.WriteLine("Червы"); break;
                default: Console.WriteLine("Введено неверное число"); break;
            }

        }
    }
}
