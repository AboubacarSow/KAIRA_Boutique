using AutoMapper;
using KAIRA.Features.Mediator.Queries.ProductQueries;
using KAIRA.Features.Mediator.Results.ProductResults;
using KAIRA.Repositories.Contracts;
using MediatR;

namespace KAIRA.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductsQuery, List<GetProductQueryResult>>
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryManager _manager;

        public GetProductQueryHandler(IMapper mapper, IRepositoryManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }


        public async Task<List<GetProductQueryResult>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _manager.Product.GetAllAsync(include: p=>p.Category,false);
            return _mapper.Map<List<GetProductQueryResult>>(products);
        }
    }
}
