using System;
using System.IO;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[10];
            do
            {
                var fs = new FileStream(@"..\..\..\..\Numbers.bin", FileMode.Open, FileAccess.Read);
                using (var br = new BinaryReader(fs))
                {
                    for (var i = 0; i < 10; i++)
                    {
                        arr[i] = br.ReadInt32();
                    }
                }

                Array.ForEach(arr, Console.WriteLine);
                Console.WriteLine("\n* * * * *\n");

                int x;
                bool f;
                do
                {
                    f = int.TryParse(Console.ReadLine(), out x) && x is >= 1 and <= 100;
                } while (!f);

                Console.WriteLine("\n* * * * *\n");
                arr[FindNearest(arr, x)] = x;
                fs = new FileStream(@"..\..\..\..\Numbers.bin", FileMode.OpenOrCreate, FileAccess.Write);
                using (var bw = new BinaryWriter(fs))
                {
                    for (var i = 0; i < 10; i++)
                        bw.Write(arr[i]);
                }

                Array.ForEach(arr, Console.WriteLine);
                Console.WriteLine("\n* * * * *\n");
                Console.WriteLine("Для выхода нажмите ESC, для продолжения - любую другую клавишу.");
                Console.WriteLine("\n* * * * *\n");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        private static int FindNearest(int[] arr, int x)
        {
            var minDiff = 101;
            var minNo = -1;

            for (var i = 0; i < 10; i++)
            {
                var diff = Math.Abs(x - arr[i]);
                if (diff >= minDiff) continue;
                minNo = i;
                minDiff = diff;
            }

            return minNo;
        }
    }
}