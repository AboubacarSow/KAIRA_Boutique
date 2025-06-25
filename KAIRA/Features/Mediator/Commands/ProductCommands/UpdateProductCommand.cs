using MediatR;

namespace KAIRA.Features.Mediator.Commands.ProductCommands;

public class UpdateProductCommand:IRequest
{
    public int Id {  get; set; }    
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public IFormFile? ImageFile { get; set; } = null;
    public int CategoryId { get; set; }
}
