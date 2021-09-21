using System;

namespace Task_03
{
    class Program
    {
        public static double G(double x)
        {
            if (x <= 0.5)
                return Math.Sin(Math.PI / 2);
            else
                return Math.Sin(Math.PI * (x - 1) / 2);
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите X: ");
            string sx = Console.ReadLine();
            double x;
            
            if (double.TryParse(sx, out x))
                Console.WriteLine(G(x));
            else 
                Console.WriteLine("Ошибка ввода!");
        }
    }
}