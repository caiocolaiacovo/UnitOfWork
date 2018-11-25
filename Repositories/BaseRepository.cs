using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using UnitOfWorkProject.Context;
using UnitOfWorkProject.Interfaces;
using UnitOfWorkProject.Models;

namespace UnitOfWorkProject.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        private readonly StoreContext context;

        public BaseRepository(StoreContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null) 
        {
            DbSet<T> query = context.Set<T>();

            if (filter != null) {
                query.Where(filter);
            }
            
            return query.ToList();
        }

        public T GetById(int id) {
            return context.Set<T>().Find(id);
        }

        public void Add(T entity) {
            context.Set<T>().Add(entity);
        }

        public void Update(T entity) {
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int entityId) {
            T entity = context.Set<T>().Find(entityId);

            context.Remove(entity);
        }
    }
}