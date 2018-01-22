using CoffeeRichardMillard.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeRichardMillard.Repositories
{
    /// <summary>
    /// In memory repository lists
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class InMemoryRepository<T> : IRepository<T> where T : BaseItem
    {
        protected IList<T> dataList;
        private int nextId = 0;

        public InMemoryRepository()
        {
            dataList = new List<T>();
        }
        public void Add(object parent, T entity)
        {
            Contract.Requires(entity != null);
            
            dataList.Add(entity);
            entity.Parent = parent;
            entity.Id = nextId;
            nextId++;
        }
        public void Remove(T entity)
        {
            Contract.Requires(entity != null);
            
            dataList.Remove(entity);
        }
        public int Count(object parent)
        {
            int tempCount = 0;
            foreach (var item in dataList)
            {
                if ((parent == null) || (item.Parent == parent))
                    tempCount++;
            }
            return tempCount;
        }
        public T Get(object parent, int index)
        {
            Contract.Requires(parent != null);
            Contract.Requires(index >= 0);

            int numInList = 0;
            foreach (var item in dataList)
            {
                if ((parent == null) || (item.Parent == parent))
                {
                    if (numInList == index)
                        return item;
                    numInList++;
                }
            }

            return null;
        }
        public IList<T> GetAll(object parent)
        {
            if (parent == null)
                return dataList;
            else
            {
                var filteredList = dataList.Where(item => item.Parent == parent);
                return filteredList.ToList();
            }
        }
    }
}
