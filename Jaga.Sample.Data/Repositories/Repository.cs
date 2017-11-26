using Jaga.Sample.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Jaga.Sample.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
      
        internal Repository()
        {
           
        }

        public void Add(T entity)
        {
          
             throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
             throw new NotImplementedException();
        }

        public T GetById(Guid id)
        {
  
             throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
