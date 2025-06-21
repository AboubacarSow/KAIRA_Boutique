using AutoMapper;
using KAIRA.Features.CQRS.Queries.ServiceQueries;
using KAIRA.Features.CQRS.Results.HizmetResults;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Features.CQRS.Handlers.ServiceHandlers;

public class GetServiceByIdQueryHandler
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public GetServiceByIdQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }
    public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery query)
    {
        var service=await repositoryManager.Service.GetByIdAsync(query.Id,false);
        return mapper.Map<GetServiceByIdQueryResult>(service);
    }
}
