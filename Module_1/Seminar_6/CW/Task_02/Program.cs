using System;

namespace Task_02
{
    class Program
    {
        public static double Y(double a, double b, double c, double x)
        {
            if (x < 1.2)
                return a * x * x + b * x + c;
            else if (x == 1.2)
                return a / x + Math.Sqrt(x * x + 1);
            else
                return (a + b * x) / Math.Sqrt(x * x + 1);
        }
        
        static void Main(string[] args)
        {
            string input;
            
            Console.Write("a: ");
            input = Console.ReadLine();
            double a = double.Parse(input);
            
            Console.Write("b: ");
            input = Console.ReadLine();
            double b = double.Parse(input);
            
            Console.Write("c: ");
            input = Console.ReadLine();
            double c = double.Parse(input);

            for (double i = 1.0; i <= 2.0; i += 0.05)
            {
                Console.WriteLine($"{i} - {Y(a, b, c, i)}");
            }
        }
    }
}