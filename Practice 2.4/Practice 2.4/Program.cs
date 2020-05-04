using System;

namespace Practice_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 41;
            for (int j = 41; j <= 71;)
            {
                
                for (int i = 0; i < 10; i++)
                {
                    if (i == 9)
                        Console.WriteLine(value + " ");
                    else
                        Console.Write(value + " ");
                    value++;
                }
                j = j + 10;
            }
        }
    }
}
