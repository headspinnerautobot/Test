using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Core
{
    public class Repository<T> : IRepository<T> where T : Entity
    {


        private readonly IList<T> _entityList;
        public Repository(IList<T> entityList)
        {
            _entityList = entityList;     
        }

        public void Add(T item)
        {
           _entityList.Add(item);
           Console.WriteLine("Person Added");
        }

        public IEnumerable<T> FindAll(Func<T, bool> x)
        {
            return _entityList.Where(x);
        }

        public T Get(IComparable id)
        {        
           var result= _entityList.FirstOrDefault(t => t.Id.Equals(id)); 
           return result;
        }
    }

}
