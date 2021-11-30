using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
              Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
        }

        public static void Task1()
        {
            double a, b;
            do
            {
                Console.WriteLine("Set two UNEQUAL numbers");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                if (a == b)
                {
                    Console.WriteLine("The equation does not contain solutions for equal entered numbers");
                }
            }
            while (a == b);

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
            float a, b, c;
            do
            {
                Console.WriteLine("Set three NON-ZERO numbers");
                a = float.Parse(Console.ReadLine());
                b = float.Parse(Console.ReadLine());
                c = float.Parse(Console.ReadLine());
                if (a == 0 || b == 0 || c == 0)
                {
                    Console.WriteLine("You entered a number equal to zero, please try again");
                }
            }
            while (a == 0 || b == 0 || c == 0);

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

            if (x1 == x2 && y1 != y2)
            {
                Console.WriteLine($"X= {x1}");
            }
            else if (x1 != x2 && y1 == y2)
            {
                Console.WriteLine($"Y= {y1}");
            }
            else if (x1 != x2 && y1 != y2)
            {                
                float a = (y1 - y2) / (x1 - x2);
                float b = y2 - a * x2;
                Console.WriteLine($"Y= {a}*X + {b}");
            }
            else
            {
                Console.WriteLine("It is not possible to make an equation of a line because you entered points with the same coordinates.");
            }
        }
    }
}