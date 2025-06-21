namespace KAIRA.Features.CQRS.Commands.TestimonialCommands;

public class CreateTestimonialCommand
{
    public string Comment { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
}
