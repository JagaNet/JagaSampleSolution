using Jaga.Sample.Data.Entity;
using System;
using System.Collections.Generic;

namespace Jaga.Sample.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        T GetById(Guid id);
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(Guid id);
    }
}
