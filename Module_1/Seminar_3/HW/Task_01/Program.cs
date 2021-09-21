using System;

namespace Task_01
{
    class Program
    {
        public static bool G(double x, double y)
        {
            return (x * x + y * x <= 4) && (x >= y) && (x >= 0);
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