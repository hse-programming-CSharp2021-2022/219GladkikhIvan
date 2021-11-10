using System;

namespace Task_01
{
    abstract class Animal
    {
        protected string Name { get; }
        protected uint Age { get; }

        public abstract string AnimalSound();
        public abstract string AnimalInfo();

        public Animal(string name, uint age)
            => (Name, Age) = (name, age);
    }

    class Dog : Animal
    {
        private string Breed { get; }
        private bool IsTrained { get; }
            
        public override string AnimalSound() => "Woof!";

        public override string AnimalInfo()
            => $"Dog: name = {Name}, breed = {Breed}, age = {Age}, isTrained = {IsTrained}.";

        public Dog(string name, string breed, uint age, bool isTrained) : base(name, age)
            => (Breed, IsTrained) = (breed, isTrained);
    }

    class Cow : Animal
    {
        private uint MilkPerDay { get; }
        public override string AnimalSound() => "Moo!";
        public override string AnimalInfo()
            => $"Cow: name = {Name}, age = {Age}, milkPerDay = {MilkPerDay}.";

        public Cow(string name, uint age, uint milk) : base(name, age)
            => MilkPerDay = milk;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Archie", "Dachshund", 3, true);
            var cow = new Cow("Linda", 2, 4);
            
            Console.WriteLine(dog.AnimalSound());
            Console.WriteLine(cow.AnimalSound());
            
            Console.WriteLine(dog.AnimalInfo());
            Console.WriteLine(cow.AnimalInfo());
        }
    }
}