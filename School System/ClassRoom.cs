
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ClassRoom : Room {

    public ClassRoom() {
    }
    public List<Student> Students {get; set;} = new List<Student>();
}