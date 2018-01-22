using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeRichardMillard.Repositories
{
    /// <summary>
    /// Base repository functionality
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        void Add(object parent, T entity);
        void Remove(T entity);
        T Get(object parent, int index);
        int Count(object parent);
        IList<T> GetAll(object parent);
    }
}
