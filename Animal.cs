using System;

public class Animal
{
    public string name;
    public string color;
    public string breed;

    public Animal()
    {
    }

    public Animal(string n, string c, string b)
    {
        this.name = n;
        this.color = c;
        this.breed = b;
    }
}

public class cat : Animal
{
    public cat()
    {
    }

    public cat(string n, string c, string b) : base(n, c, b)
    {
        name = n;
        color = c;
        breed = b;
    }
}

public class tiger : Animal
{
    public tiger()
    {
    }

    public tiger(string n, string c, string b) : base(n, c, b)
    {
        name = n;
        color = c;
        breed = b;
    }
}
