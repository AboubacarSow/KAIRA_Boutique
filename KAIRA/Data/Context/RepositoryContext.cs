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
    }
}
