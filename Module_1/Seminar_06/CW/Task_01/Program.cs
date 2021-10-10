using System;

namespace Task_01
{
    class Program
    {
        public static bool Check(uint x)
        {
            bool flag;
            do
            {
                flag = x % 10 <= x / 10 % 10;
                x /= 10;
            } while (flag && (x > 9));

            return flag;
        }

        public static uint Length(uint x)
        {
            uint count = 0;
            while (x > 0)
            {
                count++;
                x /= 10;
            }

            return count;
        }
        
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            uint number = uint.Parse(input);
            uint len = Length(number);
            uint a, b, d;
            while (!Check(number))
            {
                for (int i = 0; i < len - 1; i++)
                {
                    a = (uint) (number / Math.Pow(10, i) % 10);
                    b = (uint) (number / Math.Pow(10, i+1) % 10);
                    if (a > b)
                    {
                        d = a - b;
                        number = (uint) (number - d * Math.Pow(10, i) + d*Math.Pow(10, i+1));
                    }
                }
            }
            Console.WriteLine(number);
        }
    }
}