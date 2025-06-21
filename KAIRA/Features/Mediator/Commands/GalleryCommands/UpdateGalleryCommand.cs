using MediatR;
namespace KAIRA.Features.Mediator.Commands.GalleryCommands;
public class UpdateGalleryCommand :IRequest
{
    public int Id { get; set; }
    public string ImageUrl { get; set; }
}
