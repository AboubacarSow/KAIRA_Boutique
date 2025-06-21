
using MediatR;

namespace KAIRA.Features.Mediator.Commands.ProductCommands;

public class CreateProductCommand : IRequest
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
}
