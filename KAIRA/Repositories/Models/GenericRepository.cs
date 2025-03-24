using KAIRA.Data.Context;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Repositories.Models
{
    public class GenericRepository<T>:RepositoryBase<T>, IGenericRepository<T> where T: class
    {
        public GenericRepository(RepositoryContext context) : base(context)
        {
        }

        public Task CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync(bool trackCkanges)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
