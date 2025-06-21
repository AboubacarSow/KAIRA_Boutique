using KAIRA.Data.Entities;

namespace KAIRA.Repositories.Contracts;
public interface ISubscriberRepository
{
    Task<List<Category>> GetAllAsync(bool trackCkanges);
    Task<Category> GetByIdAsync(int id, bool trackChanges);
    Task UpdateAsync(Category entity);
    Task CreateAsync(Category entity);
    Task DeleteAsync(int id);
}
