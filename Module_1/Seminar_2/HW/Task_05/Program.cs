using System;

namespace Task_05
{
    class Program
    {
        public static string Check(double a, double b, double c)
        {
            return ((a < b + c) && (b < a + c) && (c < a + b)) ? "Введённые числа удовлетворяют неравенству треугольника." : "Введённые числа не удовлетворяют неравенству треугольника.";
        }
        public static string Error()
        {
            return "Ошибка ввода!";
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите первое число: ");
                string sa = Console.ReadLine();
                Console.Write("Введите второе число: ");
                string sb = Console.ReadLine();
                Console.Write("Введите третье число: ");
                string sc = Console.ReadLine();

                double a, b, c;

                string res = (double.TryParse(sa, out a) && double.TryParse(sb, out b) && double.TryParse(sc, out c)) ? Check(a, b, c) : Error();
                Console.WriteLine(res);
                Console.WriteLine("Для выхода нажмите ESC. Для продолжения - любую другую клавишу.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
