using AutoMapper;
using KAIRA.Features.Mediator.Commands.ContactInfoCommands;
using KAIRA.Features.Mediator.Commands.SocialMediaCommands;
using KAIRA.Repositories.Contracts;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KAIRA.Features.Mediator.Handlers.SocialMediaHandlers;

public class RemoveSocialMedialCommandHandler:IRequestHandler<RemoveSocialMediaCommand>
{
    private readonly IRepositoryManager repositoryManager;
    public RemoveSocialMedialCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
    }

    public async Task Handle(RemoveSocialMediaCommand request, CancellationToken cancellationToken)
    {
        await repositoryManager.SocialMedia.DeleteAsync(request.Id);
    }
}
