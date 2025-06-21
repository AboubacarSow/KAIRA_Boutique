using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.Mediator.Commands.GalleryCommands;
using KAIRA.Features.Mediator.Results.GalleryResults;

namespace KAIRA.Utilities.AutoMapper;

public class GalleryMapper: Profile
{
    public GalleryMapper()
    {
        CreateMap<Gallery, GetGalleryQueryResult>();
        CreateMap<Gallery, GetGalleryByIdQueryResult>();
        CreateMap<CreateGalleryCommand, Gallery>();
        CreateMap<UpdateGalleryCommand, Gallery>().ReverseMap();
    }
}
