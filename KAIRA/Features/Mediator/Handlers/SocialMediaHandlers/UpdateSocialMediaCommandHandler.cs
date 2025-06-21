using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.Mediator.Commands.SocialMediaCommands;
using KAIRA.Repositories.Contracts;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KAIRA.Features.Mediator.Handlers.SocialMediaHandlers;

public class UpdateSocialMediaCommandHandler:IRequestHandler<UpdateSocialMediaCommand>
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public UpdateSocialMediaCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }

    public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        var socialMedia = mapper.Map<SocialMedia>(request);
        await repositoryManager.SocialMedia.UpdateAsync(socialMedia);
    }
}
