using AutoMapper;
using KAIRA.Features.Mediator.Commands.SubscriberCommands;
using KAIRA.Repositories.Contracts;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KAIRA.Features.Mediator.Handlers.SubscriberHandlers;

public class RemoveSubscriberCommandHandler : IRequestHandler<RemoveSubscriberCommand>
{
    private readonly IRepositoryManager repositoryManager;
    public RemoveSubscriberCommandHandler(IRepositoryManager repositoryManager)
    {
        this.repositoryManager = repositoryManager;
    }
    public async Task Handle(RemoveSubscriberCommand request, CancellationToken cancellationToken)
    {
        await repositoryManager.Subscriber.DeleteAsync(request.Id);
    }
}
