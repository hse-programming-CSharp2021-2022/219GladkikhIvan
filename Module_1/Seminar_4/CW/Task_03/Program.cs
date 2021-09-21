using System;

namespace Task_03
{
    class Program
    {
        public static int CountDigits(int a, int k)
        {
            if (a > 0)
                return CountDigits(a / 10, k + 1);
            else
                return k;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();
            int a = int.Parse(input);
            Console.WriteLine(CountDigits(a, 0));
        }
    }
}