using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task_02
{
    public class Human
    {
        public string Name { get; set; }
        
        public Human() { }

        public Human(string name)
            => Name = name;
    }

    public class Professor : Human
    {
        public Professor() : base() { }
        public Professor(string name) : base(name) { }
    }

    public class Department
    {
        public List<Human> staff { get; set; }
        
        public Department() { }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}