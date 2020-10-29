using System;
using System.Drawing;

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

        public int Pr()
        {
            int P = (a + b) * 2;
            Console.Write("Периметр прямоугольника равен ");
            return P;
        }

        public int Sq()
        {
            int S = a * b;
            Console.Write("Площадь прямоугольника равна ");
            return S;
        }

        public bool Square()
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

        public string this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return $"Индексу {i} соответствует сторона a, равная {a} см";
                    case 1:
                        return $"Индексу {i} соответствует сторона b, равная {b} см";
                    default:
                        return $"Индекс {i} является недействительным";
                }
            }
        }
        public static Rectangle operator ++(Rectangle r)
        {
            r.A++;
            r.B++;
            return r;
        }

        public static Rectangle operator --(Rectangle r)
        {
            r.A--;
            r.B--;
            return r;
        }

        public static bool operator false(Rectangle r)
        {
            if (!r.Square())
                return false;
            return true;
        }

        public static bool operator true(Rectangle r)
        {
            if (r.Square())
                return true;
            return false;
        }

        public static Rectangle operator *(Rectangle r, int v)
        {
            r.A *= v;
            r.B *= v;
            return r;
        }

        public static Rectangle operator *(int v, Rectangle r)
        {
            r.A *= v;
            r.B *= v;
            return r;
        }

        public override string ToString()
        {
            return a.ToString() + ", " + b.ToString();
        }

        public static implicit operator Rectangle(string str)
        {
            string[] w = str.Split(' ');
            return new Rectangle(Convert.ToInt32(w[0]), Convert.ToInt32(w[1]));
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
            Rectangle firstRectangle = new Rectangle(a, b);
            firstRectangle.GetArgs();
            Console.WriteLine(firstRectangle.Pr());
            Console.WriteLine(firstRectangle.Sq());
            if (firstRectangle.Square())
                Console.WriteLine("Данный прямоугольник является квадратом");
            else
                Console.WriteLine("Данный прямоугольник не является квадратом");
            Console.WriteLine("Введите значение индекса ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Обращение к переменной по индексу ");
            Console.WriteLine(firstRectangle[index]);
            Console.WriteLine("Перегрузка операторов: ");
            Console.WriteLine("Оператор ++: " + ++firstRectangle);
            Console.WriteLine("Оператор --: " + --firstRectangle);
            Console.WriteLine("Введите скаляр");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Оператор *: " + firstRectangle * k);
            Console.WriteLine("Преобразования типа Rectangle в string: " + firstRectangle.ToString());
            Console.WriteLine("Введите значения стороны а и b");
            Rectangle F = Console.ReadLine();
            Console.WriteLine("Преобразования типа string в Rectangle:  "+ Environment.NewLine + " Строчка: " + F);
            Console.WriteLine("Длина прямгоульника F = " + F.a + " Ширина прямоугольника F = " + F.b);
        }
    }
}
