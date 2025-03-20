using KAIRA.Features.CQRS.Results;
using KAIRA.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace KAIRA.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepositoryService _mananger;
        public GetCategoryQueryHandler(IRepositoryService mananger)
        {
            _mananger = mananger;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var categories = await _mananger.Category.FindAll(false).ToListAsync();

            return categories.Select(category => new GetCategoryQueryResult()
            {
                Id= category.Id,
                Name=category.Name,
                ImageUrl=category.ImageUrl,
                Products=category.Products

            }).ToList();
        }
    }
}
