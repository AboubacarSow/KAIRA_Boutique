namespace KAIRA.Features.CQRS.Queries.BrandQueries;

public class GetBrandByIdQuery(int id)
{
    public int Id { get; set; } =id;
}
