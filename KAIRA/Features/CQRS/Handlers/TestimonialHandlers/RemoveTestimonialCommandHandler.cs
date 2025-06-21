using KAIRA.Features.CQRS.Commands.TestimonialCommands;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Features.CQRS.Handlers.TestimonialHandlers;

public class RemoveTestimonialCommandHandler
{
    private readonly IRepositoryManager repositoryManager;
    public RemoveTestimonialCommandHandler(IRepositoryManager repositoryManager)
    {
        this.repositoryManager = repositoryManager;
    }
    public async Task Handle(RemoveTestimonialCommand command)
    {
        await repositoryManager.Testimionial.DeleteAsync(command.Id);    
    }
}
