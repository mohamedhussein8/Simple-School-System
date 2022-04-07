using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System
{
    public class DepartmentRepo : IRpository<Department>
    {
        public bool Add(Department entity)
        {
            if (!InMemoryDB.Departments.Contains(entity))
            {
                InMemoryDB.Departments.Add(entity);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var dep = InMemoryDB.Departments.FirstOrDefault(x => x.DepartMentNum == id);
            if (dep != null)
            {
                InMemoryDB.Departments.Remove(dep);
                return true;
            }
            return false;
        }

        public Department Find(Func<Department, bool> pridcate)
        {
            return InMemoryDB.Departments.FirstOrDefault(pridcate);
        }

        public IEnumerable<Department> Get()
        {
            return InMemoryDB.Departments;
        }

        public bool Upadate(Department entity)
        {
            for (int i = 0; i < InMemoryDB.Departments.Count; i++)
            {
                if (InMemoryDB.Departments[i].DepartMentNum == entity.DepartMentNum)
                {
                    InMemoryDB.Departments[i] = entity;
                    return true;
                }
            }
            return false;
        }
    }
}
