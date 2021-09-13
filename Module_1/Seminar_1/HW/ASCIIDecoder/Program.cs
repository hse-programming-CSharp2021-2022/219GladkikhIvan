using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 32 до 127: ");
            string input = Console.ReadLine();
            int code = int.Parse(input);
            Console.WriteLine("Символ, соответсвующий этому номеру: " + (char) code);
            Console.ReadLine();
        }
    }
}