using System;
using System.IO;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var fs = new FileStream(@"..\..\..\..\Numbers.bin", FileMode.OpenOrCreate);
            using (var bw = new BinaryWriter(fs))
            {
                for (var i = 0; i < 10; i++)
                    bw.Write(rnd.Next(1, 101));
            }
        }
    }
}