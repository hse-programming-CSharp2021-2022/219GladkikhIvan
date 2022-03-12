using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using System.Text.Json;

namespace Task_01
{
    class Program
    {
        private static Random rnd = new Random();
        
        static void Main(string[] args)
        {
            var arr = new University[rnd.Next(2, 4)];
            for (var i = 0; i < arr.Length; i++)
                arr[i] = GenerateUniversity();
            Array.ForEach(arr, Console.WriteLine);

            // Binary
            Console.WriteLine("Implementing binary serialization.");
            var bf = new BinaryFormatter();
            using (var fs = new FileStream("universities.bin", FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(fs, arr);
            }
            Console.WriteLine("Deserialization result:\n");
            using (var fs = new FileStream("universities.bin", FileMode.Open, FileAccess.Read))
            {
               var result = (University[]) bf.Deserialize(fs);
            }
            Array.ForEach(arr, Console.WriteLine);
            
            // XML
            Console.WriteLine("Implementing XML serialization.");
            var xml = new XmlSerializer(typeof(University[]));
            using (var fs = new FileStream("universities.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, arr);
            }
            Console.WriteLine("Deserialization result:\n");
            using (var fs = new FileStream("universities.xml", FileMode.Open, FileAccess.Read))
            {
                var result = (University[]) xml.Deserialize(fs);
            }
            Array.ForEach(arr, Console.WriteLine);
            
            // Json
            var info = JsonSerializer.Serialize(arr);
            Console.WriteLine("Implementing Json serialization.\n");
            Console.WriteLine($"Serialization result:\n{info}\n");
            Console.WriteLine("Deserialization result:\n");
            var jsonResult = (University[]) JsonSerializer.Deserialize(info, typeof(University[]));
            Array.ForEach(arr, Console.WriteLine);
        }

        private static string GenerateString()
        {
            var sb = new StringBuilder();
            sb.Append((char) rnd.Next('A', 'Z' + 1));
            var n = rnd.Next(0, 7);
            for (var i = 0; i < n; i++)
                sb.Append((char) rnd.Next('a', 'z' + 1));
            return sb.ToString();
        }

        private static Human GenerateHuman()
        {
            return rnd.Next(0, 2) == 0 ? 
                new Professor(GenerateString()) : 
                new Human(GenerateString());
        }

        private static Department GenerateDepartment()
        {
            var arr = new Human[rnd.Next(2, 4)];
            for (var i = 0; i < arr.Length; i++)
                arr[i] = GenerateHuman();
            return new Department(GenerateString(), arr);
        }

        private static University GenerateUniversity()
        {
            var arr = new Department[rnd.Next(2, 4)];
            for (var i = 0; i < arr.Length; i++)
                arr[i] = GenerateDepartment();
            return new University(GenerateString(), new List<Department>(arr));
        }
    }
}