using KAIRA.Data.Entities;

namespace KAIRA.Repositories.Contracts;

public interface ISocialMediaRepository
{
    Task<List<SocialMedia>> GetAllAsync(bool trackCkanges);
    Task<SocialMedia> GetByIdAsync(int id, bool trackChanges);
    Task UpdateAsync(SocialMedia entity);
    Task CreateAsync(SocialMedia entity);
    Task DeleteAsync(int id);
}
