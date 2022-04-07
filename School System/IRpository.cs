using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System
{
    internal interface IRpository <T>
    {
        bool Add(T entity);
        bool Delete(int id);
        bool Upadate(T entity);
        IEnumerable<T> Get();
        T Find(Func<T ,bool> pridcate);
    }
}
