using AutoMapper;
using KAIRA.Features.CQRS.Results.HizmetResults;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Features.CQRS.Handlers.ServiceHandlers;

public class GetServiceQueryHandler
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public GetServiceQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }
    public async Task<List<GetServiceQueryResult>> Handle()
    {
        var services= await repositoryManager.Service.GetAllAsync(false);
        return mapper.Map<List<GetServiceQueryResult>>(services);
    }
}
