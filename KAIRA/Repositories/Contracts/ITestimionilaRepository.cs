using KAIRA.Data.Entities;

namespace KAIRA.Repositories.Contracts;

public interface ITestimionilaRepository
{
    Task<List<Testimonial>> GetAllAsync(bool trackCkanges);
    Task<Testimonial> GetByIdAsync(int id, bool trackChanges);
    Task UpdateAsync(Testimonial entity);
    Task CreateAsync(Testimonial entity);
    Task DeleteAsync(int id);
}
