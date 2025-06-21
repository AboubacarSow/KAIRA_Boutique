using KAIRA.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace KAIRA.Data.Context
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }  

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Brand> Brands{get;set;}
        public DbSet<Service> Services{get;set;}
        public DbSet<Testimonial> Testimonials{get;set;}
        public DbSet<ContactInfo> ContactInfos{get;set;}
        public DbSet<Gallery> Galleries{get;set;}
        public DbSet<Subscriber> Subscribers {get;set;}
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}
