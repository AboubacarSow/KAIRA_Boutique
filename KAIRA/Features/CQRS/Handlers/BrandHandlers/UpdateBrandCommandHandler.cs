﻿using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.CQRS.Commands.BrandCommands;
using KAIRA.Repositories.Contracts;
using KAIRA.Utilities.Extensions;

namespace KAIRA.Features.CQRS.Handlers.BrandHandlers;

public class UpdateBrandCommandHandler
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public UpdateBrandCommandHandler(IMapper mapper, IRepositoryManager repositoryManager)
    {
        this.mapper = mapper;
        this.repositoryManager = repositoryManager;
    }
    public async Task Handle(UpdateBrandCommand command)
    {
        
        var brand = mapper.Map<Brand>(command);
        if(command.ImageFile != null)  brand.ImageUrl=Media.UploadImage(command.ImageFile);
        await repositoryManager.Brand.UpdateAsync(brand);
    }
}
