
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Department {

    public Department() {
    }

    public string Name { get; set; }

    public int DepartMentNum { get; set; }

    public List<Instructor> Instructors { get; set; } = new List<Instructor>();

    public override bool Equals(object? obj)
    {
        return obj is Department department &&
               Name == department.Name &&
               DepartMentNum == department.DepartMentNum;
    }

    public override string? ToString()
    {
        return $"dep num {DepartMentNum} ,dep name {Name}";
    }
}