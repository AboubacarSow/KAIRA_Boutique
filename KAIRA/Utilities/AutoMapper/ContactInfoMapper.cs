using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.Mediator.Commands.ContactInfoCommands;
using KAIRA.Features.Mediator.Results.ContactInfoResults;

namespace KAIRA.Utilities.AutoMapper;

public class ContactInfoMapper : Profile
{
    public ContactInfoMapper()
    {
        CreateMap<ContactInfo, GetContactInfoQueryResult>();
        CreateMap<ContactInfo, GetContactInfoByIdQueryResult>();
        CreateMap<CreateContactInfoCommand, ContactInfo>();
        CreateMap<UpdateContactInfoCommand, ContactInfo>().ReverseMap();
    }
}
