using KAIRA.Features.CQRS.Commands.CategoryCommands;
using KAIRA.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace KAIRA.Features.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly IRepositoryService _manager;
        public RemoveCategoryCommandHandler(IRepositoryService manager)
        {
            _manager = manager;
        }
        public async Task Handle(RemoveCategoryCommand removeCommand)
        {
            var category = await _manager.Category.FindByCondition(c => c.Id == removeCommand.Id,true)
                                .FirstOrDefaultAsync();
            if (category is null)
                throw new ArgumentNullException("Category may be null her");
            _manager.Category.Delete(category);
            await _manager.SaveChangesAsync();
        }
    }
}
