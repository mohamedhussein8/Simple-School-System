
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Person
{

    public Person()
    {
    }

    public int Id { get; set; }
    public int Age { get; set; }

    public string Name { get; set; }

    public override string? ToString()
    {
        return $"The Name is {Name}\nthe Age {Age}\nthe ID :{Id}";
    }
}