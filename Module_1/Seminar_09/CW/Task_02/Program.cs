using System;
using System.Text;

namespace Task_02
{
    class Program
    {
        static string GetAbbreviation(string s)
        {
            var vowels = "EYUIOAЁУЕЫАОЭЯИЮ";
            var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var abr = new StringBuilder("");
            for (var j = 0; j < words.Length; j++)
            {
                var i = 0;
                do
                {
                    abr.Append(i == 0 ? words[j].ToUpper()[i] : words[j][i]);
                    i++;
                } while (!vowels.Contains(words[j].ToUpper()[i - 1]));
            }

            return abr.ToString();
        }
        
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var phrases = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (var el in phrases)
                Console.WriteLine(GetAbbreviation(el));
        }
    }
}