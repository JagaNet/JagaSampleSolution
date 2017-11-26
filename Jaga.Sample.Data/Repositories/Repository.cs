using Jaga.Sample.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Jaga.Sample.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private static List<T> _userList;
        internal Repository()
        {
            _userList = new List<T>();
        }

        public void Add(T entity)
        {
            _userList.Add(entity);
        }

        public void Delete(T entity)
        {
            _userList.Remove(entity);
        }

        public void DeleteById(Guid id)
        {
            var entityToremove = _userList.SingleOrDefault(u => u.Id == id);
            if (entityToremove != null)
            {
                _userList.Remove(entityToremove);
            }
        }

        public List<T> GetAll()
        {
            return _userList;

        }

        public T GetById(Guid id)
        {
            return _userList.SingleOrDefault(u => u.Id == id);

        }

        public void Update(T entity)
        {
            var entityUpdated = _userList.SingleOrDefault(u => u.Id == entity.Id);
            if (entityUpdated != null)
            {
                entityUpdated.ModifiedState = true;
            }

        }
    }
}
