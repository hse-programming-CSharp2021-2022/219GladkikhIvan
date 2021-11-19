using System;

public class Shape
{
    public const double PI = Math.PI;
    protected double _x, _y;

    public Shape()
    {
    }

    public Shape(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public virtual double Area()
    {
        return _x * _y;
    }
}

public class Circle : Shape
{
    public Circle(double r) : base(r, 0)
    {
    }

    public override double Area()
    {
        return PI * _x * _x;
    }
}

public class Sphere : Shape
{
    public Sphere(double r) : base(r, 0)
    {
    }

    public override double Area()
    {
        return 4 * PI * _x * _x;
    }
}

public class Cylinder : Shape
{
    public Cylinder(double r, double h) : base(r, h)
    {
    }

    public override double Area()
    {
        return 2 * PI * _x * _x + 2 * PI * _x * _y;
    }
}

class Program
{
    static Random rnd = new Random();
    public static void Main(string[] args)
    {
        var n1 = rnd.Next(3, 6);
        var n2 = rnd.Next(3, 6);
        var n3 = rnd.Next(3, 6);

        var n = n1 + n2 + n3;

        var m = new Shape[n];
        for (var i = 0; i < n1; i++)
            m[i] = new Circle(rnd.Next());
        for (var i = 0; i < n2; i++)
            m[n1 + i] = new Cylinder(rnd.Next(), rnd.Next());
        for (var i = 0; i < n3; i++)
            m[n1 + n2 + i] = new Sphere(rnd.Next());
        Array.Sort(m, Shuffler);
        Console.WriteLine("Площади всех фигур:");
        Array.ForEach(m, x => Console.WriteLine(x.GetType() + " " + x.Area()));
        Console.WriteLine();
        Array.Sort(m, Comparator);
        Console.WriteLine("Площади всех фигур:");
        Array.ForEach(m, x => Console.WriteLine(x.GetType() + " " + x.Area()));
    }

    public static int Comparator(Shape a, Shape b)
    {
        var na = GetCode(a);
        var nb = GetCode(b);

        if (na > nb)
            return 1;
        if (na < nb)
            return -1;
        return 0;
    }

    public static int Shuffler(Shape a, Shape b) => rnd.Next(-1, 2);
    
    public static int GetCode(Shape a)
    {
        return a switch
        {
            Circle => 0,
            Cylinder => 1,
            Sphere => 2,
            _ => 3
        };
    }
}