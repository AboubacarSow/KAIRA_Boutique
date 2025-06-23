using Microsoft.AspNetCore.Mvc;
using KAIRA.Features.CQRS.Handlers.BrandHandlers;
using KAIRA.Features.CQRS.Commands.BrandCommands;
using KAIRA.Features.CQRS.Queries.BrandQueries;
using KAIRA.Features.CQRS.Commands.BrandCommand;
using AutoMapper;
namespace KAIRA.Areas.Admin.Controllers;

[Area("Admin")]
public class BrandController : Controller
{
    private readonly GetBrandQueryHandler _getBrandQueryHandler;
    private readonly GetBrandByIdQueryHandler _getBrandByIdQueryHandler;
    private readonly CreateBrandCommandHandler _createBrandCommandHandler;
    private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;
    private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;
    private readonly IMapper mapper;
    public BrandController(GetBrandQueryHandler getBrandQueryHandler, GetBrandByIdQueryHandler getBrandByIdQueryHandler,
        CreateBrandCommandHandler createBrandCommandHandler, UpdateBrandCommandHandler updateBrandCommandHandler,
        RemoveBrandCommandHandler removeBrandCommandHandler, IMapper mapper)
    {
        _getBrandQueryHandler = getBrandQueryHandler;
        _getBrandByIdQueryHandler = getBrandByIdQueryHandler;
        _createBrandCommandHandler = createBrandCommandHandler;
        _updateBrandCommandHandler = updateBrandCommandHandler;
        _removeBrandCommandHandler = removeBrandCommandHandler;
        this.mapper = mapper;
    }
    public async Task<IActionResult> Index()
    {
        var brands = await _getBrandQueryHandler.Handle();
        return View(brands);

    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateBrandCommand brandCommand)
    {
        if(!ModelState.IsValid)
        {
            return View(brandCommand);
        }
        await _createBrandCommandHandler.Handle(brandCommand);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public async Task<IActionResult> Update(int id)
    {
        var brand = await _getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));

        return View(mapper.Map<UpdateBrandCommand>(brand));
    }
    [HttpPost]
    public async Task<IActionResult> Update(UpdateBrandCommand brandCommand)
    {
        if(!ModelState.IsValid) return View(brandCommand);
        await _updateBrandCommandHandler.Handle(brandCommand);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _removeBrandCommandHandler.Handle(new RemoveBrandCommand(id));
        return RedirectToAction(nameof(Index));
    }
    
    
}
