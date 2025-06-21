using KAIRA.Data.Context;
using KAIRA.Data.Entities;
using KAIRA.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace KAIRA.Repositories.Models;

public class ContactInfoRepository : RepositoryBase<ContactInfo>, IContactInfoRepository
{
    public ContactInfoRepository(RepositoryContext context) : base(context)
    {
    }


    public async Task CreateAsync(ContactInfo entity)
    {
        Create(entity);
        await _context.SaveChangesAsync();
    }

  
    public async Task<List<ContactInfo>> GetAllAsync(bool trackCkanges)
    {
        return await FindAll(trackCkanges, include: null).ToListAsync();
    }

    public async Task<ContactInfo> GetByIdAsync(int id, bool trackChanges)
    {
        return await FindByCondition(c => c.Id == id, trackChanges).FirstOrDefaultAsync();
    }

    public async Task UpdateAsync(ContactInfo entity)
    {
        Update(entity);
        await _context.SaveChangesAsync();
    }
    

    public async Task DeleteAsync(int id)
    {
        var entity = FindByCondition(c => c.Id == id, false).FirstOrDefault()
                ?? throw new InvalidOperationException();
        Delete(entity);
        await _context.SaveChangesAsync();
    }

  

   

    
}
