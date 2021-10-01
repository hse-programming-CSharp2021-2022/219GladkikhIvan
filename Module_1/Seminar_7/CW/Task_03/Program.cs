using System;

// a^a == 0
namespace Task_03
{
    class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }
        
        static Random s_rnd = new Random();
        
        public static void Init(int[] m)
        {
            int[] num = new int[100];
            for (int i = 0; i <= 99; i++)
                num[i] = i + 1;
            Array.Sort(num, Shuffler);
            num[99] = num[98];
            Swap(ref num[99], ref num[s_rnd.Next(0, 98)]);
        }

        public static int Shuffler(int a, int b)
        {
            return s_rnd.Next(-1, 2);
        }
        
        static void Main(string[] args)
        {
                
        }
    }
}