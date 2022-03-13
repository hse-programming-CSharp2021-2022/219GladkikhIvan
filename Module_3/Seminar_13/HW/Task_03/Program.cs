using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle nums:\n");
            var tn = new TriangleNums();
            foreach (var num in tn.GetNums(5))
                Console.WriteLine(num);
            Console.WriteLine("\n* * * * *\n");
            
            Console.WriteLine("Fibonacci:\n");
            var fib = new Fibonacci();
            foreach (var num in fib.GetNums(5))
                Console.WriteLine(num);
            Console.WriteLine("\n* * * * *\n");
            
            Console.WriteLine("Combine:\n");
            foreach (var num in Combine(tn.GetNums(5), fib.GetNums(5)))
                Console.WriteLine(num);
        }

        private static IEnumerable Combine(IEnumerable<int> col1, IEnumerable<int> col2)
        {
            var enum1 = col1.GetEnumerator();
            var enum2 = col2.GetEnumerator();
            while (enum1.MoveNext() && enum2.MoveNext())
                yield return enum1.Current + enum2.Current;
        }
    }
}