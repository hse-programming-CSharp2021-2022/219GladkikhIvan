using System;

namespace Task_01
{
    class Program
    {
        public static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            sumEven = 0;
            sumOdd = 0;
            while (number > 0)
            {
                sumEven += number % 10;
                sumOdd += number / 10 % 10;
                number /= 100;
            }
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();
            uint num, sumEven, sumOdd;
            if (uint.TryParse(input, out num))
            {
                Sums(num, out sumEven, out sumOdd);
                Console.WriteLine($"Сумма цифр в чётных разрядах: {sumEven}, " +
                                  $"сумма цифр в нечётных разрядах - {sumOdd}");
            }
            else
                Console.WriteLine("Ошбика ввода!");
        }
    }
}