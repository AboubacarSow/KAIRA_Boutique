using KAIRA.Features.CQRS.Handlers.BrandHandlers;
using Microsoft.AspNetCore.Mvc;

namespace KAIRA.ViewComponents;

public class BrandViewComponent: ViewComponent
{
    private readonly GetBrandQueryHandler _handler;
    public BrandViewComponent(GetBrandQueryHandler handler)
    {
        _handler = handler;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var brand = await _handler.Handle();
        return View(brand); 
    }
}
