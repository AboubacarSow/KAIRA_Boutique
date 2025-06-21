namespace KAIRA.Features.CQRS.Results.TestimonialResults;

public class GetTestimonialQueryResult
{
    public int Id { get; set; }
    public string Comment { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
}
