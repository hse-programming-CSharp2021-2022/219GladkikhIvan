using System;

// Задача 2.
namespace Task_01
{
    class Program
    {
        public static void Print(char[] mas)
        {
            foreach (char a in mas)
                Console.Write(a + " ");
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            char[] mas = new char[k];
            Random rnd = new Random();
            for (int i = 0; i < k; i++)
                mas[i] = (char) rnd.Next('A', 'Z' + 1);
            Print(mas);
            char[] masCopy = new char[k];
            Array.Copy(mas, masCopy, k);
            Array.Sort(masCopy);
            Array.Reverse(masCopy);
            Print(masCopy);
        }
    }
}