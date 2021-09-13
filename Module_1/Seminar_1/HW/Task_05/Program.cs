using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину первого катета: ");
            string sa = Console.ReadLine();
            Console.Write("Введите длину второго катета: ");
            string sb = Console.ReadLine();
            int a;
            int b;
            if ((int.TryParse(sa, out a)) & (int.TryParse(sb, out b)))
            {
                Console.WriteLine("Длина гипотенузы: " + Math.Sqrt(a*a + b*b));
            }
            else
                Console.WriteLine("Неверный формат ввода!");

            Console.ReadLine();
        }
    }
}