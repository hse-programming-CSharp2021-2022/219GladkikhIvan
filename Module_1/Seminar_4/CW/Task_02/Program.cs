using System;

namespace Task_02
{
    class Program
    {
        public static double Integral(double A, double B, double delta)
        {
            double i = A;
            double sum = 0;
            while (i+delta <= B)
            {
                sum += delta * (i * i + (i + delta) * (i + delta)) / 2;
                i += delta;
            }

            if (i < B)
                sum += (B - i) * (i * i + B * B) / 2;
            return sum;
        } 
        
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            string sa = Console.ReadLine();
            Console.Write("Введите B: ");
            string sb = Console.ReadLine();
            Console.Write("Введите Delta: ");
            string sd = Console.ReadLine();

            double a, b, delta;
            if (double.TryParse(sa, out a) && double.TryParse(sb, out b) && double.TryParse(sd, out delta))
                Console.WriteLine(Integral(a, b, delta));
            else
                Console.WriteLine("Ошибка ввода");
        }
    }
}