using System;

namespace Task02_Reflection_Methods
{
    public abstract class Student
    {
        public string Name { get; set; }

        protected Student(string name)
        {
            Name = name;
        }

    }
}