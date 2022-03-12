using System;
using System.Text;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var arr = new Person[rnd.Next(3, 10)];
            for (var i = 0; i < arr.Length; i++)
                arr[i] = new Person(GenerateString(), GenerateString(), rnd.Next(1, 101));
            Array.ForEach(arr, x => Console.WriteLine(x));
            Console.WriteLine("\n* * * * *\n");
            Array.Sort(arr);
            Array.ForEach(arr, x => Console.WriteLine(x));
        }

        private static string GenerateString()
        {
            var rnd = new Random();
            var s = new StringBuilder();
            s.Append((char) rnd.Next('A', 'Z' + 1));
            var n = rnd.Next(0, 7);
            for (var i = 0; i < n; i++)
                s.Append((char) rnd.Next('a', 'z' + 1));
            return s.ToString();
        }
    }
}