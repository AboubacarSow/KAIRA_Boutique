using KAIRA.Features.Mediator.Queries.ContactInfoQueries;
using KAIRA.Features.Mediator.Commands.ContactInfoCommands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KAIRA.Areas.Admin.Controllers;

[Area("Admin")]
public class ContactInfoController :Controller
{
    private readonly IMediator _mediator;
    public ContactInfoController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<IActionResult> Index()
    {
        var contacts=await  _mediator.Send(new GetContactInfoQuery());
        return View(contacts);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateContactInfoCommand contactCommand)
    {
        if (!ModelState.IsValid) return View(contactCommand);
        await _mediator.Send(contactCommand);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Update(int id)
    {
        var contact= await _mediator.Send(new GetContactInfoByIdQuery(id));
        return View(contact);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateContactInfoCommand command){
        if(!ModelState.IsValid) return View(command);
        await _mediator.Send(command);
        return RedirectToAction(nameof(Index)); 
    }

    public async Task<IActionResult> Delete(int id){
        await _mediator.Send(new RemoveContactInfoCommand(id));
        return RedirectToAction(nameof(Index));
    }
}
