using System;

namespace Practice_11
{
    class Rectangle
    {
        public int a, b;

        public Rectangle()
        {
            a = 0;
            b = 0;
        }

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void GetArgs()
        {
            Console.WriteLine("Длина стороны a: " + a + " Длина стороны b: " + b);
        }
        public int Pr ()
        {
            int P = (a + b) * 2;
            Console.Write("Периметр прямоугольника равен ");
            return P;
        }
        public int Sq ()
        {
            int S = a * b;
            Console.Write("Площадь прямоугольника равна ");
            return S;
        }
        public bool Square ()
        {
                if (a == b)
                    return true;
                else
                    return false;
        }
        public int A
        {
            get => a;
            set => a = value;
        }

        public int B
        {
            get => b;
            set => b = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение стороны а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение стороны b"); 
            int b = Convert.ToInt32(Console.ReadLine());
            if ((a <= 0) || (b <= 0))
                Console.WriteLine("Ошибка: длина стороны не может быть меньше или равна 0");
            else
            {
                Rectangle firstRectangle = new Rectangle(a, b);
                firstRectangle.GetArgs();
                Console.WriteLine(firstRectangle.Pr());
                Console.WriteLine(firstRectangle.Sq());
                if (firstRectangle.Square())
                    Console.WriteLine("Данный прямоугольник является квадратом");
                else
                    Console.WriteLine("Данный прямоугольник не является квадратом");
            }
        }
    }
}
