using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.Mediator.Commands.SocialMediaCommands;
using KAIRA.Repositories.Contracts;
using MediatR;

namespace KAIRA.Features.Mediator.Handlers.SocialMediaHandlers;

public class CreateSocialMediaCommandHandler:IRequestHandler<CreateSocialMediaCommand>
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public CreateSocialMediaCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }

    public async Task Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        var socialMedia = mapper.Map<SocialMedia>(request);
        await repositoryManager.SocialMedia.CreateAsync(socialMedia);
    }
}
