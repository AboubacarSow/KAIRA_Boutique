using KAIRA.Features.Mediator.Commands.ProductCommands;
using KAIRA.Features.Mediator.Queries.ProductQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace KAIRA.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController(IMediator _mediator) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var products = await _mediator.Send(new GetProductsQuery());
            return View(products);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            return View(await _mediator.Send(new GetProductByIdQuery(id)));
        }
        [HttpGet]
        public IActionResult Create() { return View(); }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateProductCommand command)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Please review your data");
                return View(command);
            }
            await _mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }
    }
}
