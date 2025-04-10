using KAIRA.Data.Context;
using KAIRA.Repositories.Contracts;
using System.Threading.Tasks;

namespace KAIRA.Repositories.Models
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<ICategoryRepository> _categoryService;
        private readonly Lazy<IProductRepository> _productService;
        private readonly RepositoryContext _context;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _categoryService = new Lazy<ICategoryRepository>(() => new CategoryRepository(_context));
            _productService = new Lazy<IProductRepository>(() => new ProductRepository(_context));
        }

        public ICategoryRepository Category => _categoryService.Value;

        public IProductRepository Product => _productService.Value;
    }
}
