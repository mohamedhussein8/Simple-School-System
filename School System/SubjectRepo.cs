using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System
{
    public class SubjectRepo : IRpository<Subject>
    {
        public bool Add(Subject entity)
        {
            if (!InMemoryDB.Subjects.Contains(entity))
            {
                InMemoryDB.Subjects.Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var subject = InMemoryDB.Subjects.FirstOrDefault(x => x.Code == id);
            if (subject != null)
            {
                InMemoryDB.Subjects.Remove(subject);
                return true;
            }
            return false;
        }

        public Subject Find(Func<Subject, bool> pridcate)
        {
            return InMemoryDB.Subjects.FirstOrDefault(pridcate);
        }

        public IEnumerable<Subject> Get()
        {
            return InMemoryDB.Subjects;
        }

        public bool Upadate(Subject entity)
        {
            for (int i = 0; i < InMemoryDB.Subjects.Count; i++)
            {
                if (InMemoryDB.Subjects[i].Code == entity.Code)
                {
                    InMemoryDB.Subjects[i] = entity;
                    return true;
                }
            }
            return false;
        }
    }
}
