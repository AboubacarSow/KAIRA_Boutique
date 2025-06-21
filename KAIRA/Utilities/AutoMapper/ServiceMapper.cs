using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.CQRS.Commands.ServiceCommands;
using KAIRA.Features.CQRS.Results.HizmetResults;

namespace KAIRA.Utilities.AutoMapper;

public class ServiceMapper : Profile
{
    public ServiceMapper()
    {
        CreateMap<Service,GetServiceQueryResult>();
        CreateMap<Service,GetServiceByIdQueryResult>();
        CreateMap<CreateServiceCommand, Service>();
        CreateMap<UpdateServiceCommand, Service>().ReverseMap();
    }
}
