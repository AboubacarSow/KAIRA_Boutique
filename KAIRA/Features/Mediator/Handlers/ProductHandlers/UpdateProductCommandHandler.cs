using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.Mediator.Commands.ProductCommands;
using KAIRA.Repositories.Contracts;
using KAIRA.Utilities.Extensions;
using MediatR;

namespace KAIRA.Features.Mediator.Handlers.ProductHandlers;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public UpdateProductCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }

    public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product=mapper.Map<Product>(request);
         if(request.ImageFile!=null) product.ImageUrl=Media.UploadImage(request.ImageFile);
        await repositoryManager.Product.UpdateAsync(product);
    }
}
