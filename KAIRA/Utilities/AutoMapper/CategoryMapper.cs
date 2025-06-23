using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.CQRS.Commands.CategoryCommands;
using KAIRA.Features.CQRS.Results.CategoryResults;

namespace KAIRA.Utilities.AutoMapper
{
    public class CategoryMapper: Profile
    {
        public CategoryMapper()
        {
            CreateMap<Category, GetCategoryQueryResult>();
            CreateMap<Category, GetCategoryByIdQueryResult>();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
        }
    }
}
