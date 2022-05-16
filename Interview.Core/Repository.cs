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


        private readonly IList<Person> personList = new List<Person>();

        public void Add(T item)
        {
           personList.Add((Entity)item as Person);
            Console.WriteLine("Person Added");
        }

        public IEnumerable<T> FindAll(Func<T, bool> where)
        {
            return (IEnumerable<T>)personList.ToList();
        }

        public T Get(IComparable id)
        {
            
            dynamic result= personList.Where(t => t.Id == id).FirstOrDefault(); 
            if(result==null)
            {
                Console.WriteLine("No Results found");
                return null;
            }
            else
            return result;
        }
    }

}
