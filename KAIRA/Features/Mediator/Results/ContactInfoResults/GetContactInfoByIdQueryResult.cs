namespace KAIRA.Features.Mediator.Results.ContactInfoResults;

public class GetContactInfoByIdQueryResult
{
    public int Id { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Address { get; set; }
}
