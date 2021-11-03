using System;

namespace Theory_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                var point1 = new Point2D();
                var point2 = new Point2D();

                (point2.X, point2.Y) = (5, 10);
            */

            var point1 = new Point2D(5, 10);
            var point2 = new Point2D(20, 30);
            
            Console.WriteLine(point1.X);
            Console.WriteLine(point1.Y);
            Console.WriteLine(point2.X);
            Console.WriteLine(point2.Y);
            
            Point2D.PrintName();

            Console.WriteLine(point1.Distance());
            Console.WriteLine(point2.Distance());
            Console.WriteLine(point1.Distance(point2));
            
            Console.WriteLine(point2 + point1);
            Console.WriteLine(point2 - point1);
            
            // Перегружено только для (Point2D, int).
            Console.WriteLine(point2 + 5);
            // Console.WriteLine(5 + point2); - так нельзя!
        }
    }

    class Point2D // internal
    {
        // Плохо! Нарушена инкапсуляция!
        // public int x, y;

        //private int x, y;

        public int X { get; set; }
        public int Y { get; set; }
        
        /*
            public int Y
            {
                get => y; // Доступ.
                set => y = value; // Запись.
            }
        */

        public Point2D(int x = 0, int y = 0) => (X, Y) = (x, y);

        public static void PrintName() => Console.WriteLine("Point2D");
        
        public double Distance() => Math.Sqrt(X * X + Y * Y);
        public double Distance(Point2D point) => Math.Sqrt(Math.Pow(X - point.X, 2) + Math.Pow(Y - point.Y, 2));

        public static Point2D operator +(Point2D p1, Point2D p2)
            => new Point2D(p1.X + p2.X, p1.Y + p2.Y);
        public static Point2D operator +(Point2D p1, int a)
            => new Point2D(p1.X + a, p1.Y + a);
        public static Point2D operator -(Point2D p1, Point2D p2)
            => new Point2D(p1.X - p2.X, p1.Y - p2.Y);

        public override string ToString() => $"[{X}; {Y}]";
    }
}