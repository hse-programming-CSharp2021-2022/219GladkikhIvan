using System;

namespace Task_01
{
    internal interface IFigure
    {
        double GetArea { get; }
    }

    class Square : IFigure
    {
        public Square(double side)
        {
            Side = side;
        }
        
        public double Side { get; private set; }

        public double GetArea => Side * Side;
    }

    class Round : IFigure
    {
        public Round(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; private set; }

        public double GetArea => Math.PI * Radius * Radius;
    }
    
    class Program
    {
        public static void MyMethod<T>(T[] figures, double limit)
            where T : IFigure
        {
            foreach (T figure in figures)
            {
                if (figure.GetArea > limit)
                {
                    Console.WriteLine($"This is {figure.GetType()}; area = {figure.GetArea:F3}");
                }
            }
        }
        
        static void Main(string[] args)
        {
            IFigure[] figures = new IFigure[5];
            
            Square[] squares = new Square[5];
            Round[] rounds = new Round[5];
            
            Random rnd = new();
            for (int i = 0; i < figures.Length; i++)
            {
                if (rnd.Next(2) == 1)
                {
                    figures[i] = new Square(rnd.Next(6));
                }
                else
                {
                    figures[i] = new Round(rnd.Next(6));
                }

                squares[i] = new Square(rnd.Next(6));
                rounds[i] = new Round(rnd.Next(6));
            }
            MyMethod(figures, 5);
            Console.WriteLine();
            
            MyMethod(squares, 5);
            Console.WriteLine();
            
            MyMethod(rounds, 5);
        }
    }
}