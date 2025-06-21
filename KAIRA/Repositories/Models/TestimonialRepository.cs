using KAIRA.Data.Context;
using KAIRA.Data.Entities;
using KAIRA.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace KAIRA.Repositories.Models;

public class TestimonialRepository : RepositoryBase<Testimonial>, ITestimionilaRepository
{
    public TestimonialRepository(RepositoryContext context) : base(context)
    {
    }

    public async Task CreateAsync(Testimonial entity)
    {
        Create(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = FindByCondition(c => c.Id == id, false).FirstOrDefault()
                ?? throw new InvalidOperationException();
        Delete(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Testimonial>> GetAllAsync(bool trackCkanges)
    {
        return await FindAll(trackCkanges, include: null).ToListAsync();
    }

    public async Task<Testimonial> GetByIdAsync(int id, bool trackChanges)
    {
        return await FindByCondition(c => c.Id == id, trackChanges).FirstOrDefaultAsync();
    }
    public async Task UpdateAsync(Testimonial entity)
    {
        Update(entity);
        await _context.SaveChangesAsync();
    }
}
