using System;
using System.Text.RegularExpressions;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "Бык тупогуб, тупогубенький бычок, у бычка  губа бела. ";
            Console.WriteLine(s);

            var regex = new Regex(@"туп\w*");
            var matches = regex.Matches(s);
            foreach (Match i in matches)
                Console.WriteLine(i.Value);

            s = regex.Replace(s, "1111");
            Console.WriteLine(s);
            
            var s2 = "111-111-1111";
            var regex2 = new Regex(@"\d{3}-[0-9]{3}-\d{4}");
            Console.WriteLine(regex2.Match(s2));
            Console.WriteLine(regex2.IsMatch(s2));
        }
    }
}