namespace KAIRA.Features.CQRS.Results.HizmetResults;

public class GetServiceQueryResult
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

}
