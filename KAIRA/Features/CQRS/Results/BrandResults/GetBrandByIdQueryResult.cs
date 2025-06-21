namespace KAIRA.Features.CQRS.Results.BrandResults;

public class GetBrandByIdQueryResult
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
