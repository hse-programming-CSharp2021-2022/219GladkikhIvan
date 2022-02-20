using System;
using System.Collections.Generic;

namespace Task02_Reflection_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Console.WriteLine("Введите число студентов: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                students.Add(ParseStudent(input));
            }
            Count(students);
            Study(students);
            Console.WriteLine("К сожалению, студенты закончились");
        }

        public static Student ParseStudent(string input)
        {
            throw new NotImplementedException();
        }

        private static void Study(List<Student> students)
        {
            throw new NotImplementedException();
        }

        static public void Count(List<Student> students)
        {
            int countCS = 0;
            int countEconom = 0;

            throw new NotImplementedException();

            Console.WriteLine($"Количество студентов ФКН - {countCS}");
            Console.WriteLine($"Количество студентов экономистов - {countEconom}");
        }

    }
}

