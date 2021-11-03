using System;

namespace Theory_01
{
    class ArithmeticProgression
    {
        public static int count = 0;
        public static int count2;

        static ArithmeticProgression() => Console.WriteLine("Static counstruct");

        public int A0 { get; private set; }
        public int D { get; private set; }

        public ArithmeticProgression(int a0, int d)
        {
            (A0, D) = (a0, d);
            count++;
        }
        public ArithmeticProgression() : this(0, 0) { }

        public int this[int index] => A0 + D * index;

        ~ArithmeticProgression()
        {
            Console.WriteLine("Destroy object");            
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var prog = new ArithmeticProgression(2, 10);
            Console.WriteLine(prog[3]);
            Console.WriteLine(prog[5]);
            var prog1 = new ArithmeticProgression();
            var prog2 = new ArithmeticProgression();
            var prog3 = new ArithmeticProgression();
            var prog4 = new ArithmeticProgression();
            Console.WriteLine(ArithmeticProgression.count);
        }
    }
}