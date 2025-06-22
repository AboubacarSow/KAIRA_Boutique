using KAIRA.Features.CQRS.Commands.TestimonialCommands;
using KAIRA.Features.CQRS.Handlers.TestimonialHandlers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KAIRA.Areas.Admin.Controllers;
[Area("Admin")]
public class TestimonialContoller: Controller
{
    private readonly GetTestimonialQueryHandler _getTestimonialQueryHandler;
    private readonly CreateTestimonialCommandHandler _createTestimonialCommandHandler;
    private readonly RemoveTestimonialCommandHandler _removeTestimonialCommandHandler;

    public TestimonialContoller(GetTestimonialQueryHandler getTestimonialQueryHandler, 
        CreateTestimonialCommandHandler createTestimonialCommandHandler,
        RemoveTestimonialCommandHandler removeTestimonialCommandHandler)
    {
        _getTestimonialQueryHandler = getTestimonialQueryHandler;
        _createTestimonialCommandHandler = createTestimonialCommandHandler;
        _removeTestimonialCommandHandler = removeTestimonialCommandHandler;
    }

    public async Task<IActionResult> Index()
    {
        var testimonials = await _getTestimonialQueryHandler.Handle();

        return View(testimonials);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateTestimonialCommand command)
    {
        if(!ModelState.IsValid)
        {
            return View(command);
        }
        await _createTestimonialCommandHandler.Handle(command);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _removeTestimonialCommandHandler.Handle(new RemoveTestimonialCommand(id));
        return RedirectToAction(nameof(Index));
    }

    
}
