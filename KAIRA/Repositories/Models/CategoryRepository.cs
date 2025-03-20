using KAIRA.Data.Context;
using KAIRA.Data.Entities;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Repositories.Models
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
