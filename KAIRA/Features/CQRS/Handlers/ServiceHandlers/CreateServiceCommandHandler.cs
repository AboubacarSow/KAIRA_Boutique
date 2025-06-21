using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.CQRS.Commands.ServiceCommands;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Features.CQRS.Handlers.ServiceHandlers;

public class CreateServiceCommandHandler
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public CreateServiceCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }
    public async Task Handle(CreateServiceCommand command)
    {
        var service = mapper.Map<Service>(command);
        await repositoryManager.Service.CreateAsync(service);
    }
}
