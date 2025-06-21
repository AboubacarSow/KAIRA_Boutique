using AutoMapper;
using KAIRA.Features.CQRS.Queries.BrandQueries;
using KAIRA.Features.CQRS.Results.BrandResults;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Features.CQRS.Handlers.BrandHandlers;

public class GetBrandByIdQueryHandler
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public GetBrandByIdQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }
    public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
    {
        var brand= await repositoryManager.Brand.GetByIdAsync(query.Id,false);
        return mapper.Map<GetBrandByIdQueryResult>(brand);
    }
}
