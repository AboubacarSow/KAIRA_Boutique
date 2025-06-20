using KAIRA.Data.Context;
using KAIRA.Data.Entities;
using KAIRA.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace KAIRA.Repositories.Models
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {
        }
        public async Task CreateAsync(Product entity)
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

        public async Task<List<Product>> GetAllAsync(bool trackCkanges, Expression<Func<Product, object>>? include)
        {
            return await FindAll(trackCkanges,include).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id, bool trackChanges)
        {
            return await FindByCondition(c => c.Id == id, trackChanges).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Product entity)
        {
            Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
