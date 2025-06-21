using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.CQRS.Commands.ServiceCommands;
using KAIRA.Features.Mediator.Commands.SubscriberCommands;
using KAIRA.Repositories.Contracts;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KAIRA.Features.Mediator.Handlers.SubscriberHandlers
{
    public class CreateSubscriberCommandHandler : IRequestHandler<CreateSubscriberCommand>
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;
        public CreateSubscriberCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
        }

        public async Task Handle(CreateSubscriberCommand request, CancellationToken cancellationToken)
        {
            var subscriber=mapper.Map<Subscriber>(request);
            await repositoryManager.Subscriber.CreateAsync(subscriber);
        }
    }
}
