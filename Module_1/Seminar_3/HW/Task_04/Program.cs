using System;

namespace Task_04
{
    class Program
    {
        public static int Check(int a, int b, int c)
        {
            int min = a;
            if ((min / 100 == b / 100) && (b < min))
                min = b;
            if ((min / 100 == c / 100) && (c < min))
                min = c;
            return min;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите номер первой аудитории: ");
            string sa = Console.ReadLine();
            Console.Write("Введите номер второй аудитории: ");
            string sb = Console.ReadLine();
            Console.Write("Введите номер третье аудитории: ");
            string sc = Console.ReadLine();

            int a, b, c;

            bool type = int.TryParse(sa, out a) & int.TryParse(sb, out b) & int.TryParse(sc, out c);
            bool value = type && (a >= 100) && (a <= 999) && (b >= 100) && (b <= 999) && (c >= 100) && (c <= 999);
            if (value)
                Console.WriteLine($"Аудитория с наименьшим номером на этаже - {Check(a, b, c)}.");
            else
                Console.WriteLine("Ошибка ввода!");
        }
    }
}