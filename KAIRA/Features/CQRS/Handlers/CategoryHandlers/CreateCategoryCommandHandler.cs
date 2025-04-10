using KAIRA.Data.Entities;
using KAIRA.Features.CQRS.Commands.CategoryCommands;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Features.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly IRepositoryManager _manager;

        public CreateCategoryCommandHandler(IRepositoryManager manager)
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
           await  _manager.Category.CreateAsync(category);
          
        }
    }
}
