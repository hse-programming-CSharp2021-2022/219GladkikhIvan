using System;

namespace Task_02
{
    class Program
    {
        public static bool Function1(bool p, bool q)
        {
            return !(p & q) & !(p | !q);
        }

        public static void Function2(bool p, bool q, out bool res)
        {
            res = !(p & q) & !(p | !q);    
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("F = !(p & q) & !(p | !q)");
            Console.WriteLine("p     q     F");
            Console.WriteLine("False False " + Function1(false, false));
            Console.WriteLine("False True  " + Function1(false, true));
            Console.WriteLine("True  False " + Function1(true, false));
            Console.WriteLine("True  True  " + Function1(true, true));
        }
    }
}