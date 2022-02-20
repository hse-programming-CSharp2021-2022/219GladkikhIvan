using System;
using System.IO;
using System.Text;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "1.txt";
            MakeFile(path);
            Print(path);
        }

        private static void MakeFile(string path)
        {
            var rnd = new Random();
            using (BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.Create)))
            {
                for (var i = 0; i < 10; i++)
                    bw.Write(rnd.Next(1, 101));
            }
        }

        private static void Print(string path)
        {
            using (BinaryReader bw = new BinaryReader(new FileStream(path, FileMode.Open)))
            {
                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine(bw.ReadInt32());
                }
            } 
            Console.WriteLine("***");
        }
    }
}