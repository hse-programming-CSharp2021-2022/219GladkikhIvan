using System;
using PlaneObjects;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var arr = new Circle[rnd.Next(3, 10)];
            for (var i = 0; i < arr.Length; i++)
                arr[i] = new Circle(rnd.NextDouble() * 40 - 20,
                    rnd.NextDouble() * 40 - 20,
                    rnd.NextDouble() * 25 - 5);
            //Array.Sort(arr, (circle1, circle2)
            //    => circle1.Center.RVectorLength().CompareTo(circle2.Center.RVectorLength()));
            Array.Sort(arr);
            Array.ForEach(arr, x => Console.WriteLine(x));
        }
    }
}