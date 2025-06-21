using MediatR;

namespace KAIRA.Features.Mediator.Commands.SocialMediaCommands;

public class RemoveSocialMediaCommand(int id):IRequest
{
    public int Id { get; set; } = id;
}
