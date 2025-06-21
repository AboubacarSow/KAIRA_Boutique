using KAIRA.Features.Mediator.Results.ContactInfoResults;
using MediatR;

namespace KAIRA.Features.Mediator.Queries.ContactInfoQueries;

public class GetContactInfoByIdQuery(int id):IRequest<GetContactInfoByIdQueryResult>
{
    public int Id { get; set; } = id;
}
