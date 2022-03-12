using System;
using System.Runtime.Serialization;

namespace Task_01
{
    [Serializable]
    [DataContract]
    public class Professor : Human
    {
        public Professor() { }
        public Professor(string name) : base(name) { }
        
        public override string ToString()
            => $"Professor | Name : {Name}";
    }
}