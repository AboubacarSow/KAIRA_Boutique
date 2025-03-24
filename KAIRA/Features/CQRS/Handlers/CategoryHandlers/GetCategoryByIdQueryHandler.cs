using KAIRA.Features.CQRS.Queries.CategoryQueries;
using KAIRA.Features.CQRS.Results;
using KAIRA.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace KAIRA.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepositoryService _mananger;
        public GetCategoryByIdQueryHandler(IRepositoryService mananger)
        {
            _mananger = mananger;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var category =await  _mananger.Category
                                           .FindByCondition(x => x.Id == query.Id, false)
                                           .SingleOrDefaultAsync();
          
                return new GetCategoryByIdQueryResult() 
                {
                    Id = category.Id,
                    Name=category.Name,
                    ImageUrl=category.ImageUrl,
                };
        }
    }
}
