using System;

namespace Task_02
{
    class Program
    {
        public static int P(int x) // Получаем наибольшее целое число, которое можно получить переставляя цифры трёхзначного числа x
        {
            int a = x % 10,      // 3я цифра
                b = x / 10 % 10, // 2я цифра
                c = x / 100;     // 1я цифра

            if ((a >= b) && (a >= c))
                return a * 100 + Math.Max(b, c) * 10 + Math.Min(b, c);
            else if ((b >= a) && (b >= c))
                return b * 100 + Math.Max(a, c) * 10 + Math.Min(a, c);
            else
                return c * 100 + Math.Max(a, b) * 10 + Math.Min(a, b);
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите натуральное трёхзначное число P: ");
                string s = Console.ReadLine();
                int x = 0;
                if (int.TryParse(s, out x) && (x >= 100) && (x <= 999)) 
                {
                    int res = P(x);
                    Console.WriteLine($"Наибольшее целое число, которое можно получить переставляя цифры P: {res}");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода!");
                }
                
                Console.WriteLine("Для выхода нажмите ESC. Для продолжения - любую другую клавишу.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
