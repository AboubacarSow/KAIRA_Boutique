using MediatR;

namespace KAIRA.Features.Mediator.Commands.SubscriberCommands;
public class CreateSubscriberCommand :IRequest
{
    public string UserName { get; set; }
    public string Email { get; set; }
}
