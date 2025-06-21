using KAIRA.Features.Mediator.Results.SubscriberResults;
using MediatR;

namespace KAIRA.Features.Mediator.Queries.SubcriberQueries;

public class GetSubscriberQuery:IRequest<List<GetSubscriberQueryResult>>
{
}
