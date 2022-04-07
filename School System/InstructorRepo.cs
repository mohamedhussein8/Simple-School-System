using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System
{
    public class InstructorRepo : IRpository<Instructor>
    {
        public bool Add(Instructor entity)
        {

            if (!InMemoryDB.Instructors.Contains(entity))
            {
                InMemoryDB.Instructors.Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var instructor = InMemoryDB.Instructors.FirstOrDefault(x => x.Id == id);
            if (instructor != null)
            {
                InMemoryDB.Instructors.Remove(instructor);
                return true;
            }
            return false;
        }

        public Instructor Find(Func<Instructor, bool> pridcate)
        {
            return InMemoryDB.Instructors.FirstOrDefault(pridcate);
        }

        public IEnumerable<Instructor> Get()
        {
            return InMemoryDB.Instructors;
        }

        public bool Upadate(Instructor entity)
        {
            for (int i = 0; i < InMemoryDB.Instructors.Count; i++)
            {
                if (InMemoryDB.Instructors[i].Id == entity.Id)
                {
                    InMemoryDB.Instructors[i] = entity;
                    return true;
                }
            }
            return false;
        }
    }
}
