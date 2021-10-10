using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] m = new int[n][];
            Random rnd = new Random();
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = new int[rnd.Next(5, 16)];
                for (int j = 0; j < m[i].Length; j++)
                    m[i][j] = rnd.Next(-10, 11);
            }
            Print(m);
            
            for (int i = 0; i < m.Length; i++)
                Array.Sort(m[i], (int a, int b) => (a < b) ? 1 : ((a > b) ? -1 : 0));
            Array.Sort(m, Comparer);
            Print(m);
        }

        public static void Print(int[][] a)
        {   
            Array.ForEach(a, el =>
            {
                Array.ForEach(el, elem => Console.Write(elem + " "));
                Console.WriteLine();
            });
            Console.WriteLine();
        }

        public static int Comparer(int[] a, int[] b)
        {
            if (a.Length < b.Length)
                return -1;
            if (a.Length > b.Length)
                return 1;
            return 0;
        }
    }
}