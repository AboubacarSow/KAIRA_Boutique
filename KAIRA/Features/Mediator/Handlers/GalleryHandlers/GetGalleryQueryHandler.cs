using AutoMapper;
using KAIRA.Features.Mediator.Queries.GalleryQueries;
using KAIRA.Features.Mediator.Results.GalleryResults;
using KAIRA.Repositories.Contracts;
using MediatR;

namespace KAIRA.Features.Mediator.Handlers.GalleryHandlers;

public class GetGalleryQueryHandler : IRequestHandler<GetGalleryQuery, List<GetGalleryQueryResult>>
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public GetGalleryQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }
    public async Task<List<GetGalleryQueryResult>> Handle(GetGalleryQuery request, CancellationToken cancellationToken)
    {
        var galleries = await repositoryManager.Gallery.GetAllAsync(false);
       return mapper.Map<List<GetGalleryQueryResult>>(galleries);   
    }
}
