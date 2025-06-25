using KAIRA.Features.Mediator.Queries.SocialMediaQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KAIRA.ViewComponents;

public class SocialMediaViewComponent   :ViewComponent
{
    private readonly IMediator _mediator;
    public SocialMediaViewComponent(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var socials = await _mediator.Send(new GetSocialMediaQuery());

        return View(socials);
    }
}
