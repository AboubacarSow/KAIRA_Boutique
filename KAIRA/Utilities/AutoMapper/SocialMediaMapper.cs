using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.Mediator.Commands.SocialMediaCommands;
using KAIRA.Features.Mediator.Results.SocialMediaResults;

namespace KAIRA.Utilities.AutoMapper;

public class SocialMediaMapper : Profile
{
    public SocialMediaMapper()
    {
        CreateMap<SocialMedia, GetSocialMediaQueryResult>();
        CreateMap<SocialMedia,GetSocialMediaByIdQueryResult>();
        CreateMap<CreateSocialMediaCommand, SocialMedia>();
        CreateMap<UpdateSocialMediaCommand, SocialMedia>().ReverseMap();
        CreateMap<GetSocialMediaByIdQueryResult,UpdateSocialMediaCommand>().ReverseMap();
    }
}
