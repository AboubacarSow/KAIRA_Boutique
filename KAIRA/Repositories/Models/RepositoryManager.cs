using KAIRA.Data.Context;
using KAIRA.Repositories.Contracts;

namespace KAIRA.Repositories.Models;

public class RepositoryManager : IRepositoryManager
{
    private readonly Lazy<ICategoryRepository> _categoryService;
    private readonly Lazy<IProductRepository> _productService;
    private readonly Lazy<ISubscriberRepository> _subscriberService;
    private readonly Lazy<ITestimionilaRepository> _testimonialService;
    private readonly Lazy<IBrandRepository> _brandService;
    private readonly Lazy<ISocialMediaRepository> _socialMediaService;
    private readonly Lazy<IServiceRepository> _serviceRepos;
    private readonly Lazy<IGalleryRepository> _galleryService;
    private readonly Lazy<IContactInfoRepository> _contactInfoServie;
    private readonly RepositoryContext _context;

    public RepositoryManager(RepositoryContext context)
    {
        _context = context;
        _categoryService = new Lazy<ICategoryRepository>(() => new CategoryRepository(_context));
        _productService = new Lazy<IProductRepository>(() => new ProductRepository(_context));
        _contactInfoServie = new Lazy<IContactInfoRepository>(() => new ContactInfoRepository(_context));
        _subscriberService = new Lazy<ISubscriberRepository>(() => new SubscriberRepository(_context));
        _testimonialService = new Lazy<ITestimionilaRepository>(() => new TestimonialRepository(_context));
        _brandService = new Lazy<IBrandRepository>(() => new BrandRepository(_context));
        _socialMediaService = new Lazy<ISocialMediaRepository>(() => new SocialMediaRepository(_context));
        _serviceRepos = new Lazy<IServiceRepository>(() => new ServiceRepository(_context));
        _galleryService = new Lazy<IGalleryRepository>(() => new GalleryRepository(_context));
    }
    public ICategoryRepository Category => _categoryService.Value;
    public IProductRepository Product => _productService.Value;
    public ISubscriberRepository Subscriber => _subscriberService.Value;
    public IBrandRepository Brand => _brandService.Value;
    public IContactInfoRepository ContactInfo => _contactInfoServie.Value;
    public IServiceRepository Service => _serviceRepos.Value;
    public IGalleryRepository Gallery => _galleryService.Value;
    public ISocialMediaRepository SocialMedia => _socialMediaService.Value;
    public ITestimionilaRepository Testimionila => _testimonialService.Value;
}
