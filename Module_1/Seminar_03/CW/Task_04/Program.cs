using System;

namespace Task_04
{
    class Program
    {
        public static void F1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i*i + " ");
            }
        }
        
        public static void F2()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.Write(i*i + " ");
                i++;
            }
        }
        
        public static void F3()
        {
            int i = 1;
            do
            {
                Console.Write(i * i + " ");
                i++;
            } while (i <= 10);
        }
        
        static void Main(string[] args)
        {
            F1();
            Console.WriteLine();
            F2();
            Console.WriteLine();
            F3();
            Console.WriteLine();
        }
    }
}