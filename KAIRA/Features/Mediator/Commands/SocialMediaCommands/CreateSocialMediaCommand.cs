using MediatR;

namespace KAIRA.Features.Mediator.Commands.SocialMediaCommands;

public class CreateSocialMediaCommand:IRequest
{
    public string Name { get; set; }
    public string Link { get; set; }
    public string Icon { get; set; }
}
