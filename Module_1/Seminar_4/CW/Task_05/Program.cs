using System;

namespace Task_05
{
    class Program
    {
        public static double Total(double k, double r, uint n)
        {
            if (n == 0)
                return k;
            else
                return Total(k * (1 + r) / 100, r, n - 1);
        }

        static void Main(string[] args)
        {
            string sk = Console.ReadLine();
            string sr = Console.ReadLine();
            string sn = Console.ReadLine();

            double k = double.Parse(sk);
            double r = double.Parse(sk);
            uint n = uint.Parse(sn);
            
            Console.WriteLine(Total(k, r, n));
        }
    }
}