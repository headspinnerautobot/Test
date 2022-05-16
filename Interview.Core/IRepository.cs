using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Interview.Core
{
    public interface IRepository<T> where T : Entity
    {
        T Get(IComparable id);

        void Add(T item);

        IEnumerable<T> FindAll(Func<T, bool> where);

    }
}