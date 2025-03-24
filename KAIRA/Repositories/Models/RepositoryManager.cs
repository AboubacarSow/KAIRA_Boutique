using KAIRA.Data.Context;
using KAIRA.Repositories.Contracts;
using System.Threading.Tasks;

namespace KAIRA.Repositories.Models
{
    public class RepositoryManager : IRepositoryService
    {
        private readonly Lazy<ICategoryRepository> _categoryService;
        private readonly RepositoryContext _context;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _categoryService = new Lazy<ICategoryRepository>(() => new CategoryRepository(_context));
        }

        public ICategoryRepository Category => _categoryService.Value;

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
