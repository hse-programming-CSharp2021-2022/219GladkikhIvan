// Использовал много методов и тернарных операций, потому что в задании запретили использовать if

using System;

namespace Task_03
{
    class Program
    {
        public static string R2(double D, double a, double b) // Считает корни при D > 0
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            string res = $"x1 = {x1:f3}; x2 = {x2:f3}";
            return res;
        }
        public static string R1(double D, double a, double b) // Считает корень при D = 0
        {
            double x = (-b + Math.Sqrt(D)) / (2 * a);
            string res = $"x1 = x2 = {x:f3}";
            return res;
        }
        public static string C(double D, double a, double b) // Находит комплексные корни при D < 0
        {
            double sqrtD = Math.Sqrt(Math.Abs(D));
            string res = $"x1, x2 = ({-b:f3} +- i*{sqrtD:f3}) / {2*a:f3}";
            return res;
        }
        public static string Work(double a, double b, double c) // Находит корни уравнения и записывает результат в строку
        {
            double D = b * b - 4 * a * c;
            string res = (D > 0) ? R2(D, a, b) : ((D == 0) ? R1(D, a, b) : C(D, a, b));
            return res;
        }
        public static string Error() // Сообщает о неверном формате ввода 
        {
            return "Ошибка ввода!";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Это программа для вычисления корней квадратного уравнения вида A*x^2 + B*x + C = 0");
            do
            {
                Console.Write("Введите коэффицент A != 0: ");
                string sa = Console.ReadLine();
                Console.Write("Введите коэффицент B: ");
                string sb = Console.ReadLine();
                Console.Write("Введите коэффицент C: ");
                string sc = Console.ReadLine();
                double a, b, c;
                string res = (double.TryParse(sa, out a) && (a != 0) && double.TryParse(sb, out b) && double.TryParse(sc, out c)) ? Work(a, b, c) : Error();
                Console.WriteLine(res);
                Console.WriteLine("Для выхода нажмите ESC. Для продолжения - любую другую клавишу.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
