using KAIRA.Features.Mediator.Commands.SocialMediaCommands;
using KAIRA.Features.Mediator.Queries.SocialMediaQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KAIRA.Areas.Admin.Controllers;

[Area("Admin")]
public class SocialMediaController : Controller
{
    private readonly IMediator _mediator;
    public SocialMediaController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<IActionResult> Index()
    {
        var socialMedias = await _mediator.Send(new GetSocialMediaQuery());
        return View(socialMedias);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateSocialMediaCommand socialMediaCommand)
    {
        if (!ModelState.IsValid) return View(socialMediaCommand);
        await _mediator.Send(socialMediaCommand);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Update(int id)
    {
        var contact = await _mediator.Send(new GetSocialMediaByIdQuery(id));
        return View(contact);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateSocialMediaCommand command)
    {
        if (!ModelState.IsValid) return View(command);
        await _mediator.Send(command);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _mediator.Send(new RemoveSocialMediaCommand(id));
        return RedirectToAction(nameof(Index));
    }
}
