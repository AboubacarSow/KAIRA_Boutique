using KAIRA.Features.Mediator.Handlers.ContactInfoHandlers;
using KAIRA.Features.Mediator.Queries.ContactInfoQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KAIRA.ViewComponents;

public class ContactViewComponent: ViewComponent
{
    private readonly IMediator _mediator;

    public ContactViewComponent(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var contact = (await _mediator.Send(new GetContactInfoQuery()))
            .OrderByDescending(c => c.Id).Take(1).First();
            return View(contact);
    }
}
