using System;
using System.Linq;

namespace Task_02
{
    class Program
    {
        public static int[] Init(int n)
        {
            var m = new int[n];
            var rnd = new Random();

            for (var i = 0; i < n; i++)
                m[i] = rnd.Next(1, 10001);

            return m;
        }

        public static void Print(int[] m)
        {
            Array.ForEach(m, x => Console.Write(x + " "));
            Console.WriteLine();
        }

        public static bool Polyndrom(int x)
        {
            int y = 0, z = x;
            while (z > 0)
            {
                y = y * 10 + z % 10;
                z /= 10;
            }

            return y == x;
        }

        public static int MaxDigit(int x)
        {
            var max = 0;
            while (x > 0)
            {
                var digit = x % 10;
                if (digit > max)
                    max = digit;
                x /= 10;
            }

            return max;
        }

        public static int SumOfDigits(int x)
        {
            var sum = 0;
            while (x > 0)
            {
                sum += x % 10;
                x /= 10;
            }

            return sum;   
        }
        
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = Init(n);
            Print(m);
            
            // 1
            var d3 = (from x in m
                where (x >= 10) && (x <= 99) && (x % 3 == 0)
                select x).ToArray();
            Print(d3);
            
            // 2
            var polys = (from x in m
                where Polyndrom(x)
                orderby x 
                select x).ToArray();
            Print(polys);
            
            // 3
            var sortBySum = (from x in m
                orderby SumOfDigits(x)
                select x).ToArray();
            Print(sortBySum);

            // 4
            var sum = (from x in m
                where (x >= 1000) && (x <= 9999)
                select x).ToArray().Sum();
            Console.WriteLine(sum);
            
            // 5
            var min = (from x in m
                where (x >= 10) && (x <= 99)
                select x).ToArray().Min();

            // 6
            var max = (from x in m
                select MaxDigit(x)).ToArray();
            Print(max);
        }
    }
}