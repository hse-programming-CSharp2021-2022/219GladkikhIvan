using System;
using System.Text;

namespace CW
{
    class Program
    {
        static StringBuilder CreateString(uint n)
        {
            var rnd = new Random();
            var str = new StringBuilder();
            for (var i = 0; i < n; i++)
                str.Append(rnd.Next(0, 10));
            return str;
        }

        static StringBuilder MoveOff(StringBuilder s)
        {
            for (var i = 0; i < s.Length; i++)
                if (int.Parse(s[i].ToString()) % 2 == 0)
                    s.Remove(i--, 1);
            return s;
        }
        
        static void Main(string[] args)
        {
            var n = uint.Parse(Console.ReadLine());
            var s = CreateString(n);
            Console.WriteLine(s);
            s = MoveOff(s);
            Console.WriteLine(s);
        }
    }
}