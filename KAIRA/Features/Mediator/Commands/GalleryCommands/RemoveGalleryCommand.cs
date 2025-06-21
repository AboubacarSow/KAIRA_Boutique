using MediatR;

namespace KAIRA.Features.Mediator.Commands.GalleryCommands;

public class RemoveGalleryCommand(int id):IRequest
{
    public int Id { get; set; } = id;
}
