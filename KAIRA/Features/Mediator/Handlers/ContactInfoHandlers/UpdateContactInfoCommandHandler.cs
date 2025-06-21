using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.Mediator.Commands.ContactInfoCommands;
using KAIRA.Repositories.Contracts;
using MediatR;

namespace KAIRA.Features.Mediator.Handlers.ContactInfoHandlers;

public class UpdateContactInfoCommandHandler : IRequestHandler<UpdateContactInfoCommand>
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public UpdateContactInfoCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }

    public async Task Handle(UpdateContactInfoCommand request, CancellationToken cancellationToken)
    {
        var contact = mapper.Map<ContactInfo>(request);
        await repositoryManager.ContactInfo.UpdateAsync(contact);
    }
}
