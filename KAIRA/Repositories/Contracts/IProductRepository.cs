using KAIRA.Data.Entities;
using System.Linq.Expressions;

namespace KAIRA.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync(Expression<Func<Product, object>> include = null,bool trackCkanges);
        Task<Product> GetByIdAsync(int id, bool trackChanges);
        Task UpdateAsync(Product entity);
        Task CreateAsync(Product entity);
        Task DeleteAsync(int id);
    }
}
