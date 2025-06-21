using MediatR;

namespace KAIRA.Features.Mediator.Commands.ContactInfoCommands;

public class UpdateContactInfoCommand: IRequest
{
    public int Id { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Address { get; set; }
}
