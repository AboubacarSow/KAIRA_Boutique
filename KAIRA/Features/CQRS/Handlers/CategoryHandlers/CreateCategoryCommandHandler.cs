using KAIRA.Data.Entities;
using KAIRA.Features.CQRS.Commands.CategoryCommands;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Features.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly IRepositoryService _manager;

        public CreateCategoryCommandHandler(IRepositoryService manager)
        {
            _manager = manager;
        }

        public async Task Handle(CreateCategoryCommand categoryCommand)
        {
            var category = new Category()
            {
                Name=categoryCommand.Name,
                ImageUrl=categoryCommand.ImageUrl
            };
            _manager.Category.Create(category);
           await  _manager.SaveChangesAsync();
        }
    }
}
