using KAIRA.Data.Context;
using KAIRA.Data.Entities;
using KAIRA.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace KAIRA.Repositories.Models;

public class GalleryRepository : RepositoryBase<Gallery>, IGalleryRepository
{
    public GalleryRepository(RepositoryContext context) : base(context)
    {
    }

    public async Task CreateAsync(Gallery entity)
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

    public async Task<List<Gallery>> GetAllAsync(bool trackCkanges)
    {
        return await FindAll(trackCkanges, include: null).ToListAsync();
    }

    public async Task<Gallery> GetByIdAsync(int id, bool trackChanges)
    {
        return await FindByCondition(c => c.Id == id, trackChanges).FirstOrDefaultAsync();
    }
    public async Task UpdateAsync(Gallery entity)
    {
        Update(entity);
        await _context.SaveChangesAsync();
    }
}
