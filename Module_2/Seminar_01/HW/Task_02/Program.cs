using System;

namespace Task_02
{
    class Point
    {
        private int X { get; set; }
        private int Y { get; set; }

        public double Phi
        {
            get
            {
                switch (X)
                {
                    case > 0 when Y >= 0:
                        return Math.Atan((double) Y / X);
                    case > 0 when Y < 0:
                        return Math.Atan((double) Y / X) + 2 * Math.PI;
                    case < 0:
                        return Math.Atan((double) Y / X) + Math.PI;
                    case 0 when Y < 0:
                        return Math.PI / 2;
                    case 0 when Y > 0:
                        return 3 * Math.PI / 2;
                    default:
                        return 0;
                }
            }
        }
        public int Ro => Y * Y + X * X;

        public Point(int x = 0, int y = 0) => (X, Y) = (x, y);

        public override string ToString()
            => $"x = {X}, y = {Y}; r^2 = {Ro}, phi = {Phi}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point[] m;
            m = new Point[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите X{0}: ", i + 1);
                var x = int.Parse(Console.ReadLine());
                Console.Write("Введите Y{0}: ", i + 1);
                var y = int.Parse(Console.ReadLine());
                m[i] = new Point(x, y);
            }
            Array.Sort(m, (a, b) => a.Ro > b.Ro ? 1 : (a.Ro < b.Ro ? -1 : 0));
            Array.ForEach(m, Console.WriteLine);
        }
    }
}