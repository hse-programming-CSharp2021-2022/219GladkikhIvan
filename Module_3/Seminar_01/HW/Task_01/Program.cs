using System;

namespace Task_01
{
    public delegate int Cast(double x);
    
    class Program
    {
        static void Main(string[] args)
        {
            testValues = new double[3];
            var rnd = new Random();
            for (var i = 0; i < testValues.Length; i++)
                testValues[i] = rnd.NextDouble() * 100 + 1;
            
            Cast round = delegate(double x)
            {
                var y = (int) Math.Floor(x);
                return (y % 2 == 0 ? y : y + 1);
            };
            Cast rate = delegate(double x) { return (int) Math.Floor(Math.Log10(x)) + 1; };
            Test(round, "round");
            Test(rate, "rate");

            var multicast = round + rate;
            Test(multicast, "multicast");
            
            round = (double x) =>
            {
                var y = (int) Math.Floor(x);
                return (y % 2 == 0 ? y : y + 1);
            };
            rate = (double x) => (int) Math.Floor(Math.Log10(x)) + 1; 
            TestInvoke(round, "round");
            TestInvoke(rate, "rate");
            
            multicast -= x => (int) Math.Floor(Math.Log10(x)) + 1; 
            Test(multicast, "multicast");

            multicast = Round;
            multicast += Rate;
            Test(multicast, "multicast");

            multicast -= Rate;
            Test(multicast, "multicast");
        }
        
        static double[] testValues;

        public static void Test(Cast c, string name)
        {
            Console.WriteLine($"Testing delegate \"{name}\":");
            foreach (var value in testValues)
            {
                Console.WriteLine($"Value: {value}; Result: {c(value)}.");
            }
            Console.WriteLine("\n* * * * * * * * * *\n");
        }
        
        public static void TestInvoke(Cast c, string name)
        {
            Console.WriteLine($"Testing delegate \"{name}\":");
            foreach (var value in testValues)
            {
                Console.WriteLine($"Value: {value}; Result: {c?.Invoke(value)}.");
            }
            Console.WriteLine("\n* * * * * * * * * *\n");
        }

        public static int Round(double x)
        {
            var y = (int) Math.Floor(x);
            return (y % 2 == 0 ? y : y + 1);
        }
        
        public static int Rate(double x)
            => (int) Math.Floor(Math.Log10(x)) + 1; 
    }
}