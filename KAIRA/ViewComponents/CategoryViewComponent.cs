using KAIRA.Features.CQRS.Handlers.CategoryHandlers;
using Microsoft.AspNetCore.Mvc;

namespace KAIRA.ViewComponents;

public class CategoryViewComponent: ViewComponent
{
    private readonly GetCategoryQueryHandler _handler;
    public CategoryViewComponent(GetCategoryQueryHandler handler)
    {
        _handler = handler;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var categories = await _handler.Handle();
        return View(categories);
    }
}
