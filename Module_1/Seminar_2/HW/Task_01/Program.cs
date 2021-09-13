using System;

namespace Task_01
{
    class Program
    {
        public static double F(double x) // Вычисление значения полинома
        {
            double res = 0;
            res = x * (x * (x * (12 * x + 9) - 3) + 2) - 4;
            return res;
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите x: ");
                string s = Console.ReadLine();
                double x = 0;
                if (!double.TryParse(s, out x)) // Проверяем корректность ввода
                {
                    Console.WriteLine("Ошибка ввода!");
                    return;
                }
                double res = F(x); // Вычисляем значение полинома
                Console.WriteLine($"Значение полинома: {res:f4}"); // Выводим это значение
                Console.WriteLine("Для выхода нажмите ESC. Для продолжения - любую другую клавишу.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
