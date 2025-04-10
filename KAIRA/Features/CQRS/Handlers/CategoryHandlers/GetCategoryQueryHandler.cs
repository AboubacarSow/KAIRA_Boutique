using KAIRA.Features.CQRS.Results.CategoryResults;
using KAIRA.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace KAIRA.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepositoryManager _mananger;
        public GetCategoryQueryHandler(IRepositoryManager mananger)
        {
            _mananger = mananger;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var categories = await _mananger.Category.GetAllAsync(false);

            return categories.Select(category => new GetCategoryQueryResult()
            {
                Id= category.Id,
                Name=category.Name,
                ImageUrl=category.ImageUrl,
          

            }).ToList();
        }
    }
}
