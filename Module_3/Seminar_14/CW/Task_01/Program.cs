using System;
using System.Linq;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = Generate(n);
            Array.ForEach(m, Console.WriteLine);
            Console.WriteLine("* * * * *");
            
            // Task 1.
            var z1 = from x in m
                select Math.Abs(x) % 10;
            Console.WriteLine("Task 1 (запрос):");
            foreach (var el in z1)
                Console.WriteLine(el);
            Console.WriteLine("* * * * *");

            var z1_1 = m.Select(x => Math.Abs(x) % 10);
            Console.WriteLine("Task 1 (функция):");
            foreach (var el in z1_1)
                Console.WriteLine(el);
            Console.WriteLine("* * * * *");

            // Task 2.
            var z2 = from x in m
                group x by Math.Abs(x) % 10
                into newG
                select newG;
            Console.WriteLine("Task 2 (запрос):");
            foreach (var el in z2)
            {
                Console.WriteLine($"Ends with {el.Key}");
                foreach (var e in el)
                    Console.WriteLine(e);
            }
            Console.WriteLine("* * * * *");

            var z2_1 = m.GroupBy(x => Math.Abs(x) % 10);
            Console.WriteLine("Task 2 (функция):");
            foreach (var el in z2_1)
            {
                Console.WriteLine($"Ends with {el.Key}");
                foreach (var e in el)
                    Console.WriteLine(e);
            }
            Console.WriteLine("* * * * *");
            
            // Task 3.
            var z3 = (from x in m
                where x > 0 && x % 2 == 0
                select x).Count();
            Console.WriteLine("Task 3 (запрос):");
            Console.WriteLine(z3);
            Console.WriteLine("* * * * *");

            var z3_1 = m.Count(x => x > 0 && x % 2 == 0);
            Console.WriteLine("Task 3 (функция):");
            Console.WriteLine(z3_1);
            Console.WriteLine("* * * * *");
            
            // Task 4.
            var z4 = (from x in m
                where x % 2 == 0
                select x).Sum();
            Console.WriteLine("Task 4 (запрос):");
            Console.WriteLine(z4);
            Console.WriteLine("* * * * *");

            var z4_1 = m.Where(x => x % 2 == 0).Sum();
            Console.WriteLine("Task 4 (функция):");
            Console.WriteLine(z4_1);
            Console.WriteLine("* * * * *");
            
            // Task 5.
            var z5 = from x in m
                orderby GetFirstDigit(x), Math.Abs(x) % 10
                select x;
            Console.WriteLine("Task 5 (запрос):");
            foreach (var el in z5)
                Console.WriteLine(el);
            Console.WriteLine("* * * * *");

            var z5_1 = m.OrderBy(x => GetFirstDigit(x)).ThenBy(x => Math.Abs(x) % 10);
            Console.WriteLine("Task 5 (функция):");
            foreach (var el in z5_1)
                Console.WriteLine(el);
            Console.WriteLine("* * * * *");
        }

        static int[] Generate(int n)
        {
            var rnd = new Random();
            var m = new int[n];
            for (var i = 0; i < n; i++)
                m[i] = rnd.Next(-10000, 10001);
            return m;
        }

        static int GetFirstDigit(int x)
        {
            x = Math.Abs(x);
            while (x >= 10)
                x /= 10;
            return x;
        }
    }
}