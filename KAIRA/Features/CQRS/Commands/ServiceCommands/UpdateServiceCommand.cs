namespace KAIRA.Features.CQRS.Commands.ServiceCommands;

public class UpdateServiceCommand
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
