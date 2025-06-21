using AutoMapper;
using KAIRA.Features.Mediator.Queries.ContactInfoQueries;
using KAIRA.Features.Mediator.Results.ContactInfoResults;
using KAIRA.Repositories.Contracts;
using MediatR;

namespace KAIRA.Features.Mediator.Handlers.ContactInfoHandlers;

public class GetContactInfoQueryHandler : IRequestHandler<GetContactInfoQuery, List<GetContactInfoQueryResult>>
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public GetContactInfoQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }

    public async Task<List<GetContactInfoQueryResult>> Handle(GetContactInfoQuery request, CancellationToken cancellationToken)
    {
        var contacts = await repositoryManager.ContactInfo.GetAllAsync(false);
        return mapper.Map<List<GetContactInfoQueryResult>>(contacts);   
    }
}
