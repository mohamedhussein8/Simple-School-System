using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System
{
    public static class InMemoryDB
    {
        static InMemoryDB()
        {
            Students = new List<Student>();
            Instructors = new List<Instructor>();
            TeacherRooms = new TeacherRoom()
            {
                instructors = Instructors
            };
            Stages = new List<Stage>();
            Subjects = new List<Subject>();
            Departments = new List<Department>();
            fillStudentList();
            fillSubjectList();
            fillInstructorList();
            fillDepartmentList();
            fillStageList();

        }
        public static List<Student> Students;
        public static List<Instructor> Instructors;
        public static TeacherRoom TeacherRooms;
        public static List<Stage> Stages;
        public static List<Subject> Subjects;
        public static List<Department> Departments;
        #region fill Lists with Data 
        private static void fillStudentList()
        {
            var s1 = new Student()
            {
                Name = "ali"
                , Age = 12
                ,GPA = 2, Id =1
            };
            var s2 = new Student()
            {
                Name = "ahmed"
              ,
                Age = 12
              ,
                GPA = 2,
                Id = 2
            };
            var s3 = new Student()
            {
                Name = "mohamed"
              ,
                Age = 12
              ,
                GPA = 2,
                Id = 3
            };
            var s4 = new Student()
            {
                Name = "sayed"
              ,
                Age = 12
              ,
                GPA = 2,
                Id = 4
            };
            var s5 = new Student()
            {
                Name = "mina"
              ,
                Age = 12
              ,
                GPA = 2,
                Id = 5
            };
            Students.Add(s1);
            Students.Add(s2);
            Students.Add(s3);
            Students.Add(s4);
            Students.Add(s5);
        }
        private static void fillInstructorList()
        {
            var s1 = new Instructor()
            {
                Name = "ali"
                ,
                Age = 40
                ,
                Salary = 45.3,
                OfficeHours = 2,
                Id = 1
               
            };
            var s2 = new Instructor()
            {
                Name = "ahmed"
              ,
                Age = 22
              ,
                Salary = 45.3,
                OfficeHours = 2,
                Id = 2
            };
            var s3 = new Instructor()
            {
                Name = "mohamed"
              ,
                Age = 32
              ,
                Salary = 45.3,
                OfficeHours = 2,
                Id = 3
            };
            var s4 = new Instructor()
            {
                Name = "sayed"
              ,
                Age =35
              ,
                Salary = 45.3,
                OfficeHours = 2,
                Id = 4
            };
            var s5 = new Instructor()
            {
                Name = "EnG Hussien"
              ,
                Age = 24
              ,
                Salary = 45.3,
                OfficeHours = 2,
                Id = 6
            };
            s1.teachedSubjects.Add(Subjects.ElementAt(0));
            s2.teachedSubjects.Add(Subjects.ElementAt(1));
            s3.teachedSubjects.Add(Subjects.ElementAt(2));
            s4.teachedSubjects.Add(Subjects.ElementAt(3));
            s5.teachedSubjects.Add(Subjects.ElementAt(4));
            s5.teachedSubjects.Add(Subjects.ElementAt(0));
            Instructors.Add(s1);
            Instructors.Add(s2);
            Instructors.Add(s3);
            Instructors.Add(s4);
            Instructors.Add(s5);
        }
        private static void fillSubjectList()
        {
            var s1 = new Subject()
            {
                Name = "MAth"
                ,
                Code = 1,
                TotalGrade = 50
            };
            var s2 = new Subject()
            {
                Name = "English"
                ,
                Code = 2,
                TotalGrade = 50
            };      
             var s3 = new Subject()
             {
                 Name = "Arabic"
                ,
                 Code = 3,
                 TotalGrade = 50
             };
            var s4 = new Subject()
            {
                Name = "physics"
                ,
                Code = 4,
                TotalGrade = 50
            };
            var s5 = new Subject()
            {
                Name = "Math 2"
                ,
                Code = 5,
                TotalGrade = 50
            };
            Subjects.Add(s1);
            Subjects.Add(s2);
            Subjects.Add(s3);
            Subjects.Add(s4);
            Subjects.Add(s5);
        }
        private static void fillStageList()
        {
            Stages.Add(new Stage() { Name = "Ola", Level = 1, Students = Students.Take(3).ToList(), Subjects = Subjects.Take(3).ToList() });
            Stages.Add(new Stage() { Name = "tanya", Level = 2, Students = Students.Skip(3).ToList(), Subjects = Subjects.Skip(3).ToList() });
        }
        private static void fillDepartmentList()
        {
            var d1 = new Department()
            {
                DepartMentNum = 1,
                Name = "lang Dep"
            };
            d1.Instructors.Add(Instructors.ElementAt(0));
            d1.Instructors.Add(Instructors.ElementAt(4));
            var d2 = new Department()
            {
                DepartMentNum = 2,
                Name = "Math Dep"
            };
            d2.Instructors.Add(Instructors.ElementAt(1));
            d2.Instructors.Add(Instructors.ElementAt(2));
            var d3 = new Department()
            {
                DepartMentNum = 3,
                Name = "Sci Dep"
            };
            d3.Instructors.Add(Instructors.ElementAt(3));
            Departments.Add(d1);
            Departments.Add(d2);
            Departments.Add(d3);
        }
            #endregion

        
    }
}
