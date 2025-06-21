using KAIRA.Features.Mediator.Results.ContactInfoResults;
using MediatR;

namespace KAIRA.Features.Mediator.Queries.ContactInfoQueries;

public class GetContactInfoQuery:IRequest<List<GetContactInfoQueryResult>>
{
}
