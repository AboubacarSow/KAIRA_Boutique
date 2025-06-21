using AutoMapper;
using KAIRA.Features.Mediator.Queries.SocialMediaQueries;
using KAIRA.Features.Mediator.Results.SocialMediaResults;
using KAIRA.Repositories.Contracts;
using MediatR;

namespace KAIRA.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaByIdQueryHandler:IRequestHandler<GetSocialMediaByIdQuery,GetSocialMediaByIdQueryResult>
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;
        public GetSocialMediaByIdQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
        }

        public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var socialMedias = await repositoryManager.SocialMedia.GetAllAsync(false);
            return mapper.Map<GetSocialMediaByIdQueryResult>(socialMedias);
        }
    }
}
