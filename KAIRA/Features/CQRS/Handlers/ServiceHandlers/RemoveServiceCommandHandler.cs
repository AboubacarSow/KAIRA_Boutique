using KAIRA.Features.CQRS.Commands.CategoryCommands;
using KAIRA.Features.CQRS.Commands.ServiceCommands;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Features.CQRS.Handlers.ServiceHandlers;
public class RemoveServiceCommandHandler
{
    private readonly IRepositoryManager repositoryManager;

    public RemoveServiceCommandHandler(IRepositoryManager repositoryManager)
    {
        this.repositoryManager = repositoryManager;
    }
    public async Task Handle(RemoveCategoryCommand command)
    {
        await repositoryManager.Service.DeleteAsync(command.Id);    
    }

    internal async Task Handle(RemoveServiceCommand removeServiceCommand)
    {
        throw new NotImplementedException();
    }
}
