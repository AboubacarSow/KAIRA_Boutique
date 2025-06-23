using KAIRA.Features.CQRS.Handlers.ServiceHandlers;
using KAIRA.Features.CQRS.Results.HizmetResults;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KAIRA.ViewComponents;

public class ServiceViewComponent:ViewComponent
{
    private readonly GetServiceQueryHandler getServiceQueryHandler;
    public ServiceViewComponent(GetServiceQueryHandler getServiceQueryHandler)
    {
        this.getServiceQueryHandler = getServiceQueryHandler;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var services = await getServiceQueryHandler.Handle();
        return View(services);
    }
}
