using AutoMapper;
using KAIRA.Features.CQRS.Results.TestimonialResults;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Features.CQRS.Handlers.TestimonialHandlers;

public class GetTestimonialQueryHandler
{
    private readonly IRepositoryManager repositoryManager;
    private readonly IMapper mapper;
    public GetTestimonialQueryHandler(IRepositoryManager repositoryManager, IMapper mapper)
    {
        this.repositoryManager = repositoryManager;
        this.mapper = mapper;
    }

    public async Task<List<GetTestimonialQueryResult>> Handle()
    {
        var services= await repositoryManager.Testimionial.GetAllAsync(trackCkanges: false);
        return mapper.Map<List<GetTestimonialQueryResult>>(services);
    }
}
