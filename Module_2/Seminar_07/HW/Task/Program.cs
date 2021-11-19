using System;
using System.Net;
using System.Reflection;
using System.Text;

class Person
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
        => (Name, Age) = (name, age);
    public virtual string Say() => "I am a simple person.";

    public override string ToString()
        => Say() + " " + $"My name is {Name}, my age is {Age}.";
}

class Doctor : Person
{
    private int exp;
    public int Exp
    {
        get => exp;
        set
        {
            if (value >= 5 && value <= 20)
                exp = value;
            else
            {
                var rnd = new Random();
                exp = rnd.Next(5, 21);
            }
        }
    }

    public override string Say() => $"I am a doctor. I've studied for {exp} years.";

    public string Heal(Person p) => $"I'm gonna heal: " + p.ToString();

    public Doctor(string name, int age, int expr) : base(name, age)
    {
        if (expr >= 5 && expr <= 20)
            exp = expr;
        else
        {
            var rnd = new Random();
            exp = rnd.Next(5, 21);
        }    
    }
}

class Intern : Doctor
{
    private int exp;
    public int Exp
    {
        get => exp;
        set
        {
            if (value >= 1 && value <= 4)
                exp = value;
            else
            {
                var rnd = new Random();
                exp = rnd.Next(1, 5);
            }
        }
    }   
    
    public override string Say() => $"I am an intern. I've studied for {exp} years.";

    public Intern(string name, int age, int expr) : base(name, age, expr)
    {
        if (expr >= 1 && expr <= 4)
            exp = expr;
        else
        {
            var rnd = new Random();
            exp = rnd.Next(1, 4);
        }       
    }
}

class Program
{
    static Random rnd = new Random();
    
    public static string GenerateName()
    {
        var n = rnd.Next(3, 11);
        var s = new StringBuilder(n);
        s.Append((char) rnd.Next('A', 'Z' + 1));
        for (var i = 1; i < n; i++)
            s.Append((char) rnd.Next('a', 'z' + 1));
        return s.ToString();
    }
    
    public static void Main(string[] args)
    {
        var dr = new Doctor(GenerateName(), rnd.Next(18, 61), rnd.Next(-50, 51));
        var intern = new Intern(GenerateName(), rnd.Next(18, 61), rnd.Next(-50, 51));

        var n = int.Parse(Console.ReadLine());
        var m = new Person[n];

        for (var i = 0; i < n - 1; i++)
            m[i] = new Person(GenerateName(), rnd.Next(120));
        m[n - 1] = new Doctor(GenerateName(), rnd.Next(18, 61), rnd.Next(-50, 51));

        for (int i = 0; i < n / 2; i++)
            Console.WriteLine(dr.Heal(m[i]));
        Console.WriteLine(intern.ToString());
        for (int i = n / 2; i < (n % 2 == 0 ? n : n - 1); i++)
            Console.WriteLine(dr.Heal(m[i]));
    }
}