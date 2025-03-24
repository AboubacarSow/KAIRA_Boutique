using KAIRA.Data.Entities;
using KAIRA.Repositories.Models;

namespace KAIRA.Repositories.Contracts
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllAsync(bool trackCkanges);
        Task<Category> GetByIdAsync(int id, bool trackChanges);
        Task UpdateAsync(Category entity);
        Task CreateAsync(Category entity);
        Task DeleteAsync(int id);
    }
}
