namespace KAIRA.Features.CQRS.Commands.TestimonialCommands;

public class RemoveTestimonialCommand(int id)
{
    public int Id { get; set; } = id;
}
