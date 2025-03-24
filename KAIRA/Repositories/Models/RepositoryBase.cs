using KAIRA.Data.Context;
using KAIRA.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KAIRA.Repositories.Models
{
    public abstract class RepositoryBase<T>(RepositoryContext context) : IRepositoryBase<T> where T :class
    {
        protected readonly RepositoryContext _context = context;
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public IQueryable<T> FindAll(bool trackChanges)
        {
            return !trackChanges
                    ? _context.Set<T>().AsNoTracking()
                    : _context.Set<T>();
                
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition, bool trackChanges)
        {
            return !trackChanges
                   ? _context.Set<T>().Where(condition).AsNoTracking()
                   : _context.Set<T>().Where(condition);
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
