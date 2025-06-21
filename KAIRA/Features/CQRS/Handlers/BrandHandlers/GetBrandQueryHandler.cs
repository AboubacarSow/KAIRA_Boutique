using AutoMapper;
using KAIRA.Features.CQRS.Results.BrandResults;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Features.CQRS.Handlers.BrandHandlers;

public class GetBrandQueryHandler
{

    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public GetBrandQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }
    public async Task<List<GetBrandQueryResult>> Handle()
    {
        var brands = await repositoryManager.Brand.GetAllAsync(false);
        return mapper.Map<List<GetBrandQueryResult>>(brands);
    }
}
