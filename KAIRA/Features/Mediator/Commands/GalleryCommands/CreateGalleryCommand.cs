using MediatR;

namespace KAIRA.Features.Mediator.Commands.GalleryCommands;

public class CreateGalleryCommand:IRequest
{
    public string? ImageUrl { get; set; }
    public IFormFile ImageFile { get; set; }
}
