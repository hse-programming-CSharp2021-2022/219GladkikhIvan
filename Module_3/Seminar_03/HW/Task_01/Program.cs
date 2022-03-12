using System;
using System.Net.NetworkInformation;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out var x);
            int.TryParse(Console.ReadLine(), out var y);

            var dot = new Dot(x, y);
            dot.OnCoordChanged += PrintInfo;
            dot.DotFlow();
        }

        static void PrintInfo(Dot dot)
            => Console.WriteLine($"({dot.X};{dot.Y})");
    }

    public delegate void CoordChanged(Dot dot);

    public class Dot
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Dot(int x, int y)
            => (X, Y) = (x, y);

        public event CoordChanged OnCoordChanged;

        public void DotFlow()
        {
            var rnd = new Random();
            for (var i = 0; i < 10; i++)
            {
                (X, Y) = (rnd.Next(-10, 11), rnd.Next(-10, 11));
                if (X < 0 && Y < 0)
                    OnCoordChanged?.Invoke(this);
            }
        }
    }
}