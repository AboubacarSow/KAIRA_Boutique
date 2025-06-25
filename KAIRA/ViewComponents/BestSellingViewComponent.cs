using KAIRA.Features.Mediator.Queries.ProductQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KAIRA.ViewComponents;

public class BestSellingViewComponent: ViewComponent
{
    private readonly IMediator _mediator;

    public BestSellingViewComponent(IMediator mediator)
    {
        _mediator = mediator;   
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var products = (await _mediator.Send(new GetProductsQuery())).OrderByDescending(p=>p.Id).Take(5).ToList();  
     
        return View(products);
    }
}
