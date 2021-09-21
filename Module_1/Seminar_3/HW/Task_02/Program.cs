using System;

namespace Task_02
{
    class Program
    {
        public static double G(double x, double y)
        {
            if ((x < y) && (x > 0))
                return x + Math.Sin(y);
            else if ((x > y) && (x < 0))
                return y - Math.Cos(x);
            else
                return 0.5 * x * y;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите X: ");
            string sx = Console.ReadLine();
            Console.Write("Введите Y: ");
            string sy = Console.ReadLine();

            double x, y;
            
            if (double.TryParse(sx, out x) && double.TryParse(sy, out y))
                Console.WriteLine(G(x, y));
            else 
                Console.WriteLine("Ошибка ввода!");
        }
    }
}