using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.CQRS.Commands.BrandCommands;
using KAIRA.Repositories.Contracts;
using KAIRA.Utilities.Extensions;

namespace KAIRA.Features.CQRS.Handlers.BrandHandlers;

public class CreateBrandCommandHandler
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public CreateBrandCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }
    public async Task Handle(CreateBrandCommand command)
    {
        var brand = new Brand
        {
            ImageUrl = Media.UploadImage(command.ImageFile)
        };
        await repositoryManager.Brand.CreateAsync(brand);
    }
}
