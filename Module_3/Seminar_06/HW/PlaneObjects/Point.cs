using System;

namespace PlaneObjects
{
    public readonly struct Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
            => (X, Y) = (x, y);

        public double Distance(Point p)
            => Math.Pow(p.X - X, 2) + Math.Pow(p.Y - Y, 2);

        public double RVectorLength()
            => Distance(new Point(0, 0));
        
        public override string ToString()
            => $"({X:f2};{Y:f2})";
    }
}