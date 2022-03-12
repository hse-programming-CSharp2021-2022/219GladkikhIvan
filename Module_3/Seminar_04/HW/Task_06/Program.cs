using System;

namespace Task_06
{
    public class RingIsFoundEventArgs : EventArgs
    {
        public RingIsFoundEventArgs(string s)
            => Message = s;
        public string Message { get; }
    }
    
    
    abstract class Person
    {
        public string Name { get; }

        public Person(string name)
            => Name = name;

        public abstract void RingIsFountEventHandler(object sender, RingIsFoundEventArgs e);
    }

    class Wizard
    {
        public string Name { get; }

        public Wizard(string name)
            => Name = name;

        public delegate void RingIsFoundEventHandler(object sender,
            RingIsFoundEventArgs s);

        public event RingIsFoundEventHandler RaiseRingIsFoundEvent;

        public void SomeThisIsChangedInTheAir()
        {
            Console.WriteLine($"{Name} >> Кольцо найдено у старого Бильбо! Призываю вас в Ривендейл!");
            RaiseRingIsFoundEvent(this, new RingIsFoundEventArgs("Ривендейл"));
        }
    }

    class Hobbit : Person
    {
        public Hobbit(string name) : base(name) { }

        public override void RingIsFountEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Покидаю Шир! Иду в " + e.Message);
        }
    }

    class Human : Person
    {
        public Human(string name) : base(name) { }
        
        public override void RingIsFountEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Волшебник {((Wizard)sender).Name} позвал. Моя цель {e.Message}");
        }
    }

    class Elf : Person
    {
        public Elf(string name) : base(name) { }
        
        public override void RingIsFountEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Звёзды светят не так ярко как обычно. Цветы увядают. Листья предсказывают идти в " + e.Message);
        }
    }

    class Dwarf : Person
    {
        public Dwarf(string name) : base(name) { }
        
        public override void RingIsFountEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Точим топоры, собираем припасы! Выдвигаемся в " + e.Message);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var wizard = new Wizard("Гендальф");
            var people = new Person[]
            {
                new Hobbit("Фродо"),
                new Hobbit("Сэм"),
                new Hobbit("Пипин"),
                new Hobbit("Мэрри"),
                new Human("Бромир"),
                new Human("Арагорн"),
                new Dwarf("Гимли"),
                new Elf("Леголас")
            };
            foreach (var person in people)
                wizard.RaiseRingIsFoundEvent += person.RingIsFountEventHandler;
            wizard.SomeThisIsChangedInTheAir();
        }
    }
}