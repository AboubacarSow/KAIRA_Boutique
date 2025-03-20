using KAIRA.Features.CQRS.Handlers.CategoryHandlers;
using Microsoft.AspNetCore.Mvc;


namespace KAIRA.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly GetCategoryQueryHandler _getCategoryHandler;

        public CategoryController(GetCategoryQueryHandler getCategoryHandler)
        {
            _getCategoryHandler = getCategoryHandler;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _getCategoryHandler.Handle();
            return View(categories);
        }
    }
}
