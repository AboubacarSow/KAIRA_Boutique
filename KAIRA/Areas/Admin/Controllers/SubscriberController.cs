using KAIRA.Features.Mediator.Commands.SocialMediaCommands;
using KAIRA.Features.Mediator.Commands.SubscriberCommands;
using KAIRA.Features.Mediator.Queries.SocialMediaQueries;
using KAIRA.Features.Mediator.Queries.SubcriberQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KAIRA.Areas.Admin.Controllers;

[Area("Admin")]
public class SubscriberController :Controller
{
    private readonly IMediator _mediator;
    public SubscriberController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<IActionResult> Index()
    {
        var socialMedias = await _mediator.Send(new GetSubscriberQuery());
        return View(socialMedias);
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _mediator.Send(new RemoveSubscriberCommand(id));
        return RedirectToAction(nameof(Index));
    }
}
