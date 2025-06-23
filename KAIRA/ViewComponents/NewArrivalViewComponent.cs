using KAIRA.Features.Mediator.Queries.ProductQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KAIRA.ViewComponents;

public class NewArrivalViewComponent : ViewComponent
{
    private readonly IMediator mediator;

    public NewArrivalViewComponent(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var products= (await mediator.Send(new GetProductsQuery())).OrderByDescending(p=>p.Id).Take(5).ToList();
        return View(products);
    }
}
