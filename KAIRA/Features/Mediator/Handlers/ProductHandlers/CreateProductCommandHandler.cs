using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.Mediator.Commands.ProductCommands;
using KAIRA.Repositories.Contracts;
using MediatR;

namespace KAIRA.Features.Mediator.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            await _manager.Product.CreateAsync(product);
        }
    }
}
