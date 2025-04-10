using KAIRA.Features.Mediator.Results.ProductResults;
using MediatR;

namespace KAIRA.Features.Mediator.Queries.ProductQueries
{
    public class GetProductByIdQuery(int _id): IRequest<GetProductByIdQueryResult>
    {
        public int Id { get; set; } = _id;
    }
}
