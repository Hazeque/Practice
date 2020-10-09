using System;

namespace Practice_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[n, n];
            int k = 0;
            int Sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введите значение элемента массива");
                    mas[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j < n)
                    {
                        if (mas[i, j] != 0)
                        {
                            k++;
                            Sum = Sum + mas[i, j];
                        }
                    }
                }
            }
            int arifm = Sum / k;
            Console.WriteLine("Среднее арифметическое ненулевых элементов равно " + arifm );
        }
    }
}
