using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.Mediator.Results.ProductResults;

namespace KAIRA.Utilities.AutoMapper;

public class ProductMapping: Profile
{
    public ProductMapping()
    {
        CreateMap<Product, GetProductQueryResult>();
        CreateMap<Product, GetProductByIdQueryResult>(); 
    }
}
