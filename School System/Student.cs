
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student : Person {

    public Student() {
    }

    public double GPA { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
      
        Student student = (Student)obj;
        if(Object.ReferenceEquals(this, student)) return true;

         return Id == student.Id &&
               Age == student.Age &&
               Name == student.Name &&
               GPA == student.GPA;
    }

    public override string? ToString()
    {
        return "the Student data is  :"+base.ToString() + $"\nGpa is {GPA}";
    }

}