using MediatR;

namespace KAIRA.Features.Mediator.Commands.SubscriberCommands;

public class RemoveSubscriberCommand(int id):IRequest
{

    public int Id { get; set; } = id;
}
