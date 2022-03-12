using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var f1 = new F(x => x * x - 4);
            var f2 = new F(Math.Sin);

            var g = new G(f1, f2);
            for (double x = 0; x <= Math.PI; x += Math.PI / 16)
                Console.WriteLine($"x0 = {x:f4}; g(x0) = {g.GF(x):f4}");
        }
    }
}