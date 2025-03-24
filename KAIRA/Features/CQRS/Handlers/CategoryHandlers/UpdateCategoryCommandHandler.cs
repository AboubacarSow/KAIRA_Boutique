using KAIRA.Data.Entities;
using KAIRA.Features.CQRS.Commands.CategoryCommands;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly IRepositoryService _manager;
        public UpdateCategoryCommandHandler(IRepositoryService manager)
        {
            _manager = manager;
        }

        public async Task Handle(UpdateCategoryCommand categoryCommand)
        {
            var category = new Category()
            {
                Id=categoryCommand.Id,
                Name = categoryCommand.Name,
                ImageUrl=categoryCommand.ImageUrl
            };
            _manager.Category.Update(category);
            await _manager.SaveChangesAsync();
        }
    }
}
