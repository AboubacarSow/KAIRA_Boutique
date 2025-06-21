using KAIRA.Data.Entities;

namespace KAIRA.Repositories.Contracts;
public interface ISubscriberRepository
{
    Task<List<Subscriber>> GetAllAsync(bool trackCkanges);
    Task<Subscriber> GetByIdAsync(int id, bool trackChanges);
    Task CreateAsync(Subscriber entity);
    Task DeleteAsync(int id);
}
