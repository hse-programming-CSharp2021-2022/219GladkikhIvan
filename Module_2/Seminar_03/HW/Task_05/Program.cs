using System;
using System.Text;

namespace Task_05
{
    class VideoFile
    {
        public string Name { get; }
        public int Duration { get; }
        public int Quality { get; }

        public VideoFile(string name, int duration, int quality)
            => (Name, Duration, Quality) = (name, duration, quality);

        public int Size => Duration * Quality;

        public override string ToString()
            => $"Record \"{Name}\": duration = {Duration}, quality = {Quality}, size = {Size}";

        public static string GenerateName()
        {
            var rnd = new Random();
            var s = new StringBuilder("");
            var len = rnd.Next(2, 10);
            for (var i = 0; i < len; i++)
                s.Append((char) rnd.Next('A', 'Z' + 1));
            return s.ToString();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var file = new VideoFile("Sample", rnd.Next(60, 361), rnd.Next(100, 1001));
            var n = rnd.Next(5, 16);
            var m = new VideoFile[n];
            Console.WriteLine(file);
            for (var i = 0; i < n; i++)
            {
                m[i] = new VideoFile(VideoFile.GenerateName(), rnd.Next(60, 361), rnd.Next(100, 1001));
                if (m[i].Size > file.Size)
                    Console.WriteLine(m[i]);
            }
        }
    }
}