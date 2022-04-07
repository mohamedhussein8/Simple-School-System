
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Subject
{

    public Subject()
    {
    }

    public int Code { get; set; }

    public string Name { get; set; }

    public int TotalGrade { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is Subject subject &&
               Code == subject.Code &&
               Name == subject.Name &&
               TotalGrade == subject.TotalGrade;
    }

    public override string? ToString()
    {
        return $"the Course Name is {Name} , the Course Code is {Code} and the Total grade is {TotalGrade}";
    }
}