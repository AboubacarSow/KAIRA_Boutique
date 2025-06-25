using KAIRA.Features.CQRS.Handlers.TestimonialHandlers;
using Microsoft.AspNetCore.Mvc;

namespace KAIRA.ViewComponents;

public class TestimonialViewComponent : ViewComponent
{
    private readonly GetTestimonialQueryHandler _handle;
    public TestimonialViewComponent(GetTestimonialQueryHandler handle)
    {
        _handle = handle;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var testimonials = await _handle.Handle();
        return View(testimonials);
    }
}
