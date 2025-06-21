using KAIRA.Data.Entities;

namespace KAIRA.Repositories.Contracts;

public interface IGalleryRepository
{
    Task<List<Gallery>> GetAllAsync(bool trackCkanges);
    Task<Gallery> GetByIdAsync(int id, bool trackChanges);
    Task UpdateAsync(Gallery entity);
    Task CreateAsync(Gallery entity);
    Task DeleteAsync(int id);
}
