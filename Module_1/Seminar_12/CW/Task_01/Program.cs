using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"abc", "fdg", "Adfgdg", "fdgdfg", "fsdfsdf", "GSfdsfsdf", "aFgdjkfg", "Afdsfk"};
            var str = new List<string>();

            foreach (var el in names)
                if (el.ToUpper().StartsWith('A'))
                    str.Add(el);
            foreach (var i in str)
                Console.Write(i + " ");
            Console.WriteLine();

            var str2 = (from s in names
                where s.ToUpper().StartsWith("A")
                //orderby s descending 
                select s).ToArray();
            foreach (var i in str2)
                Console.Write(i + " ");
            Console.WriteLine();

            names[0] = "edwdf";
            names[2] = "AAAedwdf";
            foreach (var i in str2)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}