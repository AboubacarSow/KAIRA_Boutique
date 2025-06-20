using KAIRA.Data.Entities;
using System.Linq.Expressions;

namespace KAIRA.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync(bool trackCkanges,Expression<Func<Product, object>>? include);
        Task<Product> GetByIdAsync(int id, bool trackChanges);
        Task UpdateAsync(Product entity);
        Task CreateAsync(Product entity);
        Task DeleteAsync(int id);
    }
}
