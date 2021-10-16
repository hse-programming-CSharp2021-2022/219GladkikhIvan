// Задания 1-3.
using System;
using System.Text;

namespace Task_04
{
    class Program
    {
        // Задание 1.
        static StringBuilder Normalize(string input)
        {
            var s = new StringBuilder();
            for (var i = 0; i < input.Length - 1; i++)
                if (!(input[i] == ' ' && input[i + 1] == ' '))
                    s.Append(input[i]);
            return s;
        }

        // Задание 2.
        static int LongerThan4(string input)
        {
            int i = 0, k, countOfWords = 0;
            while (i < input.Length)
            {
                // Проходим пробелы.
                while (i < input.Length && input[i] == ' ')
                    i++;
                
                // Обнуляем счётчик.
                k = 0;
                
                // Начинается слово, считаем кол-во букв.
                while (i < input.Length && input[i] != ' ' && k <= 4)
                {
                    i++;
                    k++;
                }
                
                // Проверяем слово.
                if (k > 4)
                    countOfWords++;
            }

            return countOfWords;
        }

        // Задание 3.
        static int StartsWithVowel(string input)
        {
            int i = 0, countOfWords = 0;
            var vowels = "ЁУЕЫАОЭЯИЮ";
            while (i < input.Length)
            {
                // Проходим пробелы.
                while (i < input.Length && input[i] == ' ')
                    i++;
                
                // Проверяем начало слова.
                if (vowels.Contains(input.ToUpper()[i]))
                    countOfWords++;
                
                // Начинается слово, считаем кол-во букв.
                while (i < input.Length && input[i] != ' ')
                    i++;
            }

            return countOfWords;    
        }
        
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine(Normalize(input));
            Console.WriteLine(LongerThan4(input));
            Console.WriteLine(StartsWithVowel(input));
        }
    }
}