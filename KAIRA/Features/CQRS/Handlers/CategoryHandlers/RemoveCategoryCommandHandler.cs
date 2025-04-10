using KAIRA.Features.CQRS.Commands.CategoryCommands;
using KAIRA.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace KAIRA.Features.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly IRepositoryManager _manager;
        public RemoveCategoryCommandHandler(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public async Task Handle(RemoveCategoryCommand removeCommand)
        {
           await  _manager.Category.DeleteAsync(removeCommand.Id);
            
        }
    }
}
