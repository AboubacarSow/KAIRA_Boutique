using KAIRA.Data.Context;
using KAIRA.Data.Entities;
using KAIRA.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace KAIRA.Repositories.Models;

public class SubscriberRepository : RepositoryBase<Subscriber>, ISubscriberRepository
{
    public SubscriberRepository(RepositoryContext context) : base(context)
    {
    }


    public async Task CreateAsync(Subscriber entity)
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

    public async Task<List<Subscriber>> GetAllAsync(bool trackCkanges)
    {
        return await FindAll(trackCkanges, include: null).ToListAsync();
    }

    public async Task<Subscriber> GetByIdAsync(int id, bool trackChanges)
    {
        return await FindByCondition(c => c.Id == id, trackChanges).FirstOrDefaultAsync();
    }
   
}
