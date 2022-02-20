using System;
using System.IO;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("1.txt", FileMode.OpenOrCreate))
            {
                long len = fs.Length;
                if (len <= 3)
                {
                    byte[] toWrite = {((byte) ((byte) 'A' + len))};
                    fs.Position = len;
                    fs.Write(toWrite);
                }

                int next = 0;
                while (next != -1)
                {
                    next = fs.ReadByte();
                    byte[] read = {(byte) next};
                    if (next != -1)
                        Console.Write(System.Text.Encoding.Default.GetString(read) + " ");
                }
            }
        }
    }
}