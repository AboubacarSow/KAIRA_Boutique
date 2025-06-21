using AutoMapper;
using KAIRA.Features.Mediator.Queries.ContactInfoQueries;
using KAIRA.Features.Mediator.Queries.SocialMediaQueries;
using KAIRA.Features.Mediator.Results.ContactInfoResults;
using KAIRA.Features.Mediator.Results.SocialMediaResults;
using KAIRA.Repositories.Contracts;
using KAIRA.Repositories.Models;
using MediatR;

namespace KAIRA.Features.Mediator.Handlers.SocialMediaHandlers;

public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public GetSocialMediaQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }

    public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
    {
        var socialMedias = await repositoryManager.SocialMedia.GetAllAsync(false);
        return mapper.Map<List<GetSocialMediaQueryResult>>(socialMedias);
    }
}
