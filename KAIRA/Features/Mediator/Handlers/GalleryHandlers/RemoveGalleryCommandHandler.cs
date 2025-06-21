using KAIRA.Features.Mediator.Commands.GalleryCommands;
using KAIRA.Repositories.Contracts;
using MediatR;

namespace KAIRA.Features.Mediator.Handlers.GalleryHandlers;

public class RemoveGalleryCommandHandler : IRequestHandler<RemoveGalleryCommand>
{
    private readonly IRepositoryManager repositoryManager;
    public RemoveGalleryCommandHandler(IRepositoryManager repositoryManager)
    {
        this.repositoryManager = repositoryManager;
    }

    public async Task Handle(RemoveGalleryCommand request, CancellationToken cancellationToken)
    {
        await repositoryManager.Gallery.DeleteAsync(request.Id);
    }
}
