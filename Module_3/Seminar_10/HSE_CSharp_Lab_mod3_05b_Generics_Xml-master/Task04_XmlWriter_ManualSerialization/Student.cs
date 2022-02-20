using System.Collections.Generic;

namespace XmlFun
{
    public class Student
    {
        public string Name { get; init; }

        public int Age { get; init; }

        public IDictionary<string, double> Grades { get; init; }
    }
}