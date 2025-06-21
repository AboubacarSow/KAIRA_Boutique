using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.CQRS.Commands.ServiceCommands;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Features.CQRS.Handlers.ServiceHandlers;

public class UpdateServiceCommandHandler 
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public UpdateServiceCommandHandler(IMapper mapper, IRepositoryManager repositoryManager)
    {
        this.mapper = mapper;
        this.repositoryManager = repositoryManager;
    }
    public async Task Handle(UpdateServiceCommand command)
    {
        var service = mapper.Map<Service>(command);
        await repositoryManager.Service.UpdateAsync(service);   
    }
}
