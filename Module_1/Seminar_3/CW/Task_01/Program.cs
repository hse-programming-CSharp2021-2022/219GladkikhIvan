using System;

namespace Task_01
{
    class Program
    {
        public static void MinMax(int a, out int minNumber, out int maxNumber)
        {
            int next;
            minNumber = 10;
            maxNumber = -1;
            while (a > 0)
            {
                next = a % 10;
                a /= 10;
                if (next < minNumber)
                    minNumber = next;
                if (next > maxNumber)
                    maxNumber = next;
            }
            Console.WriteLine(minNumber);
            Console.WriteLine(maxNumber);
        }

        public static void Add(int a)
        {
            Console.WriteLine(a);
            a += 10;
            Console.WriteLine(a);
        }
        
        public static void Add(ref int a)
        {
            Console.WriteLine(a);
            a += 10;
            Console.WriteLine(a);
        }

        public static void Adder(out int res, params int[] arr) //params должен быть последним
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            res = sum;
        }
        
        public static void Add2(out int a)
        {
            a = 10;
            Console.WriteLine(a);
            a += 10;
            Console.WriteLine(a);
        }
        
        // ref, out - передача значения по ссылке (не могут перегружать друг друга)
        // ref - по входу в метод переменной должно быть присвоено значение
        // out - по выходу из метода переменной будет присвоено значение
        // params
        
        static void Main(string[] args)
        {
            int min, max;
            MinMax(27364392, out min, out max);
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}