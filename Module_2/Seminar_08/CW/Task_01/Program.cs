using System;
using System.Collections.Generic;
using System.Text;

abstract class Person
{
    public static Random rnd = new Random();
    public string Name { get; }
    public string Pocket { get; protected set; }

    public abstract void Receive(string present);

    public Person(string name) => Name = name;

    public override string ToString()
        => $"Name = {Name}, Pocket = {Pocket}";
}

class SnowMaiden : Person
{
    public SnowMaiden(string name) : base(name) { }

    public override void Receive(string present)
    {
        if (Pocket.Equals(string.Empty))
            Pocket = present;
        else
            throw new ArgumentException(">1 gift");
    }

    private string CreateString()
    {
        var n = rnd.Next(4, 11);
        var str = new StringBuilder(n);
        for (var i = 0; i < n; i++)
            str.Append((char) rnd.Next('a', 'z' + 1));
        return str.ToString();
    }
    public string[] CreatePresents(int amount)
    {
        var gifts = new string[amount];
        for (var i = 0; i < amount; i++)
            gifts[i] = CreateString();
        return gifts;
    }
}

class Santa : Person
{
    private List<string> sack;

    public void Request(SnowMaiden snowMaiden, int amount)
    {
        sack.AddRange(snowMaiden.CreatePresents(amount));
    }

    public Santa(string name) : base(name)
    {
        sack = new List<string>();
    }
    
    public override void Receive(string present)
    {
        if (Pocket.Equals(string.Empty))
            Pocket = present;
        else
            throw new ArgumentException(">1 gift");
    }

    public void Give(Person person)
    {
        var n = rnd.Next(0, sack.Count);
        if (sack.Count > 0)
        {
            person.Receive(sack[n]);
            sack.RemoveAt(n);
        }
        else
            throw new IndexOutOfRangeException();
    }
}

class Child : Person
{
    public string AdditionalPocket { get; protected set; }

    public Child(string name) : base(name)
    {
        AdditionalPocket = string.Empty;
    }
    
    public override void Receive(string present)
    {
        if (Pocket.Equals(string.Empty))
            Pocket = present;
        else if (AdditionalPocket.Equals((string.Empty)))
            AdditionalPocket = present;
        else
            throw new ArgumentException(">1 gift");
    }
    
    public override string ToString()
        => $"Name = {Name}, Pocket = {Pocket}, additionalPocket = {AdditionalPocket}";
}

class Program
{
    public static void Main(string[] args)
    {
        var santa = new Santa("Santa");
        var snowMaiden = new SnowMaiden("SnowMaiden");
        int n = 10;
        var people = new List<Person>(n + 2);
        people.Add(santa);
        people.Add(snowMaiden);

        for (var i = 2; i < n + 2; i++)
            people[i] = new Child(i.ToString());
        
        for (var i = 0; i < n + 2; i++)
            Console.WriteLine(people[i]);

        var rnd = new Random();

        for (var i = 0; i < n + 1; i++)
        {
            var prob = rnd.Next(0, 101);
            if (prob < 10)
                santa.Give(people[0]);
            else
            {
                santa.Give(people[i]);
                santa.Request(snowMaiden, rnd.Next(1, 5));
            }
        }
    }
}