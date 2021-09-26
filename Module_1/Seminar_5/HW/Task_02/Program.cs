using System;

namespace Task_02
{
    class Program
    {
        public static bool Cycle(ref char ch)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            if (letters.Contains(ch))
            {
                ch = letters[(letters.IndexOf(ch) + 4) % 26];
                return true;
            }
            else
                return false;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите символ латинского алфавита: ");
            string input = Console.ReadLine();
            if (char.TryParse(input, out char ch) && Cycle(ref ch))
            {
                Console.WriteLine("Символ после цикличного сдвига на 4 позиции: {0}", ch);
            }
            else
                Console.WriteLine("Ошибка ввода!");
        }
    }
}