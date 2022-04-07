
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Staff : Person
{

    public Staff()
    {
    }
    public double Salary { get; set; }
    public int OfficeHours { get; set; }

    public override string? ToString()
    {
        return $"the data of {this.GetType().Name}  :" + base.ToString() + $"\nSalary is {Salary}\n office hours is {OfficeHours}";
    }
}