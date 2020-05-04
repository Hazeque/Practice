using System;

namespace Practice_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Цикл For: ");
            for (int j = 25; j <= 35; j++)
            {
                double  value = j;
                Console.Write(value + " ");
                value = 0.5 + value;
                Console.Write(value + " ");
                value = value - 0.7;
                Console.WriteLine(value + " ");               
            }

            int k = 25;
            Console.WriteLine("Цикл While: ");
            while (k <= 35)
            {
                double value1 = k;
                Console.Write(value1 + " ");
                value1 = 0.5 + value1;
                Console.Write(value1 + " ");
                value1 = value1 - 0.7;
                Console.WriteLine(value1 + " ");
                k++;
            }

            Console.WriteLine("Цикл While do: ");
            int t = 25;
            do
            {
                Console.Write(t + " ");
                double value2 = t;
                value2 = 0.5 + value2;
                Console.Write(value2 + " ");
                value2 = value2 - 0.7;
                Console.WriteLine(value2 + " ");
                t++;

            } while (t <= 35);

        }
    }
}
