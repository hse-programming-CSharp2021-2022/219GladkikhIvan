using System;

namespace Task_01
{
    class Program
    {
        static string DigitToString(char digit)
        {
            string[] digitString = {"ноль", "один", "два", "три", "четыре", "пять",
                "шесть", "семь", "восемь", "девять" };
            return digitString[digit - '0'];
        }
        
        static void Main(string[] args)
        {
            int n, 
                // Процент букв в массиве.
                per;

            do
            {
                Console.Write("Введите размер массива: ");
            } while (!int.TryParse(Console.ReadLine(), out n) && n > 1);
            
            do
            {
                Console.Write("Введите процент букв: ");
            } while (!int.TryParse(Console.ReadLine(), out per) && per >= 0);
            
            var m = new string[n];

            int nLetterAmount = n * per / 100;

            Random rnd = new Random();
            
            for (var i = 0; i < nLetterAmount; i++)
            {
                m[i] = ((char) rnd.Next('a', 'z' + 1)).ToString();
            }
            
            for (var i = nLetterAmount; i < n; i++)
            {
                m[i] = DigitToString((char) rnd.Next('0', '9' + 1));
            }
            
            Array.ForEach(m, x => Console.Write(x + " "));
            
        }
    }
}