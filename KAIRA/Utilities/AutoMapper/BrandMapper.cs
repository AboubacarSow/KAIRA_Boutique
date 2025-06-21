using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.CQRS.Commands.BrandCommands;
using KAIRA.Features.CQRS.Results.BrandResults;

namespace KAIRA.Utilities.AutoMapper;

public class BrandMapper : Profile
{
    public BrandMapper()
    {
        CreateMap<Brand, GetBrandQueryResult>();
        CreateMap<Brand, GetBrandByIdQueryResult>();
        CreateMap<Brand, CreateBrandCommand>();
        CreateMap<Brand, UpdateBrandCommand>().ReverseMap();
    }
}
