using AutoMapper;
using KAIRA.Features.Mediator.Commands.ContactInfoCommands;
using KAIRA.Repositories.Contracts;
using MediatR;

namespace KAIRA.Features.Mediator.Handlers.ContactInfoHandlers;

public class RemoveContactInfoCommandHandler : IRequestHandler<RemoveContactInfoCommand>
{
    private readonly IRepositoryManager repositoryManager;
    public RemoveContactInfoCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
    }

    public async Task Handle(RemoveContactInfoCommand request, CancellationToken cancellationToken)
    {
        await repositoryManager.ContactInfo.DeleteAsync(request.Id);
    }
}
