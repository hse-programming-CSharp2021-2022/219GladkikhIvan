using System;

namespace Theory_01
{
    abstract class RightFigure
    {
        public int Side { get; }

        public RightFigure(int s)
        {
            Side = s;
        }
        public RightFigure() {}

        public abstract double Area { get; }
        public abstract int Perimetr();

        public override string ToString()
            => $"Side = {Side}; Area = {Area}; Perimetr = {Perimetr()}";
    }
    
    class RightTriangle : RightFigure
    {
        public RightTriangle(int s) : base(s) { }
        
        public override double Area => Side * Side * Math.Sqrt(3) / 4;

        public override int Perimetr() => 3 * Side;
        
    }
    
    class Square : RightFigure
    {
        public Square(int s) : base(s) { }
        public override double Area => Side * Side;

        public override int Perimetr() => 4 * Side;
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new RightTriangle(10);
            Console.WriteLine(triangle.Area);
            Console.WriteLine(triangle.Perimetr());
            
            RightFigure triangle2 = new RightTriangle(10);
            Console.WriteLine(triangle2.Area);
            Console.WriteLine(triangle2.Perimetr());
            
            var square = new Square(10);
            Console.WriteLine(square.Area);
            Console.WriteLine(square.Perimetr());

            var rnd = new Random();
            var figures = new RightFigure[10];
            for (var i = 0; i < 5; i++)
                figures[i] = new RightTriangle(rnd.Next(10));
            for (var i = 5; i < 10; i++)
                figures[i] = new Square(rnd.Next(10));
            Array.ForEach(figures, Console.WriteLine);
        }
    }
}