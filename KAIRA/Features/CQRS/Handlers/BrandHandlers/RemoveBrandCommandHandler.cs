using KAIRA.Features.CQRS.Commands.BrandCommand;
using KAIRA.Features.CQRS.Commands.CategoryCommands;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Features.CQRS.Handlers.BrandHandlers;

public class RemoveBrandCommandHandler
{
    private readonly IRepositoryManager repositoryManager;

    public RemoveBrandCommandHandler(IRepositoryManager repositoryManager)
    {
        this.repositoryManager = repositoryManager;
    }
    public async Task Handle(RemoveBrandCommand command)
    {
        await repositoryManager.Brand.DeleteAsync(command.Id);
    }
}
