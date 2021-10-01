using System;

namespace Task_02
{
    class Program
    {
        public static void Init(int[] m)
        {
            int[] num = new int[100];
            for (int i = 0; i <= 99; i++)
                num[i] = i + 1;
            Array.Sort(num, Comparer);
            Array.Copy(num, m, 99);
        }

        public static int Comparer(int a, int b)
        {
            Random rnd = new Random();
            return rnd.Next(-1, 2);
        }
        
        public static void Print(int[] mas)
        {
            foreach (int a in mas)
                Console.Write(a + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] mas = new int[99];
            Init(mas);

            int sum = 0;
            foreach (int x in mas)
                sum += x;
            Console.WriteLine(5050 - sum);
        }
    }
}