using System;

namespace Task_01
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
            => (X, Y) = (x, y);
    }

    class TriangleComp
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }
        
        public double AB { get; }
        public double AC { get; }
        public double BC { get; }
        
        public TriangleComp(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            A = new Point(x1, y1);
            B = new Point(x2, y2);
            C = new Point(x3, y3);

            AB = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            AC = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            BC = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
        }

        public double Square
        {
            get
            {
                var p = (AB + BC + AC) / 2;
                return Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));
            }
        }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}