using KAIRA.Features.CQRS.Commands.CategoryCommands;
using KAIRA.Features.CQRS.Handlers.CategoryHandlers;
using KAIRA.Features.CQRS.Queries.CategoryQueries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace KAIRA.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly GetCategoryQueryHandler _getCategoryHandler;
        private readonly GetCategoryByIdQueryHandler _getCategoryByIdHandler;
        private readonly CreateCategoryCommandHandler _createCategoryHandler;
        private readonly RemoveCategoryCommandHandler _removeCategoryHandler;
        private readonly UpdateCategoryCommandHandler _updateCategoryHandler;

        public CategoryController(GetCategoryQueryHandler getCategoryHandler, 
            GetCategoryByIdQueryHandler getCategoryByIdHandler,
            CreateCategoryCommandHandler createCategoryCommandHandler,
            RemoveCategoryCommandHandler removeCategoryHandler,
            UpdateCategoryCommandHandler updateCategoryHandler)
        {
            _getCategoryHandler = getCategoryHandler;
            _getCategoryByIdHandler = getCategoryByIdHandler;
            _createCategoryHandler = createCategoryCommandHandler;
            _removeCategoryHandler = removeCategoryHandler;
            _updateCategoryHandler = updateCategoryHandler;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _getCategoryHandler.Handle();
            return View(categories);
        }
        public async Task<IActionResult> Update([FromRoute]int id)
        {
            var category = await _getCategoryByIdHandler.Handle(new GetCategoryByIdQuery(id));
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Update([FromForm]UpdateCategoryCommand command)
        {
            await _updateCategoryHandler.Handle(command);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]CreateCategoryCommand categoryCommand)
        {
            await _createCategoryHandler.Handle(categoryCommand);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            await _removeCategoryHandler.Handle(new RemoveCategoryCommand(id));
            return RedirectToAction(nameof(Index));
        }
    }
}
