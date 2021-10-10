using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int[] m = new int[k];
            
            // Заполняем массив случайнми числами.
            Init(m);
            Array.ForEach(m, (int a) => Console.Write(a + " "));
            Console.WriteLine();
            
            // Сортировка по чётности.
            Array.Sort(m, EvenOdd);
            Array.ForEach(m, (int a) => Console.Write(a + " "));
            Console.WriteLine();
            
            // Сортировка по кол-ву цифр.
            Array.Sort(m, CountOfDigits);
            Array.ForEach(m, (int a) => Console.Write(a + " "));
            Console.WriteLine();
            
            // Сортировка по сумме цифр.
            Array.Sort(m, SumOfDigits);
            Array.ForEach(m, (int a) => Console.Write(a + " "));
            Console.WriteLine();
        }

        public static void Init(int[] m)
        {
            Random rnd = new Random();
            for (int i = 0; i < m.Length; i++)
                m[i] = rnd.Next(0, 1001);
        }

        public static int EvenOdd(int a, int b)
        {
            if (a % 2 == 0 && b % 2 != 0)
                return -1;
            if (a % 2 != 0 && b % 2 == 0)
                return 1;
            return 0;
        }

        public static int Count(int a)
        {
            int k = 0;

            do
            {
                k++;
                a /= 10;
            } while (a > 0);

            return k;
        }
        
        public static int CountOfDigits(int a, int b)
        {
            if (Count(a) > Count(b))
                return -1;
            if (Count(a) < Count(b))
                return 1;
            return 0;
        }
        
        public static int Sum(int a)
        {
            int sum = 0;

            do
            {
                sum += a % 10;
                a /= 10;
            } while (a > 0);

            return sum;
        }
        
        public static int SumOfDigits(int a, int b)
        {
            if (Sum(a) > Sum(b))
                return -1;
            if (Sum(a) < Sum(b))
                return 1;
            return 0;
        }
    }
}