using KAIRA.Features.Mediator.Queries.GalleryQueries;
using KAIRA.Features.Mediator.Results.GalleryResults;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KAIRA.ViewComponents;

public class GalleryViewComponent : ViewComponent
{
    private readonly IMediator _mediator;

    public GalleryViewComponent(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var galleries = await _mediator.Send(new GetGalleryQuery());
        return View(galleries);   
    }
}
