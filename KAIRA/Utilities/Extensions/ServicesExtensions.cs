using KAIRA.Features.CQRS.Handlers.BrandHandlers;
using KAIRA.Features.CQRS.Handlers.CategoryHandlers;
using KAIRA.Features.CQRS.Handlers.ServiceHandlers;
using KAIRA.Features.CQRS.Handlers.TestimonialHandlers;

namespace KAIRA.Utilities.Extensions;

public static class ServicesExtensions
{
    public static void RegisterServices(this IServiceCollection services)
    {
        // Category 
        services.AddScoped<GetCategoryQueryHandler>();
        services.AddScoped<GetCategoryByIdQueryHandler>();
        services.AddScoped<CreateCategoryCommandHandler>();
        services.AddScoped<UpdateCategoryCommandHandler>();
        services.AddScoped<RemoveCategoryCommandHandler>();

        //Service entity

        services.AddScoped<GetServiceQueryHandler>();
        services.AddScoped<GetServiceByIdQueryHandler>();
        services.AddScoped<CreateServiceCommandHandler>();
        services.AddScoped<UpdateServiceCommandHandler>();
        services.AddScoped<RemoveServiceCommandHandler>();

         //Testimonial entity

        services.AddScoped<GetTestimonialQueryHandler>();
        services.AddScoped<CreateTestimonialCommandHandler>();
        services.AddScoped<RemoveTestimonialCommandHandler>();

         //Brand entity

        services.AddScoped<GetBrandQueryHandler>();
        services.AddScoped<GetBrandByIdQueryHandler>();
        services.AddScoped<CreateBrandCommandHandler>();
        services.AddScoped<UpdateBrandCommandHandler>();
        services.AddScoped<RemoveBrandCommandHandler>();

    }
}
