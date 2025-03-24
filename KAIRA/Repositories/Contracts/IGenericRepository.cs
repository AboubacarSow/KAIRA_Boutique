namespace KAIRA.Repositories.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(bool trackCkanges);
        Task<T> GetByIdAsync(int id, bool trackChanges);
        Task UpdateAsync(T entity);
        Task CreateAsync(T entity);
        Task DeleteAsync(int id);
        
    }
}
