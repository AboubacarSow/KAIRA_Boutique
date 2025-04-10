using AutoMapper;
using KAIRA.Features.Mediator.Queries.ProductQueries;
using KAIRA.Features.Mediator.Results.ProductResults;
using KAIRA.Repositories.Contracts;
using MediatR;

namespace KAIRA.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IMapper mapper, IRepositoryManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _manager.Product.GetByIdAsync(request.Id,false);
            return _mapper.Map<GetProductByIdQueryResult>(product);
        }
    }
}
