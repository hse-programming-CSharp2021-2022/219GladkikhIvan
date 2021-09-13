using System;

namespace Tak_07
{
    class Program
    {
        public static string F(double x) // Возвращает целую и дробную части числа в виде строки
        {
            return String.Format("Целая часть: {0}. Дробная часть: {1}.", Math.Floor(x), x - Math.Floor(x));
        }
        public static string G(double x) // Возвращает корень из числа и его квадрат в виде строки
        {
            string res;
            if (x >= 0)
                res = String.Format("Корень: {0}. Квадрат: {1}.", Math.Sqrt(x), x * x);
            else
                res = String.Format("Корень: i * {0}. Квадрат {1}.", Math.Sqrt(Math.Abs(x)), x * x);
            return res;
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите вещественное число: ");
                string input = Console.ReadLine();
                double x;
                if (double.TryParse(input, out x))
                    Console.WriteLine(F(x) + " " + G(x));
                else
                    Console.WriteLine("Ошибка ввода!");
                Console.WriteLine("Для выхода нажмите ESC. Для продолжения - любую другую клавишу.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
