using KAIRA.Data.Context;
using KAIRA.Data.Entities;
using KAIRA.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace KAIRA.Repositories.Models;

public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
{
    public BrandRepository(RepositoryContext context) : base(context)
    {
    }

    public async Task CreateAsync(Brand entity)
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
    public async Task<List<Brand>> GetAllAsync(bool trackCkanges)
    {
        return await FindAll(trackCkanges, include: null).ToListAsync();
    }

    public async Task<Brand> GetByIdAsync(int id, bool trackChanges)
    {
        return await FindByCondition(c => c.Id == id, trackChanges).FirstOrDefaultAsync();
    }

    public async Task UpdateAsync(Brand entity)
    {
        Update(entity);
        await _context.SaveChangesAsync();
    } 
}
