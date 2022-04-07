
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Stage
{

    public Stage()
    {
    }


    public int Level { get; set; }

    public string Name { get; set; }

    public List<Subject> Subjects { get; set; } = new List<Subject>();
    public List<Student> Students { get; set; } = new List<Student>();

}