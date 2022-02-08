using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_02
{
    interface IJump
    {
        public string Jump();
    }

    interface IRun
    {
        public string Run();
    }

    class Animal : IComparable<Animal>
    {
        public int Age { get; }

        public int CompareTo(Animal obj)
            => this.Age.CompareTo(obj.Age);

        public Animal(int age)
            => Age = age;
        
        public override string ToString()
            => $"Animal. Age: {Age}.";
    }

    class Cockroach : Animal, IRun
    {
        public int Speed { get; }

        public Cockroach(int age, int speed) : base(age)
            => Speed = speed;

        public string Run()
            => $"Таракан бегает со скоростью {Speed} м/с.";

        public override string ToString()
            => $"Cockroach. Age: {Age}, Speed: {Speed}.";
    }

    class Kangaroo : Animal, IJump
    {
        public int Distance { get; }

        public Kangaroo(int age, int dist) : base(age)
            => Distance = dist;

        public string Jump()
            => $"Кенгуру прыгает на {Distance} м.";
        
        public override string ToString()
            => $"Kangaroo. Age: {Age}, Distance: {Distance}.";
    }

    class Cheetah : Animal, IRun, IJump
    {
        public int Speed { get; } 
        public int Distance { get; }
        
        public string Jump()
            => $"Гепард прыгает на {Distance} м.";
        public string Run()
            => $"Гепард бегает со скоростью {Speed} м/с.";

        public Cheetah(int age, int speed, int dist) : base(age)
            => (Speed, Distance) = (speed, dist);
        
        public override string ToString()
            => $"Cheetah. Age: {Age}, Speed: {Speed}, Distance: {Distance}.";
    }

    class CockroachComparer : IComparer<Cockroach>
    {
        public int Compare(Cockroach a, Cockroach b)
            => a.Speed.CompareTo(b.Speed);
    }

    class KangarooComparer : IComparer<Kangaroo>
    {
        public int Compare(Kangaroo a, Kangaroo b)
            => a.Distance.CompareTo(b.Distance);     
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            var m = new Animal[9];

            for (var i = 0; i < 3; i++)
                m[i] = new Cockroach(r.Next(), r.Next());
            for (var i = 3; i < 6; i++)
                m[i] = new Kangaroo(r.Next(), r.Next());
            for (var i = 6; i < 9; i++)
                m[i] = new Cheetah(r.Next(), r.Next(), r.Next());
            
            Array.ForEach(m, Console.WriteLine);
            Console.WriteLine("***");
            
            var run = m.OfType<IRun>().ToArray();
            Array.ForEach(run, Console.WriteLine);
            Console.WriteLine("***");
            
            var jump = m.OfType<IJump>().ToArray();
            Array.ForEach(jump, Console.WriteLine);
            Console.WriteLine("***");
            
            Array.Sort(m);
            Array.ForEach(m, Console.WriteLine);
            Console.WriteLine("***");
            
            var cockroaches = m.OfType<Cockroach>().ToArray();
            Array.Sort(cockroaches, CockroachComparer);
            Array.ForEach(cockroaches, Console.WriteLine);
            Console.WriteLine("***");
            
            
        }
    }
}