using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            Task5();
        }

        public static void Task1()
        {
            Console.WriteLine("Set two UNEQUAL numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double result = (5 * a + b * b) / (b - a);

            Console.WriteLine(result);
        }

        public static void Task2()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = a;
            a = b;
            b = c;
        }

        public static void Task3()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double divisionResult = (double)a / b;
            int remainder = a % b;

            Console.WriteLine($"a/b = { divisionResult }");
            Console.WriteLine($"The remainder of dividing {a} by {b} is equal to {remainder}");
        }

        public static void Task4()
        {
            Console.WriteLine("Set three NON-ZERO numbers");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            float x = (c - b) / a;

            Console.WriteLine($"{a}*X + {b} = { c }");
            Console.WriteLine($"X= {x}");
        }

        public static void Task5()
        {
            Console.WriteLine("Set x1:");
            float x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Set y1:");
            float y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Set x2:");
            float x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Set y2:");
            float y2 = float.Parse(Console.ReadLine());

            float a = (y1 - y2) / (x1 - x2);
            float b = y2 - a * x2;
            Console.WriteLine($"Y= {a}*X + {b}");
        }
    }
}