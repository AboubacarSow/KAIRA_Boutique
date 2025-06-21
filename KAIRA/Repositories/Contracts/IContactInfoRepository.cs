using KAIRA.Data.Entities;

namespace KAIRA.Repositories.Contracts;

public interface IContactInfoRepository
{
    Task<List<ContactInfo>> GetAllAsync(bool trackCkanges);
    Task<ContactInfo> GetByIdAsync(int id, bool trackChanges);
    Task UpdateAsync(ContactInfo entity);
    Task CreateAsync(ContactInfo entity);
    Task DeleteAsync(int id);
}
