using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace UnitOfWorkProject.Interfaces
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}