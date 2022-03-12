using System;

namespace Task_01
{
    public struct Person : IComparable
    {
        public string Name { get; }
        public string LastName { get; }
        public int Age { get; }

        public Person(string name, string lastName, int age)
        {
            if (age < 0)
                throw new ArgumentOutOfRangeException();
            (Name, LastName, Age) = (name, lastName, age);
        }

        public int CompareTo(object obj)
            => Age.CompareTo(((Person) obj).Age);

        public override string ToString()
            => $"Name : {Name} | Last name : {LastName} | Age : {Age}";
    }
}