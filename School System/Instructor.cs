
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Instructor : Staff {
    public List<Subject> teachedSubjects { get; set; } = new List<Subject>();
    public Instructor() {
    }

    public override bool Equals(object? obj)
    {
        if (obj is  not Instructor instructor)return false;
        if (object.ReferenceEquals(this, instructor))   return true;
        return Id == instructor.Id &&
               Name == instructor.Name;
    }
}