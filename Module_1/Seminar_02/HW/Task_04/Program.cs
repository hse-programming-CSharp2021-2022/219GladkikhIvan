using System;

namespace Task_04
{
    class Program
    {
        public static string Rev(int a)
        {
            string res = "";
            for (int i = 0; i < 4; i++)
            {
                res += a % 10 + " ";
                a /= 10;
            }
            return res;
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите четырёхзначное число: ");
                string input = Console.ReadLine();
                int a;
                if (int.TryParse(input, out a) && (a >= 1000) && (a <= 9999))
                    Console.WriteLine("Цифры этого числа в обратном порядке: " + Rev(a));
                else
                    Console.WriteLine("Ошибка ввода!");
                Console.WriteLine("Для выхода нажмите ESC. Для продолжения - любую другую клавишу.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
