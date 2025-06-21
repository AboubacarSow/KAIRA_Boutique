using AutoMapper;
using KAIRA.Features.Mediator.Queries.ContactInfoQueries;
using KAIRA.Features.Mediator.Results.ContactInfoResults;
using KAIRA.Repositories.Contracts;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KAIRA.Features.Mediator.Handlers.ContactInfoHandlers;

public class GetContactInfoByIdQueryHandler : IRequestHandler<GetContactInfoByIdQuery, GetContactInfoByIdQueryResult>
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public GetContactInfoByIdQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }

    public async Task<GetContactInfoByIdQueryResult> Handle(GetContactInfoByIdQuery request, CancellationToken cancellationToken)
    {
        var contact = await repositoryManager.ContactInfo.GetByIdAsync(request.Id,false);
        return mapper.Map<GetContactInfoByIdQueryResult>(contact);
    }
}
