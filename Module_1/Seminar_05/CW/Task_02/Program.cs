using System;

namespace Task_02
{
    class Program
    {
        public static double S(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
                sum += (i + 0.3) / (3 * i * i + 5);
            return sum;
        }
        
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int k = int.Parse(input);
            for (int i = 1; i <= k; i++)
                Console.WriteLine($"{i} - {S(i)}");
        }
    }
}