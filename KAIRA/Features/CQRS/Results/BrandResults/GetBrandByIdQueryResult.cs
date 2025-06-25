namespace KAIRA.Features.CQRS.Results.BrandResults;

public class GetBrandByIdQueryResult
{
    public int Id { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
}
