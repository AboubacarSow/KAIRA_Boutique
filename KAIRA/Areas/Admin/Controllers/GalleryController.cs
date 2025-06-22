using AutoMapper;
using KAIRA.Features.Mediator.Commands.GalleryCommands;
using KAIRA.Features.Mediator.Queries.GalleryQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KAIRA.Areas.Admin.Controllers;

[Area("Admin")]
public class GalleryController : Controller
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public GalleryController(IMediator mediator,IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        var galleries = await _mediator.Send(new GetGalleryQuery());
        return View(galleries);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateGalleryCommand galleryCommand)
    {
        if (!ModelState.IsValid) return View(galleryCommand);
        await _mediator.Send(galleryCommand);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Update(int id)
    {
        var gallery = await _mediator.Send(new GetGalleryByIdQuery(id));

        return View(_mapper.Map<UpdateGalleryCommand>(gallery));
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateGalleryCommand command)
    {
        if (!ModelState.IsValid) return View(command);
        await _mediator.Send(command);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _mediator.Send(new RemoveGalleryCommand(id));
        return RedirectToAction(nameof(Index));
    }
}
