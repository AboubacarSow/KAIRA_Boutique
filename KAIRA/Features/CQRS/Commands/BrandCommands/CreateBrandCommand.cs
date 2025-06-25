namespace KAIRA.Features.CQRS.Commands.BrandCommands;

public class CreateBrandCommand
{
    public string? ImageUrl { get; set; } = string.Empty;
    public IFormFile ImageFile { get; set; }
}
