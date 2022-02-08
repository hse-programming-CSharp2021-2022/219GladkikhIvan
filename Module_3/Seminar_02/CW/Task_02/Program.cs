using System;
using System.Text;

namespace Task_02
{
    public delegate string ConvertRule(string s);

    class Converter
    {
        public string Convert(string str, ConvertRule cr)
            => cr(str);
    }
    
    class Program
    {
        public static string RemoveDigits(string str)
        {
            var digits = "0123456789";
            var sb = new StringBuilder();
            foreach (var t in str)
                if (!digits.Contains(t))
                    sb.Append(t);
            return sb.ToString();
        }

        public static string RemoveSpaces(string str)
        {
            var sb = new StringBuilder();
            foreach (var t in str)
                if (t != ' ')
                    sb.Append(t);
            return sb.ToString();    
        }

        public static string Generate()
        {
            var rnd = new Random();
            var k = rnd.Next(1, 10);
            var sb = new StringBuilder(k);
            var digits = "0123456789abcdefghi   ";
            for (var i = 0; i < k; i++)
            {
                var n = rnd.Next(digits.Length);
                sb.Append(digits[n]);
            }

            return sb.ToString();
        }
        
        static void Main(string[] args)
        {
            var m = new string[3];
            for (var i = 0; i < 3; i++)
                m[i] = Generate();
            Array.ForEach(m, Console.WriteLine);
            Console.WriteLine();
            
            var converter = new Converter();
            ConvertRule c1 = RemoveDigits;
            ConvertRule c2 = RemoveSpaces;
            foreach (var t in m)
            {
                Console.WriteLine("C1: " + c1(t));    
                Console.WriteLine("C2: " + c2(t));    
            }
            Console.WriteLine();

            ConvertRule c0 = RemoveDigits;
            c0 += RemoveSpaces;
            foreach (var t in m)
            {
                Console.WriteLine("C0: " + c0(t));
            }
            Console.WriteLine();
            
            var rules = c0.GetInvocationList();
            for (var i = 0; i < m.Length; i++)
                foreach (ConvertRule r in rules)
                {
                    m[i] = r(m[i]);
                }
            Array.ForEach(m, Console.WriteLine);
        }
    }
}