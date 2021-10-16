using System;

namespace Task_03
{
    class Program
    {
        static double[] Sin1(uint n)
        {
            var series = new double[n];
            for (var i = 0; i < n; i++)
                series[i] = Math.Pow(-1, i) / (2 * i + 1);
            return series;
        }

        static double SinX(double x, double[] sin1)
        {
            double sin = 0;
            for (var i = 0; i < sin1.Length; i++)
                sin += Math.Pow(x, 2 * i + 1) * sin1[i];
            return sin;
        }
        
        static void Main(string[] args)
        {
            var n = uint.Parse(Console.ReadLine());
            var sin1 = Sin1(n);
            do
            {
                var x = double.Parse(Console.ReadLine());
                Console.WriteLine(SinX(x, sin1));
                Console.WriteLine(Math.Sin(x) + "\n");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}