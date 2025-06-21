using KAIRA.Data.Entities;

namespace KAIRA.Repositories.Contracts;

public interface IBrandRepository
{
    Task<List<Brand>> GetAllAsync(bool trackCkanges);
    Task<Brand> GetByIdAsync(int id, bool trackChanges);
    Task UpdateAsync(Brand entity);
    Task CreateAsync(Brand entity);
    Task DeleteAsync(int id);
}
