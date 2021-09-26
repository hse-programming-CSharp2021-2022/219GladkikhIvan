using System;

namespace Task_03
{
    class Program
    {
        public static void M1(int[] a)
        {
            a = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                a[i] = 1;
        }
        
        public static void M2(ref int[] a) // Меняем саму ссылку.
        {
            a = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                a[i] = 1;
        }
        
        public static void M3(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = 1;
        }

        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 10;
            int[] mas = new int[n]; // Ссылка.

            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(-10, 10);
                Console.Write($"{mas[i]} ");
            }
            Console.WriteLine();
            
            M1(mas);
            foreach (var el in mas) // Не может менять переменную!
                Console.Write($"{el} ");
            Console.WriteLine();
            
            M2(ref mas);
            foreach (var el in mas) // Не может менять переменную!
                Console.Write($"{el} ");
        }
    }
}