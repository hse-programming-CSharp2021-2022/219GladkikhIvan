using System;

namespace Task_03
{
    class Program
    {
        public static int[,] Snake(int n)
        {
            int[,] m = new int[n, n];
            int k = 1;
            for (int i = 0; i < n; i++)
                if (i % 2 == 0)
                    for (int j = 0; j < n; j++)
                        m[i, j] = k++;
                else
                    for (int j = n - 1; j >= 0; j--)
                        m[i, j] = k++;
            return m;
        }

        public static void Spiral(int[,] m, int count, int maxCount, int si, int sj)
        {
            if (count > maxCount)
                return;
            for (var j = sj; j < m.GetLength(0) - sj; j++)
            {
                m[si, j] = count;
                count++;
            }

            for (var i = si + 1; i < m.GetLength(0) - si; i++)
            {
                m[i, m.GetLength(0) - sj - 1] = count;
                count++;
            }

            for (var j = m.GetLength(0) - sj - 2; j > sj; j--)
            {
                m[m.GetLength(0) - si - 1, j] = count;
                count++;
            }

            for (var i = m.GetLength(0) - si - 1; i > si; i--)
            {
                m[i, sj] = count;
                count++;
            }
            
            Spiral(m, count, maxCount, si + 1, sj + 1);
        }
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[,] m = Snake(n);
            for (int i = 0; i < n; i++, Console.WriteLine())
                for (int j = 0; j < n; j++)
                    Console.Write(m[i, j] + " ");
            
            Spiral(m, 1, n*n, 0, 0);
            for (int i = 0; i < n; i++, Console.WriteLine())
            for (int j = 0; j < n; j++)
                Console.Write(m[i, j] + " ");
        }
    }
}