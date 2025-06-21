using AutoMapper;
using KAIRA.Features.Mediator.Queries.SubcriberQueries;
using KAIRA.Features.Mediator.Results.SubscriberResults;
using KAIRA.Repositories.Contracts;
using MediatR;

namespace KAIRA.Features.Mediator.Handlers.SubscriberHandlers;

public class GetSubscriberQueryHandler : IRequestHandler<GetSubscriberQuery, List<GetSubscriberQueryResult>>
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public GetSubscriberQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }
    public async Task<List<GetSubscriberQueryResult>> Handle(GetSubscriberQuery request, CancellationToken cancellationToken)
    {
        var subscribers = await repositoryManager.Subscriber.GetAllAsync(false);
        return mapper.Map<List<GetSubscriberQueryResult>>(subscribers); 
    }
}
