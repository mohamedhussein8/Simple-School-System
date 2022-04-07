
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using School_System;
public class Admin : Staff
{

    public Admin() { }
    public Admin(StudentRepo _studentRepo , InstructorRepo inss ,SubjectRepo subb ,DepartmentRepo dep)
    {
        this.StudentRepo = _studentRepo;
        InstructorRepo = inss;
        SubjectRepo = subb;
        depRepo = dep;

    }
    private IRpository<Student> StudentRepo;
    private IRpository<Instructor>InstructorRepo ;
    private IRpository<Subject> SubjectRepo;
    private IRpository<Department> depRepo;
    public void addStudent(Student s)
    {
        if (StudentRepo.Add(s)) {
            Console.WriteLine("added Succuessfully");        
        }
        else
        {
            Console.WriteLine("Error");
        }
    }


    public void removeStudentById(int id)
    {
        if (StudentRepo.Delete(id))
        {
            Console.WriteLine("deleted Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    public void updateStudent(Student s)
    {
        if (StudentRepo.Upadate(s))
        {
            Console.WriteLine("Update Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    public void getStudent()
    {
        foreach (var studnet in StudentRepo.Get()) {

            Console.WriteLine(studnet);
        }
    }

 
    public Student searchStudent(int id)
    {
        return StudentRepo.Find(X=> X.Id == id); 
    }

    public void addInstructor(Instructor i)
    {
        if (InstructorRepo.Add(i))
        {
            Console.WriteLine("added Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }


    public void removeInstructorById(int id)
    {
        if (InstructorRepo.Delete(id))
        {
            Console.WriteLine("deleted Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    public void updateInstructor(Instructor i)
    {
        if (InstructorRepo.Upadate(i))
        {
            Console.WriteLine("Update Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    public void getInstructor()
    {
        foreach (var instructor in InstructorRepo.Get())
        {

            Console.WriteLine(instructor);
        }
    }
    public void addSubject(Subject s)
    {
        if (SubjectRepo.Add(s))
        {
            Console.WriteLine("added Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }


    public void removeSubjectByCode(int code)
    {
        if (SubjectRepo.Delete(code))
        {
            Console.WriteLine("deleted Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    public void updateSubject(Subject s)
    {
        if (SubjectRepo.Upadate(s))
        {
            Console.WriteLine("Update Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    public void getSubject()
    {
        foreach (var subject in SubjectRepo.Get())
        {

            Console.WriteLine(subject);
        }
    }
    public Subject searchSubject(int code)
    {
        return SubjectRepo.Find(X => X.Code == code);
    }
    public Instructor searchInstructor(int id)
    {
        return InstructorRepo.Find(X => X.Id == id);
    }

    public void addDep(Department d)
    {
        if (depRepo.Add(d))
        {
            Console.WriteLine("added Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }


    public void removeDepartmentByCode(int code)
    {
        if (depRepo.Delete(code))
        {
            Console.WriteLine("deleted Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    public void updateDepartment(Department d)
    {
        if (depRepo.Upadate(d))
        {
            Console.WriteLine("Update Succuessfully");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    public void getDepartment()
    {
        foreach (var dep in depRepo.Get())
        {

            Console.WriteLine(dep);
        }
    }
    public Department searchDepartment(int code)
    {
        return depRepo.Find(X => X.DepartMentNum == code);
    }


}
