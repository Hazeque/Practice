using System;

namespace Practice_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] mas = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент массива");
                mas[i] = Convert.ToDouble(Console.ReadLine());
            }
            double min = mas[0];
            for (int i = 0; i < n; i++)
            {
                if (mas[i] <= min)
                {
                    min = mas[i];
                    mas[i] = Math.Abs(mas[i]);
                }
            }
            Console.WriteLine("Изменённый массив: ");
            for (int i = 0; i < n; i++)
                Console.Write(mas[i] + " ");
        }
    }
}