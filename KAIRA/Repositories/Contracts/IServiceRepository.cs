using KAIRA.Data.Entities;

namespace KAIRA.Repositories.Contracts;

public interface IServiceRepository
{
    Task<List<Service>> GetAllAsync(bool trackCkanges);
    Task<Service> GetByIdAsync(int id, bool trackChanges);
    Task UpdateAsync(Service entity);
    Task CreateAsync(Service entity);
    Task DeleteAsync(int id);
}
