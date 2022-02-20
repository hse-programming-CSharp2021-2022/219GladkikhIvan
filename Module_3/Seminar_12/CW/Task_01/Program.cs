using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Task_01
{
    class Student
    {
        public string Surname { get; }
        public uint Course { get; }
        
        public Student() { }

        public Student(string surname, uint course)
            => (Surname, Course) = (surname, course);
    }

    class Group
    {
        public string Name { get; }
        public List<Student> Students { get; }
        
        public Group() { }

        public Group(string name, List<Student> students)
            => (Name, Students) = (name, students);
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}