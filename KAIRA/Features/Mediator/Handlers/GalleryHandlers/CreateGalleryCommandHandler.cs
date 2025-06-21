using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.Mediator.Commands.GalleryCommands;
using KAIRA.Repositories.Contracts;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KAIRA.Features.Mediator.Handlers.GalleryHandlers;

public class CreateGalleryCommandHandler: IRequestHandler<CreateGalleryCommand>
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public CreateGalleryCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }

    public async Task Handle(CreateGalleryCommand request, CancellationToken cancellationToken)
    {
        var gallery = mapper.Map<Gallery>(request);
        await repositoryManager.Gallery.CreateAsync(gallery);
    }
}
