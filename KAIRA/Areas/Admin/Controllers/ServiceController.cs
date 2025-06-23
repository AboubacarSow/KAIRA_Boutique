using KAIRA.Features.CQRS.Commands.BrandCommands;
using Microsoft.AspNetCore.Mvc;
using KAIRA.Features.CQRS.Handlers.ServiceHandlers;
using KAIRA.Features.CQRS.Queries.ServiceQueries;
using KAIRA.Features.CQRS.Commands.ServiceCommands;
using AutoMapper;

namespace KAIRA.Areas.Admin.Controllers;

[Area("Admin")]
public class ServiceController : Controller
{
    private readonly GetServiceQueryHandler _getServiceQueryHandler;
    private readonly GetServiceByIdQueryHandler _getServiceByIdQueryHandler;
    private readonly CreateServiceCommandHandler _createServiceCommandHandler;
    private readonly UpdateServiceCommandHandler _updateServiceCommandHandler;
    private readonly RemoveServiceCommandHandler _removeServiceCommandHandler;
    private readonly IMapper mapper;
    public ServiceController(GetServiceQueryHandler getServiceQueryHandler, GetServiceByIdQueryHandler getBrandByIdQueryHandler,
        CreateServiceCommandHandler createServiceCommandHandler, UpdateServiceCommandHandler updateServiceCommandHandler,
        RemoveServiceCommandHandler removeServiceCommandHandler,IMapper mapper)
    {
        _getServiceQueryHandler = getServiceQueryHandler;
        _getServiceByIdQueryHandler = getBrandByIdQueryHandler;
        _createServiceCommandHandler = createServiceCommandHandler;
        _updateServiceCommandHandler = updateServiceCommandHandler;
        _removeServiceCommandHandler = removeServiceCommandHandler;
        this.mapper = mapper;
    }
    public async Task<IActionResult> Index()
    {
        var services = await _getServiceQueryHandler.Handle();
        return View(services);

    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateServiceCommand serviceCommand)
    {
        if (!ModelState.IsValid)
        {
            return View(serviceCommand);
        }
        await _createServiceCommandHandler.Handle(serviceCommand);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public async Task<IActionResult> Update(int id)
    {
        var service = await _getServiceByIdQueryHandler.Handle(new GetServiceByIdQuery(id));
        return View(mapper.Map<UpdateServiceCommand>(service));
    }
    [HttpPost]
    public async Task<IActionResult> Update(UpdateServiceCommand brandCommand)
    {
        if (!ModelState.IsValid) return View(brandCommand);
        await _updateServiceCommandHandler.Handle(brandCommand);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _removeServiceCommandHandler.Handle(new RemoveServiceCommand(id));
        return RedirectToAction(nameof(Index));
    }

}
