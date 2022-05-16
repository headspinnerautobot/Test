using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Core
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll(Func<T, bool> where)
        {
            throw new NotImplementedException();
        }

        public T Get(IComparable id)
        {
            throw new NotImplementedException();
        }
    }
}
