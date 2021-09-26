using System;

namespace Task_07
{
    class Program
    {
        public static void NokNod(uint a, uint b, out uint nok, out uint nod)
        {
            // Находим НОД.
            uint na = a, nb = b;
            while (na != nb)
                if (na > nb)
                    na -= nb;
                else
                    nb -= na;
            nod = na;
            
            // Находим НОК.
            nok = a * b / nod;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            string sa = Console.ReadLine();
            Console.Write("Введите B: ");
            string sb = Console.ReadLine();

            if (uint.TryParse(sa, out uint a) && uint.TryParse(sb, out uint b))
            {
                uint nok, nod;
                NokNod(a, b, out nok, out nod);
                Console.WriteLine($"НОД = {nod}");
                Console.WriteLine($"НОК = {nok}");
            }
            else
                Console.WriteLine("Ошибка ввода!");
        }
    }
}