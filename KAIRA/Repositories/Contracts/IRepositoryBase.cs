using System.Linq.Expressions;

namespace KAIRA.Repositories.Contracts;

public interface IRepositoryBase<T> where T :class
{
    IQueryable<T> FindAll(bool trackChanges, Expression<Func<T, object>>? include);
    IQueryable<T> FindByCondition(Expression<Func<T,bool>> condition, bool trackChanges);
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}
