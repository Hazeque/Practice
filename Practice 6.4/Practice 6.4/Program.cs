using System;

namespace Practice_6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] mas = new int[n][];
            for (int i = 0; i < n; i++)
            {
                mas[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Введите значение элемента ");
                    mas[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введите значение элемента массива");
                    mas[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[] x = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите значение элемента вектора");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i < mas.Length; i += 2)

                mas [i] = x;

            Console.Write("Изменённый массив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[i][j]);
                }
            }
        }
    }
}
