using AutoMapper;
using KAIRA.Features.Mediator.Queries.GalleryQueries;
using KAIRA.Features.Mediator.Results.GalleryResults;
using KAIRA.Repositories.Contracts;
using MediatR;
using System.Drawing.Drawing2D;

namespace KAIRA.Features.Mediator.Handlers.GalleryHandlers;

public class GetGalleryByIdQueryHandler : IRequestHandler<GetGalleryByIdQuery, GetGalleryByIdQueryResult>
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public GetGalleryByIdQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }

    public async Task<GetGalleryByIdQueryResult> Handle(GetGalleryByIdQuery request, CancellationToken cancellationToken)
    {
        var gallery = await repositoryManager.Gallery.GetByIdAsync(request.Id,false);
        return mapper.Map<GetGalleryByIdQueryResult>(gallery);
    }
}
