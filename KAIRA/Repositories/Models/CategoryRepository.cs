using KAIRA.Data.Context;
using KAIRA.Data.Entities;
using KAIRA.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace KAIRA.Repositories.Models
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {
        }

        public async Task CreateAsync(Category entity)
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

        public async Task<List<Category>> GetAllAsync(bool trackCkanges)
        {
            return await FindAll(trackCkanges,null).ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id, bool trackChanges)
        {
            return await FindByCondition(c => c.Id == id, trackChanges).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Category entity)
        {
            Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
