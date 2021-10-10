using System;

namespace Task_06
{
    class Program
    {
        public static ulong  Fact(ulong a)
        {
            ulong f = 1;
            for (ulong i = 2; i <= a; i++)
                f = f * i;
            return f;
        }
        
        public static double S1(double x)
        {
            double s = x * x;
            double sl = 0;
            ulong i = 3;
            while (Math.Abs(sl - s) > 0.000000000000001)
            {
                sl = s;
                s += Math.Pow(-1, i) * (Math.Pow(2, i) * Math.Pow(x, i + 1)) / Fact(i + 1);
                i += 2;
            }

            return s;
        }
        
        public static double S2(double x)
        {
            double s = 1;
            double sl = 0;
            ulong i = 1;
            while (Math.Abs(sl - s) > 0.000000000000001)
            {
                sl = s;
                s += Math.Pow(x, i) / Fact(i);
                i++;
            }

            return s;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите вещественное число: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double x))
            {
                Console.WriteLine($"S1 = {S1(x)}");
                Console.WriteLine($"S2 = {S2(x)}");
            }
        }
    }
}