using KAIRA.Features.Mediator.Commands.SubscriberCommands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KAIRA.Controllers;

public class DefaultController : Controller
{
    private readonly IMediator _mediator;

    public DefaultController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Subscribe([FromBody] CreateSubscriberCommand command)
    {
        await _mediator.Send(command);

        return Json(new { success = true });   

    }
}
