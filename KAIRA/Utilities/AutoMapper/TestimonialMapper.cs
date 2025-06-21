using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.CQRS.Commands.TestimonialCommands;
using KAIRA.Features.CQRS.Results.HizmetResults;
using KAIRA.Features.CQRS.Results.TestimonialResults;

namespace KAIRA.Utilities.AutoMapper;

public class TestimonialMapper : Profile
{
    public TestimonialMapper()
    {
        CreateMap<Testimonial, GetTestimonialQueryResult>();
        CreateMap<Testimonial, GetTestimonialByIdQueryResult>();
        CreateMap<Testimonial, CreateTestimonialCommand>();
    }
}
