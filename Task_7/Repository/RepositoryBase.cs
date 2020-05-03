using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Task_7.DbConfiguration;
using Task_7.Interfaces;

namespace Task_7.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryBase(AppDbContext dbContext)
        {
            AppDbContext = dbContext;
        }

        protected AppDbContext AppDbContext { get; set; }


        public virtual IQueryable<T> FindAll()
        {
            return AppDbContext.Set<T>().AsNoTracking();
        }

        public virtual IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return AppDbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public virtual void Create(T entity)
        {
            AppDbContext.Set<T>().Add(entity);
        }

        public virtual void Update(T entity)
        {
            AppDbContext.Set<T>().Update(entity);
        }

        public virtual void Delete(T entity)
        {
            AppDbContext.Set<T>().Remove(entity);
        }
    }
}