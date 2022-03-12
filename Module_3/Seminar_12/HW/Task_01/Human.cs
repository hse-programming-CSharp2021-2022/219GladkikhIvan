using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Task_01
{
    [Serializable]
    [DataContract]
    public class Human
    {
        public string Name { get; set; }

        public Human() { }
        public Human(string name)
            => Name = name;

        public override string ToString()
            => $"Human | Name : {Name}";
    }
}