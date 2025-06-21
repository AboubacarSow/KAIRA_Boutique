using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.CQRS.Commands.TestimonialCommands;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Features.CQRS.Handlers.TestimonialHandlers;
public class CreateTestimonialCommandHandler
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public CreateTestimonialCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }

    public async Task Handle(CreateTestimonialCommand command)
    {
        var testimonial= mapper.Map<Testimonial>(command);  
        await repositoryManager.Testimionial.CreateAsync(testimonial);  
    }
}
