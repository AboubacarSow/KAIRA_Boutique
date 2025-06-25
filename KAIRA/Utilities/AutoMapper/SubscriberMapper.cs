using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.Mediator.Commands.SubscriberCommands;
using KAIRA.Features.Mediator.Results.SubscriberResults;

namespace KAIRA.Utilities.AutoMapper;

public class SubscriberMapper : Profile
{
    public SubscriberMapper()
    {
        CreateMap<Subscriber, GetSubscriberQueryResult>();
        CreateMap<Subscriber, CreateSubscriberCommand>().ReverseMap();
    }
}
