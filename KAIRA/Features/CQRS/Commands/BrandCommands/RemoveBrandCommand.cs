namespace KAIRA.Features.CQRS.Commands.BrandCommand
{
    public class RemoveBrandCommand(int id)
    {
        public int Id { get; set; } = id;   
    }
}
