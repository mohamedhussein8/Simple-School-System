using School_System;
var studentRepo = new StudentRepo();

var insRepo = new InstructorRepo();
var subRepo = new SubjectRepo();
var depRepo = new DepartmentRepo();
var admin = new Admin(studentRepo,insRepo,subRepo,depRepo)

var admin = new Admin(studentRepo,ins,
 subjectRepo,depRepo)

{
    Id = 1,
    Age = 24,
    Name = "ahmed samir",
    OfficeHours = 5,
    Salary = 25_0000
};
var adminRoom = new AdminRoom() { OurAdmin = admin };
admin.getStudent();
admin.updateStudent(new Student()
{
    Name = "ali"
                ,
    Age = 13
                ,
    GPA = 2,
    Id = 1
});
admin.removeStudentById(2);
admin.getStudent();






void ManageStudent()
{
    bool Manage = true;
    Console.Clear();
    while (Manage)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Add student");
        Console.WriteLine("2) Delete student");
        Console.WriteLine("3) Update student");
        Console.WriteLine("4) Search for Student");
        Console.WriteLine("5) Back");
        Console.Write("\r\nSelect an option: ");


        Student s1;
        int age;
        int id;
        float gpa;

        switch (Console.ReadLine())
        {
            case "1":
                s1 = new Student();
                Console.WriteLine("enter id:");
                while (!Int32.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Bad integer");
                }
                s1.Id = id;

                Console.WriteLine("enter age:");
                while (!Int32.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Bad integer");
                }
                s1.Age = age;


                Console.WriteLine("enter gpa:");
                while (!float.TryParse(Console.ReadLine(), out gpa))
                {
                    Console.WriteLine("Bad integer");
                }

                s1.GPA = gpa;
                Console.WriteLine("enter name:");
                s1.Name = Console.ReadLine();

                admin.addStudent(s1);
                Manage = true;
                break;
            case "2":
                Console.WriteLine("enter id of student");
                while (!Int32.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Bad integer");
                }
                admin.removeStudentById(id);
                Manage = true;
                break;
            case "3":
                s1 = new Student();
                Console.WriteLine("enter id:");
                while (!Int32.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Bad integer");
                }
                s1.Id = id;

                Console.WriteLine("enter age:");
                while (!Int32.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Bad integer");
                }
                s1.Age = age;


                Console.WriteLine("enter gpa:");
                while (!float.TryParse(Console.ReadLine(), out gpa))
                {
                    Console.WriteLine("Bad integer");
                }

                s1.GPA = gpa;
                Console.WriteLine("enter name:");
                s1.Name = Console.ReadLine();

                admin.updateStudent(s1);
                Manage = true;
                break;
            case "4":
                Console.WriteLine("enter id:");
                while (!Int32.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Bad integer");
                }
                var data = admin.searchStudent(id);
                Console.WriteLine(data);
                Manage = true;
                break;
            case "5":
                Manage = false;
                break;
            default:
                Manage = true;
                break;
        }
    }
}

void ManageDepartment()
{
    bool Manage = true;
    Console.Clear();
    while (Manage)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Add department");
        Console.WriteLine("2) Delete department");
        Console.WriteLine("3) Update department");
        Console.WriteLine("4) Search for department");
        Console.WriteLine("5) Back");
        Console.Write("\r\nSelect an option: ");


        Department d1;
        int id;
        float gpa;

        switch (Console.ReadLine())
        {
            case "1":
                d1 = new Department();
                Console.WriteLine("enter department number:");
                while (!Int32.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Bad integer");
                }
                d1.DepartMentNum = id;

                Console.WriteLine("enter name:");
                d1.Name = Console.ReadLine();

                admin.addDep(d1);
                Manage = true;
                break;
            case "2":
                Console.WriteLine("enter department number:");
                while (!Int32.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Bad integer");
                }
                admin.removeDepartmentByCode(id);
                Manage = true;
                break;
            case "3":
                d1 = new Department();
                Console.WriteLine("enter department number:");
                while (!Int32.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Bad integer");
                }
                d1.DepartMentNum = id;


                Console.WriteLine("enter name:");
                d1.Name = Console.ReadLine();

                admin.updateDepartment(d1);
                Manage = true;
                break;
            case "4":
                Console.WriteLine("enter department number:");
                while (!Int32.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Bad integer");
                }
                var data =  admin.searchDepartment(id);
                Console.WriteLine(data);
                Manage = true;
                break;
            case "5":
                Manage = false;
                break;
            default:
                Manage = true;
                break;
        }
    }

}

void ManageInstructor()
{
    bool Manage = true;
    Console.Clear();
    while (Manage)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Add instructor");
        Console.WriteLine("2) Delete instructor");
        Console.WriteLine("3) Update instructor");
        Console.WriteLine("4) Search for instructor");
        Console.WriteLine("5) Back");
        Console.Write("\r\nSelect an option: ");


        Instructor i1;
        int age;
        int id;
        int OfficeHours;
        double Salary;

        switch (Console.ReadLine())
        {
            case "1":
                i1 = new Instructor();
                Console.WriteLine("enter id:");
                while (!Int32.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Bad integer");
                }
                i1.Id = id;


                Console.WriteLine("enter age:");
                while (!Int32.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Bad integer");
                }
                i1.Age = age;


                Console.WriteLine("enter office hours:");
                while (!int.TryParse(Console.ReadLine(), out OfficeHours))
                {
                    Console.WriteLine("Bad integer");
                }
                i1.OfficeHours = OfficeHours;

                Console.WriteLine("enter salary:");
                while (!double.TryParse(Console.ReadLine(), out Salary))
                {
                    Console.WriteLine("Bad integer");
                }
                i1.Salary = Salary;


                Console.WriteLine("enter name:");
                i1.Name = Console.ReadLine();

                admin.addInstructor(i1);
                Manage = true;
                break;
            case "2":
                Console.WriteLine("enter id of instructor:");
                while (!Int32.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Bad integer");
                }
                admin.removeInstructorById(id);
                Manage = true;
                break;
            case "3":
                i1 = new Instructor();
                Console.WriteLine("enter id:");
                while (!Int32.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Bad integer");
                }
                i1.Id = id;

                Console.WriteLine("enter age:");
                while (!Int32.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Bad integer");
                }
                i1.Age = age;


                Console.WriteLine("enter office hours:");
                while (!int.TryParse(Console.ReadLine(), out OfficeHours))
                {
                    Console.WriteLine("Bad integer");
                }
                i1.OfficeHours = OfficeHours;

                Console.WriteLine("enter salary:");
                while (!double.TryParse(Console.ReadLine(), out Salary))
                {
                    Console.WriteLine("Bad integer");
                }
                i1.Salary = Salary;


                Console.WriteLine("enter name:");
                i1.Name = Console.ReadLine();


                admin.updateInstructor(i1);
                Manage = true;
                break;
            case "4":
                Console.WriteLine("enter id:");
                while (!Int32.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Bad integer");
                }
                var data = admin.searchInstructor(id);
                Console.WriteLine(data);
                Manage = true;
                break;
            case "5":
                Manage = false;
                break;
            default:
                Manage = true;
                break;
        }
    }
}

void ManageCourse()
{
    bool Manage = true;
    Console.Clear();
    while (Manage)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Add subject");
        Console.WriteLine("2) Delete subject");
        Console.WriteLine("3) Update subject");
        Console.WriteLine("4) Search for subject");
        Console.WriteLine("5) Back");
        Console.Write("\r\nSelect an option: ");


        Subject s1;
        int totalgrade;
        int code;
        switch (Console.ReadLine())
        {
            case "1":
                s1 = new Subject();
                Console.WriteLine("enter code:");
                while (!Int32.TryParse(Console.ReadLine(), out code))
                {
                    Console.WriteLine("Bad integer");
                }
                s1.Code = code;

                Console.WriteLine("enter total grade:");
                while (!Int32.TryParse(Console.ReadLine(), out totalgrade))
                {
                    Console.WriteLine("Bad integer");
                }
                s1.TotalGrade = totalgrade;

                Console.WriteLine("enter name:");
                s1.Name = Console.ReadLine();

                admin.addSubject(s1);
                Manage = true;
                break;
            case "2":
                Console.WriteLine("enter code of subject");
                while (!Int32.TryParse(Console.ReadLine(), out code))
                {
                    Console.WriteLine("Bad integer");
                }
                admin.removeSubjectByCode(code);
                Manage = true;
                break;
            case "3":
                s1 = new Subject();
                Console.WriteLine("enter code:");
                while (!Int32.TryParse(Console.ReadLine(), out code))
                {
                    Console.WriteLine("Bad integer");
                }
                s1.Code = code;

                Console.WriteLine("enter total grade:");
                while (!Int32.TryParse(Console.ReadLine(), out totalgrade))
                {
                    Console.WriteLine("Bad integer");
                }
                s1.TotalGrade = totalgrade;

                Console.WriteLine("enter name:");
                s1.Name = Console.ReadLine();

                admin.updateSubject(s1);
                Manage = true;
                break;
            case "4":
                Console.WriteLine("enter subject code:");
                while (!Int32.TryParse(Console.ReadLine(), out code))
                {
                    Console.WriteLine("Bad integer");
                }
                var data = admin.searchSubject(code);
                Console.WriteLine(data);
                Manage = true;
                break;
            case "5":
                Manage = false;
                break;
            default:
                Manage = true;
                break;
        }
    }

}


bool MainMenu()
{
    Console.Clear();
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1) Manage student");
    Console.WriteLine("2) Manage department");
    Console.WriteLine("3) Manage instructor");
    Console.WriteLine("4) Manage course");
    Console.WriteLine("5) Exit");
    Console.Write("\r\nSelect an option: ");

    switch (Console.ReadLine())
    {
        case "1":
            ManageStudent();
            return true;
        case "2":
            ManageDepartment();
            return true;
        case "3":
            ManageInstructor();
            return true;
        case "4":
            ManageCourse();
            return true;
        case "5":
            return false;
        default:
            return true;
    }
}



bool showMenu = true;
while (showMenu)
{
    showMenu = MainMenu();
}

}

