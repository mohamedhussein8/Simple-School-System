using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System
{
    public class StudentRepo : IRpository<Student>
    {
        public bool Add(Student entity)
        {
            if (!InMemoryDB.Students.Contains(entity)) { 
                InMemoryDB.Students.Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var studnet = InMemoryDB.Students.FirstOrDefault(x => x.Id == id);
            if (studnet != null)
            { 
                InMemoryDB.Students.Remove(studnet);
                return true;
            }
            return false;
        }

        public Student Find(Func<Student, bool> pridcate)
        {
            return InMemoryDB.Students.FirstOrDefault(pridcate);
        }

        public IEnumerable<Student> Get()
        {
            return InMemoryDB.Students;
        }

        public bool Upadate(Student entity)
        {
            for (int i = 0; i < InMemoryDB.Students.Count; i++)
            {
                if (InMemoryDB.Students[i].Id == entity.Id)
                {
                    InMemoryDB.Students[i] = entity;
                    return true;
                }
            }
            return false;
        }
    }
}
