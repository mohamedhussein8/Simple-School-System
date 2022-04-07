
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TeacherRoom : Room {

    public List<Instructor> instructors { get; set; } = new List<Instructor>();   
    public TeacherRoom() {
    }

}