namespace KAIRA.Repositories.Contracts;

public interface IRepositoryManager
{
    ICategoryRepository Category { get; }
    IProductRepository Product { get; }
    ISubscriberRepository Subscriber { get; }
    IBrandRepository Brand { get; }
    IContactInfoRepository ContactInfo { get; } 
    IServiceRepository Service { get; }
    IGalleryRepository Gallery { get; }
    ISocialMediaRepository SocialMedia { get; }
    ITestimionilaRepository Testimionila { get; }   

}
