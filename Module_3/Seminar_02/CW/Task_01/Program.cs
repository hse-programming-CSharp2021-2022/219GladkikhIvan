using System;

namespace Task_01
{
    public delegate int Cast(double x);
    class Program
    {
        static void Main(string[] args)
        {
            Cast c1 = delegate(double x)
            {
                var y = (int) Math.Round(x);
                if (y % 2 != 0)
                    if (y > x)
                        y--;
                    else
                        y++;
                return y;
            };
            
            Cast c2 = (double x) =>
            {
                var k = 0;
                var y = (int) x;
                while (y > 0)
                {
                    y /= 10;
                    k++;
                }

                return k;
            };
            
            var rnd = new Random();
            double x;
            
            for (var i = 0; i < 3; i++)
            {
                x = rnd.NextDouble()*1000;
                Console.WriteLine("Input: " + x);
                Console.WriteLine("C1: " + c1(x));
                Console.WriteLine("C2: " + c2(x));
            }
            
            var c0 = c1;
            c0 += c2;

            x = rnd.NextDouble()*1000; 
            Console.WriteLine("Input: " + x);
            
            Console.WriteLine("C0: " + c0.Invoke(x));
            c0 -= (double x) =>
            {
                var k = 0;
                var y = (int) x;
                while (y > 0)
                {
                    y /= 10;
                    k++;
                }

                return k;
            };
            
            Console.WriteLine("C0: " + c0.Invoke(x));
            c0 -= c2;
            Console.WriteLine("C0: " + c0.Invoke(x));
        }
    }
}