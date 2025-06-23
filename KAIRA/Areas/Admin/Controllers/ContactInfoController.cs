using KAIRA.Features.Mediator.Queries.ContactInfoQueries;
using KAIRA.Features.Mediator.Commands.ContactInfoCommands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using AutoMapper;

namespace KAIRA.Areas.Admin.Controllers;

[Area("Admin")]
public class ContactInfoController :Controller
{
    private readonly IMediator _mediator;
    private readonly IMapper mapper;
    public ContactInfoController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        this.mapper = mapper;
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
        return View(mapper.Map<UpdateContactInfoCommand>(contact));
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
