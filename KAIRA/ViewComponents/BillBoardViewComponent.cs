using KAIRA.Features.Mediator.Queries.ProductQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KAIRA.ViewComponents;

public class BillBoardViewComponent : ViewComponent
{
    private readonly IMediator _mediator;
    public BillBoardViewComponent(IMediator mediator)
    {
        _mediator = mediator;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var products= (await _mediator.Send(new GetProductsQuery())).OrderByDescending(p=>p.Id).Take(4).ToList(); 
        return View(products);
    }
}
