namespace KAIRA.Features.CQRS.Commands.CategoryCommands;

public class UpdateCategoryCommand
{
    public int Id;
    public string Name { get; set; }
    public string ImageUrl { get; set; }
}
