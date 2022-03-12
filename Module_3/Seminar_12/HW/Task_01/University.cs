using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Task_01
{
    [Serializable]
    [XmlInclude(typeof(Department)), XmlInclude(typeof(Professor)), XmlInclude(typeof(Human)), XmlType]
    [DataContract, KnownType(typeof(Department)), KnownType(typeof(Professor)), KnownType(typeof(Human))]
    public class University
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }

        public University() { }
        public University(string name, List<Department> departments)
            => (Name, Departments) = (name, departments);
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"University | Name : {Name} | Departments :\n");
            foreach (var d in Departments)
                sb.Append(d);
            sb.Append("\n- - - - - - - - - -\n");
            return sb.ToString();
        }
    }
}