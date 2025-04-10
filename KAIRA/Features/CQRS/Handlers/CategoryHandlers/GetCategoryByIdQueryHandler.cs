using KAIRA.Features.CQRS.Queries.CategoryQueries;
using KAIRA.Features.CQRS.Results.CategoryResults;
using KAIRA.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace KAIRA.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepositoryManager _mananger;
        public GetCategoryByIdQueryHandler(IRepositoryManager mananger)
        {
            _mananger = mananger;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var category = await _mananger.Category
                                           .GetByIdAsync(query.Id, false);
                                          
          
                return new GetCategoryByIdQueryResult() 
                {
                    Id = category.Id,
                    Name=category.Name,
                    ImageUrl=category.ImageUrl,
                };
        }
    }
}
