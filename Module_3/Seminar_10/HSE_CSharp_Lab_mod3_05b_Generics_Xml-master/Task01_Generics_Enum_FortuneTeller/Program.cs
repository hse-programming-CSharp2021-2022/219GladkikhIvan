using System;

namespace Task01_Generics_Enum_FortuneTeller
{
    class Program
    {
        // TODO: define some enum 

        private static T GetAnswer<T>(T answers) where T : Enum
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            string question = "Type your question here...";
            Console.WriteLine(question);
            // Console.WriteLine(GetAnswer(...));
        }
    }
}
