using System;
using System.Collections.Generic;
using System.Linq;

namespace XmlFun
{
    static class Program
    {
        private static void Main()
        {
            const string pathToFile = @"../../../person.xml";

            // Пример объекта, который нужно сериализовать
            var student = new Student
            {
                Name = "Adam",
                Age = 18,
                Grades = new Dictionary<string, double>
                {
                    ["Algebra"] = 3.49,
                    ["Programming"] = 9.5,
                }
            };

            StudentSerializer.SerializeXml(pathToFile, student);

            var studentDeserialized = StudentSerializer.DeserializeXml(pathToFile);

            // Проверка, что десериализация прошла успешно
            PrintStudentInfo(studentDeserialized);
        }

        private static void PrintStudentInfo(Student student)
        {
            var info = $"Name: {student.Name}, Age: {student.Age}"
                       + Environment.NewLine
                       + "Grades:"
                       + Environment.NewLine + "-> "
                       + string.Join($"{Environment.NewLine}-> ", student.Grades.Select(kv => $"{kv.Key}: {kv.Value}"));

            Console.WriteLine(info);
        }
    }
}