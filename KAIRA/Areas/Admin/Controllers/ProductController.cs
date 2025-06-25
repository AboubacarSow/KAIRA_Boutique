using AutoMapper;
using KAIRA.Features.CQRS.Handlers.CategoryHandlers;
using KAIRA.Features.CQRS.Results.CategoryResults;
using KAIRA.Features.Mediator.Commands.ProductCommands;
using KAIRA.Features.Mediator.Queries.ProductQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;


namespace KAIRA.Areas.Admin.Controllers;

[Area("Admin")]
public class ProductController(IMediator _mediator,GetCategoryQueryHandler getCategoryHandler,IMapper mapper) : Controller
{
    private int pageSize { get; set; } = 5;
    
    public async Task<IActionResult> Index(int pageNumber)
    {

        var products = await _mediator.Send(new GetProductsQuery());
        decimal count = products.Count;
        if (pageNumber < 1) pageNumber = 1;
        var pagedList = products.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
        var totalPage = (int)Math.Ceiling(count / pageSize);

        ViewBag.TotalPages = totalPage;
        ViewBag.CurrentPage = pageNumber;
        var resultProducts = pagedList.OrderByDescending(p => p.Id).ToList();
        return View(resultProducts);
    }
    [HttpGet]
    public async Task<IActionResult> Update(int id)
    {
        await GetCategories();
        var product = await _mediator.Send(new GetProductByIdQuery(id));
        return View(mapper.Map<UpdateProductCommand>(product));
    }
    private async Task GetCategories()
    {
        var categories = await getCategoryHandler.Handle();
        ViewBag.Categories = (from p in categories
                              select new SelectListItem
                              {
                                  Text = p.Name,
                                  Value = p.Id.ToString()
                              }).ToList();
    }
    [HttpPost]
    public async Task<IActionResult> Update(UpdateProductCommand command)
    {
        if (!ModelState.IsValid)
        {
            await GetCategories();
            return View(command);
        }
        await _mediator.Send(command);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public async Task<IActionResult> Create() { await GetCategories(); return View(); }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateProductCommand command)
    {
        if (!ModelState.IsValid)
        {
            await GetCategories();
            ModelState.AddModelError("", "Please review your data");
            return View(command);
        }
        await _mediator.Send(command);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _mediator.Send(new RemoveProductCommand(id));
        return RedirectToAction(nameof(Index));
    }
}
