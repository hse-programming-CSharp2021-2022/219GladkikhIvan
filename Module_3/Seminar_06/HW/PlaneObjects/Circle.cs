using System;

namespace PlaneObjects
{
    public readonly struct Circle : IComparable
    {
        public Point Center { get; }
        public double Radius { get; }

        public Circle(double x, double y, double radius)
            => (Center, Radius) = (new Point(x, y), radius);

        public override string ToString()
            => $"Center: {Center}; Radius: {Radius:f3}";

        public int CompareTo(object obj)
            => Center.RVectorLength().CompareTo(((Circle) obj).Center.RVectorLength());
    }
}