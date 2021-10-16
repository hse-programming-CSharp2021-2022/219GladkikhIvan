using System;
using System.Text;
using Microsoft.VisualBasic;

namespace Task_03
{
    class Program
    {
        static int GetHexNumber(char hex) => "0123456789ABCDEF".IndexOf(hex);
        
        static long HexToDec(string hex)
        {
            var x = 0L;
            var systemBase = 1;
            for (var i = hex.Length - 1; i >= 0; i--, systemBase *= 16)
                x += GetHexNumber(hex[i]) * systemBase;
            return x;
        }

        static string DecToBin(long x)
        {
            var bin = new StringBuilder("");
            while (x > 0)
            {
                bin.Insert(0, x % 2);
                x /= 2;
            }

            return bin.ToString();
        }

        static string HexToBin(string hex) => DecToBin(HexToDec(hex));
        
        static void Main(string[] args)
        {
            Console.WriteLine(HexToBin("1FA"));
        }
    }
}