using System;

namespace Task_05
{
    class ConsolePlate
    {
        private char _plateChar;
        public char PlateChar
        {
            get => _plateChar;
            set => _plateChar = value is >= 'A' and <= 'Z' ? value : 'A'; 
        }
        public ConsoleColor PlateColor { get; }
        public ConsoleColor BackgroundColor { get; }

        public ConsolePlate() { }

        public ConsolePlate(char ch, ConsoleColor foreground, ConsoleColor background)
        {
            if (background != foreground)
                (PlateChar, PlateColor, BackgroundColor) = (ch, foreground, background);
        }
    }
    
    class Program   
    {
        static void Main(string[] args)
        {
            var x = new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red);
            var o = new ConsolePlate('O', ConsoleColor.Red, ConsoleColor.White);
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++, Console.WriteLine())
            for (var j = 0; j < n; j++, Console.ResetColor())
            {
                var plate = (i + j) % 2 == 0 ? x : o;
                Console.ForegroundColor = plate.PlateColor;
                Console.BackgroundColor = plate.BackgroundColor;
                Console.Write(plate.PlateChar);
            }
        }
    }
}