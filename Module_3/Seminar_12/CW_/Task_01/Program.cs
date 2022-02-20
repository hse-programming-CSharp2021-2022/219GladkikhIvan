using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Task_01
{
    [Serializable]
    public class Student
    {
        public string Surname { get; set; }
        public uint Course { get; set; }

        public Student() { }

        public Student(string surname, uint course)
            => (Surname, Course) = (surname, course);


    }

    [Serializable]
    public class Group
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Group() { }

        public Group(string name, List<Student> students)
            => (Name, Students) = (name, students);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var student11 = new Student("Bob", 2);
            var student12 = new Student("John", 2);
            var students1 = new List<Student>();
            students1.Add(student11);
            students1.Add(student12);
            var group1 = new Group("ZXC1", students1);

            var student21 = new Student("Mari", 1);
            var student22 = new Student("Lua", 1);
            var students2 = new List<Student>();
            students2.Add(student21);
            students2.Add(student22);
            var group2 = new Group("QWE2", students2);

            var groups = new Group[] { group1, group2 };

            var binarySerializer = new BinaryFormatter();
            using (FileStream fs = new FileStream("1.txt", FileMode.OpenOrCreate))
            {
                binarySerializer.Serialize(fs, groups);
            }
            using (FileStream file = new FileStream("1.txt", FileMode.OpenOrCreate))
            {
                Group[] g = (Group[]) binarySerializer.Deserialize(file);
                foreach (var el in g)
                {
                    Console.WriteLine(el.Name);
                    Array.ForEach(el.Students.ToArray(), x =>
                    {
                        Console.WriteLine(x.Surname);
                        Console.WriteLine(x.Course);
                    });
                }
            }

            var xmlSerializer = new XmlSerializer(typeof(Group[]));
            using (FileStream fs = new FileStream("2.txt", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, groups);
            }
            using (FileStream file = new FileStream("2.txt", FileMode.OpenOrCreate))
            {
                Group[] g = (Group[]) xmlSerializer.Deserialize(file);
                foreach (var el in g)
                {
                    Console.WriteLine(el.Name);
                    Array.ForEach(el.Students.ToArray(), x => 
                    {
                        Console.WriteLine(x.Surname);
                        Console.WriteLine(x.Course);
                    });
                }
            }

            string json = JsonSerializer.Serialize<Group[]>(groups);
            Console.WriteLine(json);

            Group[] gr = (Group[]) JsonSerializer.Deserialize<Group[]>(json);
            foreach (var el in gr)
            {
                Console.WriteLine(el.Name);
                Array.ForEach(el.Students.ToArray(), x =>
                {
                    Console.WriteLine(x.Surname);
                    Console.WriteLine(x.Course);
                });
            }
        }
    }
}