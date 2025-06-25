namespace KAIRA.Features.CQRS.Commands.BrandCommands;

public class UpdateBrandCommand
{
    public int Id { get; set; }
    public string ImageUrl   { get; set; } = string.Empty;

    public IFormFile ImageFile { get; set; }
}
