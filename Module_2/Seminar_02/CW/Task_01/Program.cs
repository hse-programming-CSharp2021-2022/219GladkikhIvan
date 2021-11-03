// Комплексные числа.
using System;

namespace Task_01
{
    class MyComplex    
    {
        private double re, im;

        public double Re
        {
            get => re;
            set => re = value;
        }
        public double Im
        {
            get => im;
            set => im = value;
        }
        
        public MyComplex(double xre = 0, double xim = 0) => (re, im) = (xre, xim);
        
        public static MyComplex operator ++(MyComplex mc) => new (mc.re + 1, mc.im + 1);
        public static MyComplex operator --(MyComplex mc) => new (mc.re - 1, mc.im - 1);
        
        public double Mod() => Math.Abs(re*re+im*im);

        public static bool operator true(MyComplex f) => f.Mod() > 1.0;
        public static bool operator false(MyComplex f)  => f.Mod() <= 1.0;

        public static MyComplex operator +(MyComplex a, MyComplex b) => new (a.re + b.re, a.im + b.im);
        public static MyComplex operator -(MyComplex a, MyComplex b) => new (a.re - b.re, a.im - b.im);
        
        public static MyComplex operator *(MyComplex a, MyComplex b) 
            => new (a.re * b.re - a.im * b.im, a.im * b.re + a.re * b.im);

        public static MyComplex operator /(MyComplex a, MyComplex b)
        {
            double newRe = (a.re * b.re + a.im * b.im) / b.Mod();
            double newIm = (a.im * b.re - a.re * b.im) / b.Mod();
            return new (newRe, newIm);
        }

        public override string ToString()
            => $"{re} + {im} * i";
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = new MyComplex(1, 2); 
            var num2 = new MyComplex(3, 4);
            
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
        }
    }
}