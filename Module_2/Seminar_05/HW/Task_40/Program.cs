using System;
using System.Collections.Generic;

abstract class Something { }

class Lentil : Something
{
    public double Weight { get; }

    public Lentil()
    {
        var rnd = new Random();
        Weight = 2*rnd.NextDouble();
    }
}

class Ashes : Something
{
    public double Volume { get; }

    public Ashes()
    {
        var rnd = new Random();
        Volume = rnd.NextDouble();
    }   
}

class Program
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var m = new Something[n];
        var rnd = new Random();
        for (var i = 0; i < n; i++)
        {
            var rndNo = rnd.Next(0, 2);
            m[i] = rndNo == 0 ? new Ashes() : new Lentil();
        }
        Array.ForEach(m, x 
            => Console.WriteLine(x is Ashes ? $"Ashes: {((Ashes) x).Volume}" : $"Lentil: {((Lentil) x).Weight}"));
        Console.WriteLine();
        var ashes = new List<Ashes>();
        var lentil = new List<Lentil>();
        foreach (var x in m)
            if (x is Ashes)
                ashes.Add((Ashes) x);
            else
                lentil.Add((Lentil) x);
        Console.WriteLine("Ashes:");
        foreach (var el in ashes)
            Console.WriteLine(el.Volume);
        Console.WriteLine("\nLentil:");
        foreach (var el in lentil)
            Console.WriteLine(el.Weight);
    }
}