using System;

namespace Task_04
{
    class Program
    {
        public static int A(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if ((m > 0) && (n == 0))
                return A(m - 1, 1);
            else
                return A(m - 1, A(m, n - 1));
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите m: ");
            string sm = Console.ReadLine();
            Console.Write("Введите n: ");
            string sn = Console.ReadLine();

            int m, n;
            
            if (int.TryParse(sm, out m) && int.TryParse(sn, out n))
                Console.WriteLine("A(m, n) = " + A(m, n));
            else 
                Console.WriteLine("Ошибка ввода!");
        }
    }
}