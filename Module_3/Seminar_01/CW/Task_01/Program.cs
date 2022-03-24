using System;

class Program
{
    public delegate bool Comp(int x, int y);

    public static void BubbleSort(int[] a, Comp c)
    {
        for (var i = 0; i < a.Length - 1; i++)
        for (var j = i + 1; j < a.Length; j++) 
            if (c(a[i], a[j]))
            { 
                (a[i], a[j]) = (a[j], a[i]);
            }
    }
    
    static void Main(string[] args)
    {
        int[] a = { 3, 7, 10, -2, 14, -4, 8 };
        
        BubbleSort(a, (x, y) => (x > y));
        Array.ForEach(a, el => Console.Write(el + " "));
        Console.WriteLine();
        
        BubbleSort(a, (x, y) => (x < y));
        Array.ForEach(a, el => Console.Write(el + " "));
        Console.WriteLine();
        
        BubbleSort(a, (x, y) => (x % 2 == 1) & (y % 2 == 0));
        Array.ForEach(a, el => Console.Write(el + " "));
        Console.WriteLine();
    }
}