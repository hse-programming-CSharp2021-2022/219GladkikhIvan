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
                select x * x;
            Console.WriteLine("Task 1:");
            foreach (var el in z1)
                Console.WriteLine(el);
            Console.WriteLine("* * * * *");
            
            // Task 2.
            var z2 = from x in m
                where x > 0 && (int) Math.Floor(Math.Log10(Math.Abs(x))) == 1
                select x;
            Console.WriteLine("Task 2:");
            foreach (var el in z2)
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
    }
}