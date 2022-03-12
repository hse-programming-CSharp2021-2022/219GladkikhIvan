using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Task_01
{
    [Serializable]
    [DataContract]
    public class Department
    {
        public string Name { get; set; }
        public List<Human> Staff { get; set; }

        public Department() { }
        public Department(string name, params Human[] staff)
            => (Name, Staff) = (name, new List<Human>(staff));

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"\nDepartment | Name : {Name} | Staff :\n");
            for (var i = 0; i < Staff.Count; i++)
                sb.Append($"{i + 1}. {Staff[i]}\n");
            return sb.ToString();
        }
    }
}