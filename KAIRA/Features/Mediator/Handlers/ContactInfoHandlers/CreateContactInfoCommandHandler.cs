using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.Mediator.Commands.ContactInfoCommands;
using KAIRA.Repositories.Contracts;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KAIRA.Features.Mediator.Handlers.ContactInfoHandlers
{
    public class CreateContactInfoCommandHandler : IRequestHandler<CreateContactInfoCommand>
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;
        public CreateContactInfoCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
        }

        public async Task Handle(CreateContactInfoCommand request, CancellationToken cancellationToken)
        {
            var contact = mapper.Map<ContactInfo>(request);
            await repositoryManager.ContactInfo.CreateAsync(contact);   
        }
    }
}
