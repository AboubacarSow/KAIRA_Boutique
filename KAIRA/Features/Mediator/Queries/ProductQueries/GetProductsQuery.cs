using KAIRA.Features.Mediator.Results.ProductResults;
using MediatR;

namespace KAIRA.Features.Mediator.Queries.ProductQueries
{
    public class GetProductsQuery :IRequest<List<GetProductQueryResult>>
    {
    }
}
